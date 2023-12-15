﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_商品管理 : Form
    {
        private readonly InputCheck ichk = new InputCheck();
        readonly ProductDataAccess PDA = new ProductDataAccess();
        readonly  ProductDbConnection DB = new ProductDbConnection();
        private static List<M_Maker> MNameDsp;
        private static List<M_SmallClassification> ScDsp;
       readonly LoginData LoginData;
        readonly StockDataAccess SDA=new StockDataAccess(); 


        public F_商品管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }

        //画面ロード時処理
        private void F_商品管理_Load(object sender, EventArgs e)
        {
            TextboxSyouhinID.ReadOnly = true;
            TextboxHihyouji.Enabled = false;

            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("商品情報を取得することができません。", "商品確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //商品情報の全件取得
            List<DispProductListDTO> tb = DB.ProductGetData("", "");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            MNameDsp = DB.GetMakerNameDspData();
            ComboMakerName.Items.AddRange(MNameDsp.ToArray());
            ComboMakerName.DisplayMember = "MaName";
            ComboMakerName.ValueMember = "MaID";
            ComboMakerName.DataSource = MNameDsp;

            ScDsp = DB.GetScDspData();
            ComboSyobunrui.Items.AddRange(ScDsp.ToArray());
            ComboSyobunrui.DisplayMember = "ScName";
            ComboSyobunrui.ValueMember = "ScID";
            ComboSyobunrui.DataSource = ScDsp;

            //初期値を０に
            ComboMakerName.SelectedIndex = 0;
            ComboSyobunrui.SelectedIndex = 0;

            //読み込み専用に
            ComboMakerName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSyobunrui.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispProductListDTO> tb)
        {
            dataGridView1.DataSource = tb;
            //列幅自動設定解除
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //ヘッダーの高さ
            dataGridView1.ColumnHeadersHeight = 50;
            //ヘッダーの折り返し表示
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //行単位選択     
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー文字位置、セル文字位置、列幅の設定
            ////商品ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 40;
            ////メーカー名
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].Width = 50;
            //商品名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].Width = 80;
            //価格
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].Width = 80;
            ////安全在庫数
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].Width = 40;
            ////小分類
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].Width = 80;
            ////型番
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 30;
            ////色
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].Width = 70;
            ////発売日
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].Width = 80;


            dataGridView1.Refresh();
        }

        //データグリッドビューをクリックしたときの処理
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RadioTouroku.Checked == true)
            {
                ComboMakerName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TextboxSyohinName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TextboxKakaku.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                TextboxStock.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                ComboSyobunrui.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                TextboxKataban.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                TextboxColor.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
                HatubaiDate.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            }
            else
            {
                TextboxSyouhinID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                ComboMakerName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TextboxSyohinName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TextboxKakaku.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                TextboxStock.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                ComboSyobunrui.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                TextboxKataban.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                TextboxColor.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
                HatubaiDate.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            }
           
        }


        //実行ボタン
        private void ButtonExe_Click(object sender, EventArgs e)
        {
            //登録処理----------------------------------------------------------------------
            if (RadioTouroku.Checked == true)
            {
                if (!GetVaildDataAtRegistration())
                {
                    return;
                }
                var regPro = GenerateProductDataAtRegistration();
                var regSto =GenerateStockDataAtRegistration();

                RegistrationProduct(regPro);
            }

            //検索処理----------------------------------------------------------------------
            if (RadioKensaku.Checked == true)
            {
                {
                    if (!GetVaildDataAtSelect())
                    {
                        return;
                    }
                    GenerateDataAtSelect();
                }
            }

            //更新処理----------------------------------------------------------------------
            if (RadioKousin.Checked == true)
            {
                if (RadioKousin.Checked == true)
                {
                    if (!GetVaildDataAtUpdate())
                    {
                        return;
                    }

                    var updProduct = GenereteDataAtUpdate();

                    UpdateProduct(updProduct);
                }
            }

            //非表示処理--------------------------------------------------------------------
            if (RadioHihyouji.Checked == true)
            {
                if (!GetVaildDataAtHide())
                {
                    return;
                }

                var hidProduct = GenereteDataAtHidden();

                HideProduct(hidProduct);
            }
        }


        //以下モジュール
        //登録処理--------------------------------------------------------------------------
        private bool GetVaildDataAtRegistration() //入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxSyohinName.Text.Trim()))
            {
                MessageBox.Show("商品名が入力されていません");
                TextboxSyohinName.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxStock.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxStock.Text.Trim()))
                {
                    MessageBox.Show("安全在庫数は半角数字で入力してください");
                    TextboxStock.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("安全在庫数が入力されていません");
                TextboxStock.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(TextboxKakaku.Text.Trim()))
            {
                MessageBox.Show("価格が入力されていません");
                TextboxKakaku.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxColor.Text.Trim()))
            {
                MessageBox.Show("色が入力されていません");
                TextboxColor.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(TextboxKataban.Text.Trim()))
            {
                MessageBox.Show("型番が入力されていません");
            }

            return true;
        }

        private M_Product GenerateProductDataAtRegistration() //登録データ生成
        {
            int ManuID = ComboMakerName.SelectedIndex;
            int Sc = ComboSyobunrui.SelectedIndex;
            return new M_Product
            {
                MaID = ManuID+1,
                //PrID = int.Parse(TextboxSyouhinID.Text.Trim()),
                PrName = TextboxSyohinName.Text.Trim(),
                ScID = Sc+1,
                PrModelNumber = TextboxKataban.Text.Trim(),
                PrSafetyStock = int.Parse(TextboxStock.Text.Trim()),
                Price = decimal.Parse((TextboxKakaku.Text.Trim())),
                PrColor = TextboxColor.Text.Trim(),
                PrReleaseDate = HatubaiDate.Value,
                PrFlag = 0,
                PrHidden = null,
            };
        }
      

        private void RegistrationProduct(M_Product regPro) //データ登録処理
        {
            DialogResult result = MessageBox.Show("商品データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg1 = PDA.AddProductData(regPro);
            if (flg1 == true)
            {
                MessageBox.Show("データを登録しました");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxSyouhinID.Focus();
            }
            ClearInput();
            GetDataGridView();
        }
        //在庫登録処理-------------------------------------------------------------------
        private T_Stock GenerateStockDataAtRegistration() //登録データ生成
        {
            return new T_Stock
            {
                PrID = DB.GetPrID(),
                StQuantity=0,
                
            };
        }
        private void RegistrationStock(T_Stock regSto) //データ登録処理
        {
            bool flg1 = SDA.AddStockData(regSto);
            if (flg1 == true)
            {
                MessageBox.Show("データを登録しました");
            }
            else
            {
                MessageBox.Show("在庫データの登録に失敗しました");
                TextboxSyouhinID.Focus();
            }
            ClearInput();
            GetDataGridView();
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxSyouhinID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyouhinID.Text.Trim()))
                {
                    MessageBox.Show("商品コードはすべて半角数字で入力してください。");
                    TextboxSyouhinID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxStock.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxStock.Text.Trim()))
                {
                    MessageBox.Show("安全在庫数は半角数字で入力してください");
                    TextboxStock.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxKakaku.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxKakaku.Text.Trim()))
                {
                    MessageBox.Show("価格は半角数字で入力してください");
                    TextboxKakaku.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(TextboxKataban.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxKataban.Text.Trim()))
                {
                    MessageBox.Show("型番は半角数字で入力してください");
                    TextboxKakaku.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool GenerateDataAtSelect() //検索データ生成
        {
            int MaID;
            if (ComboMakerName.SelectedIndex == -1)
            {
                MaID = -1;
            }
            else
            {
                MaID = int.Parse(ComboMakerName.SelectedValue.ToString());
            }
            int ScID;
            if (ComboSyobunrui.SelectedIndex == -1)
            {
                ScID = -1;
            }
            else
            {
                ScID = int.Parse(ComboSyobunrui.SelectedValue.ToString());
            }
            //整数型(int)に変換する準備
            //商品ID
            var PrID = TextboxSyouhinID.Text.Trim();
            //価格
            var Price = TextboxKakaku.Text.Trim();
            //安全在庫数
            var SStock = TextboxStock.Text.Trim();
            //型番
            var ModelNo = TextboxKataban.Text.Trim();

            //変換処理
            if (!int.TryParse(PrID, out  int SyohinID))
            {
                SyohinID = -1;
            }

            if (!int.TryParse(Price, out  int Kakaku))
            {
                Kakaku = -1;
            }
            if (!int.TryParse(SStock, out int Stock))
            {
                Stock = -1;
            }

            M_Product selectCondition = new M_Product()
            {
                MaID = MaID,
                ScID = ScID,
                PrID = SyohinID,
                PrName = TextboxSyohinName.Text.Trim(),
                Price = Kakaku,
                PrSafetyStock = Stock,
                PrModelNumber = ModelNo,
                PrColor = TextboxColor.Text.Trim(),
                PrReleaseDate = HatubaiDate.Value,
            };

            List<DispProductListDTO> tb = DB.GetProductData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //更新処理-----------------------------------------------------------------------
        private bool GetVaildDataAtUpdate()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxSyohinName.Text.Trim()))
            {
                MessageBox.Show("商品名が入力されていません");
                TextboxSyohinName.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxStock.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxStock.Text.Trim()))
                {
                    MessageBox.Show("安全在庫数は半角数字で入力してください");
                    TextboxStock.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("安全在庫数が入力されていません");
                TextboxStock.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxKakaku.Text.Trim()))
            {
                MessageBox.Show("価格が入力されていません");
                TextboxKakaku.Focus();
                return false;
            }
            

            if (String.IsNullOrEmpty(TextboxColor.Text.Trim()))
            {
                MessageBox.Show("色が入力されていません");
                TextboxColor.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxKataban.Text.Trim()))
            {
                MessageBox.Show("型番が入力されていません");
            }
            return true;
        }

        private M_Product GenereteDataAtUpdate()　//更新データ生成
        {
             int ManuID = ComboMakerName.SelectedIndex;
            int Sc = ComboSyobunrui.SelectedIndex;
            return new M_Product
            {
                MaID = ManuID+1,
                PrID = int.Parse(TextboxSyouhinID.Text.Trim()),
                PrName = TextboxSyohinName.Text.Trim(),
                ScID = Sc+1,
                PrModelNumber = TextboxKataban.Text.Trim(),
                PrSafetyStock = int.Parse(TextboxStock.Text.Trim()),
                Price = decimal.Parse((TextboxKakaku.Text.Trim())),
                PrColor = TextboxColor.Text.Trim(),
                PrReleaseDate = HatubaiDate.Value,
                PrFlag = 0,
                PrHidden = null,
            };
        }

        private void UpdateProduct(M_Product updPro)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("商品データを更新します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = PDA.UpdateProductData(updPro);
            if (flg == true)
            {
                MessageBox.Show("データを更新しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの更新に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSyohinName.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //非表示処理---------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxHihyouji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DB.CheckCascadeProduct(int.Parse(TextboxSyouhinID.Text.Trim()))==-1)
            {
                MessageBox.Show("選択された商品は他で使用されているため非表示にできません。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private M_Product GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            int ManuID = ComboMakerName.SelectedIndex;
            int Sc = ComboSyobunrui.SelectedIndex;
            M_Product retProduct = new M_Product
            {
                MaID = ManuID+1,
                PrID = int.Parse(TextboxSyouhinID.Text.Trim()),
                PrName = TextboxSyohinName.Text.Trim(),
                ScID = Sc+1,
                PrModelNumber = TextboxKataban.Text.Trim(),
                PrSafetyStock = int.Parse(TextboxStock.Text.Trim()),
                Price = decimal.Parse((TextboxKakaku.Text.Trim())),
                PrColor = TextboxColor.Text.Trim(),
                PrReleaseDate = HatubaiDate.Value,
                PrFlag = 2,
                PrHidden = TextboxHihyouji.Text.Trim(),

            };
            return retProduct;
        }

        private void HideProduct(M_Product hidEmp)　//データ非表示処理
        {
            DialogResult result = MessageBox.Show("商品データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = PDA.HideProductData(hidEmp);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearInput();
            GetDataGridView();
        }


        //入力クリア----------------------------------------------------------------------
        private void ClearInput()
        {
            //検索時または非表示時はコンボボックスの値を空にする
            if (RadioKensaku.Checked == true||RadioHihyouji.Checked==true)
            {
                ComboMakerName.SelectedIndex = -1;
                ComboSyobunrui.SelectedIndex = -1;
                TextboxSyouhinID.Text = "";
                TextboxSyohinName.Text = "";
                TextboxKakaku.Text = "";
                TextboxStock.Text = "";
                ComboSyobunrui.Text = "";
                TextboxKataban.Text = "";
                TextboxColor.Text = "";
                HatubaiDate.Value = DateTime.Now;
                TextboxHihyouji.Text = "";
            }
            //検索時または非表示時以外は表示する
            else
            {
                ComboMakerName.SelectedIndex = 0;
                ComboSyobunrui.SelectedIndex = 0;
                TextboxSyouhinID.Text = "";
                TextboxSyohinName.Text = "";
                TextboxKakaku.Text = "";
                TextboxStock.Text = "";
                ComboSyobunrui.Text = "";
                TextboxKataban.Text = "";
                TextboxColor.Text = "";
                HatubaiDate.Value = DateTime.Now;
                TextboxHihyouji.Text = "";
            }
        }

        //入力リセットボタン-------------------------------------------------------------
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        //戻るボタン----------------------------------------------------------------------
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_物流 f_buturyu = new F_物流(LoginData);
            f_buturyu.Show();
            return;
        }


        //登録時の入力項目選択-----------------------------------------------------------
        private void RadioTouroku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyouhinID.ReadOnly = true;
            TextboxSyohinName.ReadOnly = false;
            ComboMakerName.SelectedIndex = 0;
            TextboxKakaku.ReadOnly = false;
            TextboxStock.ReadOnly = false;
            ComboSyobunrui.SelectedIndex = 0;
            TextboxKataban.ReadOnly = false;
            TextboxColor.ReadOnly = false;
            LblHatubaiDate.Visible = true;
            TextboxHihyouji.Enabled = false;
            HatubaiDate.Visible = true;
            ComboMakerName.Enabled = true;
            ComboSyobunrui.Enabled = true;
            GetDataGridView();
        }
        //検索時の入力項目選択-----------------------------------------------------------
        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyouhinID.ReadOnly = false;
            TextboxSyohinName.ReadOnly = false;
            ComboMakerName.SelectedIndex = -1;
            TextboxKakaku.ReadOnly = false;
            TextboxStock.ReadOnly = false;
            ComboSyobunrui.SelectedIndex = -1;
            TextboxKataban.ReadOnly = false;
            TextboxColor.ReadOnly = false;
            LblHatubaiDate.Visible = false;
            TextboxHihyouji.Enabled = false;
            HatubaiDate.Visible = false;
            ComboMakerName.Enabled = true;
            ComboSyobunrui.Enabled = true;
            GetDataGridView();
        }
        //更新時の入力項目選択-----------------------------------------------------------
        private void RadioKousin_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyouhinID.ReadOnly = true;
            TextboxSyohinName.ReadOnly = false;
            ComboMakerName.SelectedIndex = 0;
            TextboxKakaku.ReadOnly = false;
            TextboxStock.ReadOnly = false;
            ComboSyobunrui.SelectedIndex = 0;
            TextboxKataban.ReadOnly = false;
            TextboxColor.ReadOnly = false;
            LblHatubaiDate.Visible = true;
            HatubaiDate.Visible = true;
            TextboxHihyouji.Enabled = false;
            ComboMakerName.Enabled = true;
            ComboSyobunrui.Enabled = true;
            GetDataGridView();
        }
        //非表示時の入力項目選択-----------------------------------------------------------
        private void RadioHihyouji_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyouhinID.ReadOnly = true;
            TextboxSyohinName.ReadOnly = true;
            ComboMakerName.SelectedIndex = -1;
            TextboxKakaku.ReadOnly = true;
            TextboxStock.ReadOnly = true;
            ComboSyobunrui.SelectedIndex = -1;
            TextboxKataban.ReadOnly = true;
            TextboxColor.ReadOnly = true;
            LblHatubaiDate.Visible = true;
            TextboxHihyouji.Enabled = true;
            HatubaiDate.Visible = false;
            ComboMakerName.Enabled =false;
            ComboSyobunrui.Enabled= false;
            GetDataGridView();
        }
    }
}
