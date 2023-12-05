using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_注文管理 : Form
    {
        readonly LoginData LoginData;
        public F_注文管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }

        //画面ロード時処理
        private void F_受注管理_Load(object sender, EventArgs e)
        {
            TextboxHihyouji.Enabled = false;
            TextBoxTyuumonID.ReadOnly = true;
            TextBoxJyutyuID.ReadOnly = true;
            TextBoxKokyakuID.ReadOnly = true;
            ButtonKakutei.Enabled = false;
            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("商品情報を取得することができません。", "商品確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("注文情報を取得することができません。", "注文確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //商品情報の全件取得
            //注文情報の全件取得
            List<DispChumonDataListDTO> tb = DB2.ChumonGetData("");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }     

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispChumonDataListDTO> tb)
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
            //受注ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 40;
            ////受注詳細ID
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 50;
            //営業所名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 80;
            //社員名
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 80;
            //顧客名
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].Width = 80;
            //顧客担当者名
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].Width = 120;
            //商品名
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 70;
            //数量
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].Width = 70;
            //合計金額
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].Width = 80;
            //受注年月日
            dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].Width = 90;

            dataGridView1.Refresh();
        }

     
        //実行ボタン
        private void ButtonExe_Click(object sender, EventArgs e)
        {
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
            //非表示処理--------------------------------------------------------------------
            if (RadioHihyouji.Checked == true)
            {
                if (!GetVaildDataAtHide())
                {
                    return;
                }

                var hidOr = GenereteDataAtHidden();

                HideOr(hidOr);
            }
        }

        //確定ボタン----------------------------------------------------------------------
        private void ButtonKakutei_Click(object sender, EventArgs e)
        {
            if (!CheckDataAtConfirm())
            {
                return;
            }

            ConfirmOr();
            var ConOr = GenereteDataAtUpdateFlg();
            UpdOrFlag(ConOr);
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextBoxTyuumonID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextBoxTyuumonID.Text.Trim()))
                {
                    MessageBox.Show("注文IDはすべて半角数字で入力してください。");
                    TextBoxTyuumonID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(ComboEigyousyoName.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextBoxTyuumonID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは半角数字で入力してください");
                    TextBoxTyuumonID.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool GenerateDataAtSelect() //検索データ生成
        {
            int ClID;
            if (ComboKokyakuName.SelectedIndex == -1)
            {
                ClID = -1;
            }
            else
            {
                ClID = int.Parse(ComboKokyakuName.SelectedValue.ToString());
            }
            int SoID;
            if (ComboEigyousyoName.SelectedIndex == -1)
            {
                SoID = -1;
            }
            else
            {
                SoID = int.Parse(ComboEigyousyoName.SelectedValue.ToString());
            }
            //整数型(int)に変換する準備
            //商品ID
            var OrID = TextBoxTyuumonID.Text.Trim();
            //価格
            var EmID = TextBoxTyuumonID.Text.Trim();

            //変換処理
            if (!int.TryParse(OrID, out int JutyuID))
            {
                JutyuID = -1;
            }

            if (!int.TryParse(EmID, out int SyainID))
            {
                SyainID = -1;
            }


            T_Order selectCondition = new T_Order()
            {
                OrID = JutyuID,
                SoID = SoID,
                ClID = ClID,
                EmID = SyainID,
                ClCharge = TextBoxEigyousyoName.Text.Trim(),
            };

            List<DispOrderListDTO> tb = DB.GetOrderData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //非表示処理----------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextBoxTyuumonID.Text.Trim()))
            {
                MessageBox.Show("非表示にする受注データを選択してください", "エラー");
                return false;
            }

            if (ODA.CheckCascadeOrderID(int.Parse(TextBoxTyuumonID.Text.Trim())))
            {
                MessageBox.Show("選択された受注内容は他で使用されているため非表示にできません。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(TextboxHihyouji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private T_Order GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            return new T_Order
            {
                OrID = int.Parse(TextBoxTyuumonID.Text),
                OrFlag = 2,
                OrHidden = TextboxHihyouji.Text,
            };
        }

        private void HideOr(T_Order hidOr)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("注文データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = ODA.HideOrderData(hidOr);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboKokyakuName.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //確定処理------------------------------------------------------------------------
        private bool CheckDataAtConfirm()
        {
            if (String.IsNullOrEmpty(TextBoxTyuumonID.Text.Trim()))
            {
                MessageBox.Show("確定を行うデータが選択されていません");
                return false;
            }
            return true;
        }

        private void ConfirmOr()//注文テーブルにデータを登録する
        {
            DialogResult result = MessageBox.Show("受注情報を確定します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(TextBoxTyuumonID.Text),
            };
            List<GetOrderDataDTO> Data1 = DB.SetOrderData(selectCondition);

            //形式変換(DispOrderListDTO→T_Chumon)
            T_Chumon chumon = new T_Chumon
            {
                OrID = int.Parse(Data1[0].OrID),
                SoID = int.Parse(Data1[0].SoID),
                EmID = int.Parse(Data1[0].EmID),
                ClID = int.Parse(Data1[0].ClID)
            };
            //登録処理
            bool flg1 = CDA.AddChumonData(chumon);
            //詳細確定------------------------------------------------------------------------
            //登録したChIDを取得
            int chID = DB2.GetChID();
            T_ChumonDetail ChumonDetail = new T_ChumonDetail();
            for (int i = 0; i < Data1.Count; i++)
            {

                //各データをchumonDetailに代入
                ChumonDetail.ChID = chID;
                ChumonDetail.PrID = int.Parse(Data1[i].PrID);
                ChumonDetail.ChQuantity = int.Parse(Data1[i].PrQuantity);
                //chumonDetail登録
                CDA.AddChumonDetailData(ChumonDetail);
            }
            bool flg2 = true;


            if (flg1 == true && flg2 == true)
            {
                DialogResult result1 = MessageBox.Show("データを確定しました");
                if (result1 == DialogResult.OK)
                {
                    //this.Close();
                    //F_受注詳細登録 f_JutyuSyousai = new F_受注詳細登録();
                    //f_JutyuSyousai.Show();

                }
            }
            //else
            //{
            //    MessageBox.Show("データの確定に失敗しました");
            //    TextboxSyainName.Focus();
            //}
        }

        private T_Order GenereteDataAtUpdateFlg()　//確定データ生成(フラグの更新データ生成)
        {
            return new T_Order
            {
                OrID = int.Parse(TextBoxTyuumonID.Text),
                OrStateFlag = 1,
            };
        }

        private void UpdOrFlag(T_Order ConOr)　//フラグ更新処理
        {
            ODA.UpdOrderFlg(ConOr);

            ClearInput();

            GetDataGridView();
        }

        //戻るボタン----------------------------------------------------------------------
        private void ButtonBack(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業(LoginData);
            f_eigyou.Show();
        }

        //入力リセット--------------------------------------------------------------------
        private void ClearInput()
        {
            if (RadioKensaku.Checked == true)   //検索時、非表示時はコンボボックスの値を空にする
            {
                TextBoxTyuumonID.Text = "";
                TextBoxJyutyuID.Text = "";
                TyuumonDate.Text = "";
                ComboEigyousyoName.Text = "";
                TextBoxKokyakuID.Text = "";
                ComboKokyakuName.Text = "";
            }
        }





















        {
            if (RadioKensaku.Checked == true)   //検索時、非表示時はコンボボックスの値を空にする
            {
                TextBoxTyuumonID.Text = "";
                TextBoxJyutyuID.Text = "";
                TyuumonDate.Text = "";
                ComboEigyousyoName.Text = "";
                TextBoxKokyakuID.Text = "";
                ComboKokyakuName.Text = "";
            }
        }





















        {
            if (RadioKensaku.Checked == true)   //検索時、非表示時はコンボボックスの値を空にする
            {
                TextBoxTyuumonID.Text = "";
                TextBoxJyutyuID.Text = "";
                TyuumonDate.Text = "";
                ComboEigyousyoName.Text = "";
                TextBoxKokyakuID.Text = "";
                ComboKokyakuName.Text = "";
            }
        }





















        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業(LoginData);
            f_eigyou.Show();
        }


        private void ButtonExe_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
