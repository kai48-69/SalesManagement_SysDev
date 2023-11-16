using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_顧客管理 : Form
    {
        public F_顧客管理()
        {
            InitializeComponent();
        }

        ClientDataAccess ClientDataAccess = new ClientDataAccess();
        private InputCheck ichk = new InputCheck();
        ClientDbConnection DB = new ClientDbConnection();
        private static List<M_SalesOffice> SoNameDsp;

        //画面ロード時処理
        private void Form1_Load(object sender, EventArgs e)
        {
            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("顧客情報を取得することができません。", "顧客確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //在庫情報の全件取得
            List<DispClientListDTO> tb = DB.ClientGetData("", "", 0);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            SoNameDsp = DB.GetSoNameDspData();
            ComboEigyousyoName.Items.AddRange(SoNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "SoName";
            ComboEigyousyoName.ValueMember = "SoID";
            ComboEigyousyoName.DataSource = SoNameDsp;

            //初期値を０に
            ComboEigyousyoName.SelectedIndex = 0;


            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispClientListDTO> tb)
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
            ////非表示理由 
            dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[9].Width = 400;

            dataGridView1.Refresh();
        }




        private void ButtonExe_Click(object sender, EventArgs e)
        {
            //登録処理----------------------------------------------------------------------
            if (RadioTouroku.Checked == true)
            {
                if (!GetVaildDataAtRegistration())
                {
                    return;
                }
                var regCl = GenerateDataAtRegistration();

                RegistrationClient(regCl);
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
        }
        //登録処理--------------------------------------------------------------------------
        private bool GetVaildDataAtRegistration() //入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxKokyakuName.Text.Trim()))
            {
                MessageBox.Show("顧客名が入力されていません");
                TextboxKokyakuName.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxTelNo.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxTelNo.Text.Trim()))
                {
                    MessageBox.Show("電話番号は半角数字で入力してください");
                    TextboxTelNo.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません");
                TextboxTelNo.Focus();
                return false;
            }


            if (!String.IsNullOrEmpty(TextboxFAX.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxFAX.Text.Trim()))
                {
                    MessageBox.Show("FAXは半角数字で入力してください");
                    TextboxFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません");
                TextboxFAX.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxPostCD.Text.Trim()))
            {
                MessageBox.Show("郵便番号が入力されていません");
                TextboxPostCD.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(TextboxAdress.Text.Trim()))
            {
                MessageBox.Show("住所が入力されていません");
            }

            return true;
        }

        private M_Client GenerateDataAtRegistration() //登録データ生成
        {
            int SoID = ComboEigyousyoName.SelectedIndex;
            return new M_Client
            {
                ClID = int.Parse(TextboxKokyakuID.Text),
                SoID = SoID,
                ClName = TextboxKokyakuName.Text.Trim(),
                ClAddress = TextboxAdress.Text.Trim(),
                ClPhone = TextboxTelNo.Text.Trim(),
                ClPostal = TextboxPostCD.Text.Trim(),
                ClFAX = TextboxFAX.Text.Trim(),
                ClHidden = null,
            };
        }

        private void RegistrationClient(M_Client regCl) //データ登録処理
        {
            DialogResult result = MessageBox.Show("顧客データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = ClientDataAccess.AddClientData(regCl);
            if (flg == true)
            {
                MessageBox.Show("データを登録しました");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxKokyakuID.Focus();
            }
            ClearInput();
            GetDataGridView();
        }


        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxKokyakuID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxKokyakuID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDはすべて半角数字で入力してください。");
                    TextboxKokyakuID.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool GenerateDataAtSelect() //検索データ生成
        {
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
            //顧客ID
            var ClID = TextboxKokyakuID.Text.Trim();



            //変換処理
            int KokyakuID;
            if (!int.TryParse(ClID, out KokyakuID))
            {
                KokyakuID = -1;
            }

            M_Client selectCondition = new M_Client()
            {
                ClID = KokyakuID,
                SoID = SoID,
                ClAddress = TextboxAdress.Text.Trim(),

            };

            List<DispClientListDTO> tb = DB.GetClientData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }


        //更新処理-----------------------------------------------------------------------
        private bool GetVaildDataAtUpdate()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxKokyakuName.Text.Trim()))
            {
                MessageBox.Show("顧客名が入力されていません");
                TextboxKokyakuName.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxTelNo.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxTelNo.Text.Trim()))
                {
                    MessageBox.Show("電話番号は半角数字で入力してください");
                    TextboxTelNo.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("電話番号が入力されていません");
                TextboxTelNo.Focus();
                return false;
            }


            if (!String.IsNullOrEmpty(TextboxFAX.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxFAX.Text.Trim()))
                {
                    MessageBox.Show("FAXは半角数字で入力してください");
                    TextboxFAX.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("FAXが入力されていません");
                TextboxFAX.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxPostCD.Text.Trim()))
            {
                MessageBox.Show("郵便番号が入力されていません");
                TextboxPostCD.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(TextboxAdress.Text.Trim()))
            {
                MessageBox.Show("住所が入力されていません");
            }

            return true;
        }

        private M_Client GenereteDataAtUpdate() //更新データ生成
        {
            string ManuID = ComboMakerName.SelectedIndex.ToString();
            string PD = ComboSyobunrui.SelectedValue.ToString();
            return new M_Product
            {
                MaID = int.Parse(ManuID),
                PrID = int.Parse(TextboxSyouhinID.Text.Trim()),
                PrName = TextboxSyohinName.Text.Trim(),
                ScID = int.Parse(PD),
                PrModelNumber = TextboxKataban.Text.Trim(),
                PrSafetyStock = int.Parse(TextboxStock.Text.Trim()),
                Price = int.Parse((TextboxKakaku.Text.Trim())),
                PrColor = TextboxColor.Text.Trim(),
                PrReleaseDate = HatubaiDate.Value,
                PrFlag = 0,
                PrHidden = null,
            };
        }




        //入力クリア----------------------------------------------------------------------
        private void ClearInput()
        {

            if (RadioKensaku.Checked == true)//検索時はコンボボックスの値を空にする
            {
                ComboEigyousyoName.SelectedIndex = -1;
                TextboxKokyakuID.Text = "";
                TextboxKokyakuName.Text = "";
                TextboxTelNo.Text = "";
                TextboxFAX.Text = "";
                TextboxPostCD.Text = "";
                TextboxAdress.Text = "";
                TextboxHihyouji.Text = "";
            }
            else   //検索時以外は表示する
            {
                ComboEigyousyoName.SelectedIndex = 0;
                TextboxKokyakuID.Text = "";
                TextboxKokyakuName.Text = "";
                TextboxTelNo.Text = "";
                TextboxFAX.Text = "";
                TextboxPostCD.Text = "";
                TextboxAdress.Text = "";
                TextboxHihyouji.Text = ""; ;
            }
        }

        //戻るボタン
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }

        //入力リセット
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }

}
