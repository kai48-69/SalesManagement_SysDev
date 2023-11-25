using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesManagement_SysDev
{
    public partial class F_受注管理 : Form
    {
        readonly OrderDbConnection DB = new OrderDbConnection();
        readonly EmployeeDbConnection DB1 = new EmployeeDbConnection();
        readonly ChumonDbConnection DB2 = new ChumonDbConnection();
        readonly OrderDataAccess ODA = new OrderDataAccess();
        readonly ChumonDataAccess CDA = new ChumonDataAccess();
        private static List<M_Client> ClNameDsp;
        private static List<M_SalesOffice> SoNameDsp;
        readonly private InputCheck ichk = new InputCheck();

        public F_受注管理()
        {
            InitializeComponent();
        }

        //画面ロード時処理
        private void F_受注管理_Load(object sender, EventArgs e)
        {
            TextboxHihyouji.Enabled = false;
            TextboxJutyuID.ReadOnly = true;
            TextboxSyainName.ReadOnly = true;
            ButtonKakutei.Enabled = false;
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
            List<DispOrderListDTO> tb = DB.OrderGetData("");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            ClNameDsp = DB.GetClientNameDspData();
            ComboKokyakuName.Items.AddRange(ClNameDsp.ToArray());
            ComboKokyakuName.DisplayMember = "ClName";
            ComboKokyakuName.ValueMember = "ClID";
            ComboKokyakuName.DataSource = ClNameDsp;

            SoNameDsp = DB1.GetSoNameDspData();
            ComboEigyousyoName.Items.AddRange(SoNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "SoName";
            ComboEigyousyoName.ValueMember = "SoID";
            ComboEigyousyoName.DataSource = SoNameDsp;

            //初期値を０に
            ComboEigyousyoName.SelectedIndex = 0;
            ComboKokyakuName.SelectedIndex = 0;

            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboKokyakuName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispOrderListDTO> tb)
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
            dataGridView1.Columns[9].Width = 80;
            ////非表示理由 
            dataGridView1.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[10].Width = 400;

            dataGridView1.Refresh();
        }

        //データグリッドビューをクリックしたときの処理
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RadioTouroku.Checked == true)
            {

                ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TextboxSyainName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                ComboKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                TextboxTantousyaName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            }
            else if (RadioKensaku.Checked == true)
            {

            }
            else
            {
                TextboxJutyuID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TextboxSyainName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                ComboKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                TextboxTantousyaName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
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

                var regOr = GenerateDataAtRegistration();

                RegistrationOrder(regOr);
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
            ConfirmOr();
            var ConOr = GenereteDataAtUpdateFlg();
            UpdOrFlag(ConOr);
        }

        //登録処理--------------------------------------------------------------------------
        private bool GetVaildDataAtRegistration() //入力データチェック
        {

            if (String.IsNullOrEmpty(TextboxTantousyaName.Text.Trim()))
            {
                MessageBox.Show("顧客担当者名が入力されていません");
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxSyainID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyainID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは半角数字で入力してください");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("社員IDが入力されていません");
                return false;
            }

            return true;
        }

        private T_Order GenerateDataAtRegistration() //登録データ生成
        {
            int ClID = ComboKokyakuName.SelectedIndex;
            int SoID = ComboEigyousyoName.SelectedIndex;
            return new T_Order
            {
                SoID = SoID + 1,
                EmID = int.Parse(TextboxSyainID.Text.Trim()),
                ClID = ClID + 1,
                ClCharge = TextboxTantousyaName.Text.Trim(),
                OrDate = DateTime.Now,
                OrFlag = 0,
                OrStateFlag = 0,
                OrHidden = null
            };
        }

        private void RegistrationOrder(T_Order regOr) //データ登録処理
        {
            DialogResult result = MessageBox.Show("受注データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = ODA.AddOrderData(regOr);
            if (flg == true)
            {
                DialogResult result1 = MessageBox.Show("データを登録しました");
                if (result1 == DialogResult.OK)
                {
                    this.Close();
                    F_受注詳細登録 f_JutyuSyousai = new F_受注詳細登録();
                    f_JutyuSyousai.Show();

                }
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxSyainName.Focus();
            }
            ClearInput();
            GetDataGridView();
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxJutyuID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxJutyuID.Text.Trim()))
                {
                    MessageBox.Show("受注IDはすべて半角数字で入力してください。");
                    TextboxJutyuID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxSyainID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyainID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは半角数字で入力してください");
                    TextboxSyainID.Focus();
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
            var OrID = TextboxJutyuID.Text.Trim();
            //価格
            var EmID = TextboxSyainID.Text.Trim();

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
                ClCharge = TextboxTantousyaName.Text.Trim(),
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
            if (String.IsNullOrEmpty(TextboxJutyuID.Text.Trim()))
            {
                MessageBox.Show("非表示にする受注データを選択してください", "エラー");
                return false;
            }

            if (ODA.CheckCascadeOrderID(int.Parse(TextboxJutyuID.Text.Trim())))
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
                OrID = int.Parse(TextboxJutyuID.Text),
                OrFlag = 2,
                OrHidden = TextboxHihyouji.Text,
            };
        }

        private void HideOr(T_Order hidOr)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("受注データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
                TextboxSyainName.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //確定処理------------------------------------------------------------------------
        private void ConfirmOr()//注文テーブルにデータを登録する
        {
            DialogResult result = MessageBox.Show("受注情報を確定します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            T_Order selectCondition = new T_Order()
            {
                OrID = int.Parse(TextboxJutyuID.Text),
            };
            List<GetOrderDataDTO> Data1 = DB.SetOrderData(selectCondition);

            //形式変換(DispOrderListDTO→T_Chumon)
            T_Chumon chumon = new T_Chumon();
            chumon.OrID = int.Parse(Data1[0].OrID);
            chumon.SoID = int.Parse(Data1[0].SoID);
            chumon.EmID = int.Parse(Data1[0].EmID);
            chumon.ClID = int.Parse(Data1[0].ClID);
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

        private T_Order GenereteDataAtUpdateFlg()　//非表示データ生成(フラグの更新データ生成)
        {
            return new T_Order
            {
                OrID = int.Parse(TextboxJutyuID.Text),
                OrStateFlag = 1,
            };
        }

        private void UpdOrFlag(T_Order ConOr)　//データ更新処理
        {
            ODA.UpdOrderFlg(ConOr);
          
            ClearInput();

            GetDataGridView();
        }


        //戻るボタン----------------------------------------------------------------------
        private void ButtonBack(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }

        //入力リセット--------------------------------------------------------------------
        private void ClearInput()
        {
            if (RadioTouroku.Checked == true)//登録時はコンボボックスに値を表示する
            {
                TextboxJutyuID.Text = "";
                ComboEigyousyoName.SelectedIndex = 0;
                ComboKokyakuName.SelectedIndex = 0;
                TextboxTantousyaName.Text = "";
                TextboxSyainID.Text = "";
                TextboxSyainName.Text = "";

            }
            else   //検索時、非表示時はコンボボックスの値を空にする
            {
                TextboxJutyuID.Text = "";
                ComboEigyousyoName.SelectedIndex = -1;
                ComboKokyakuName.SelectedIndex = -1;
                TextboxTantousyaName.Text = "";
                TextboxSyainID.Text = "";
                TextboxSyainName.Text = "";
            }
        }

        //リセットボタン------------------------------------------------------------------
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }


        //登録時の入力項目選択-----------------------------------------------------------
        private void RadioTouroku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxJutyuID.ReadOnly = true;
            ComboKokyakuName.SelectedIndex = 0;
            TextboxTantousyaName.ReadOnly = false;
            ComboEigyousyoName.SelectedIndex = 0;
            TextboxSyainID.Visible = true;
            LblSyainID.Visible = true;
            TextboxSyainName.ReadOnly = true;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;
        }

        //検索時の入力項目選択-----------------------------------------------------------
        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxJutyuID.ReadOnly = false;
            ComboKokyakuName.SelectedIndex = -1;
            TextboxTantousyaName.ReadOnly = false;
            ComboEigyousyoName.SelectedIndex = -1;
            TextboxSyainID.Visible =true;
            LblSyainID.Visible = true;
            TextboxSyainName.ReadOnly = true;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;
        }

        //非表示時の入力項目選択---------------------------------------------------------
        private void RadioHihyouji_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxJutyuID.ReadOnly = true;
            ComboKokyakuName.SelectedIndex = -1;
            TextboxTantousyaName.ReadOnly = true;
            ComboEigyousyoName.SelectedIndex = -1;
            TextboxSyainID.Visible = false;
            LblSyainID.Visible=false;
            TextboxSyainName.ReadOnly = true;
            TextboxHihyouji.Enabled = true;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;
        }

        //確定時の入力項目選択
        private void RadioKakutei_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxJutyuID.ReadOnly = true;
            ComboKokyakuName.SelectedIndex = -1;
            TextboxTantousyaName.ReadOnly = true;
            ComboEigyousyoName.SelectedIndex = -1;
            TextboxSyainID.Visible = false;
            LblSyainID.Visible = false;
            TextboxSyainName.ReadOnly = true;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = true;
            ButtonExe.Visible = false;
        }

        private void TextboxSyainID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextboxSyainID.Text.Trim(),out int EmID))
            {
                if (DB1.CheckCascadeEmployeesID(EmID) != -1)
                {
                    TextboxSyainName.Text = DB1.GetEmName(EmID);
                }
            }
            if (String.IsNullOrEmpty(TextboxSyainID.Text))
            {
                TextboxSyainName.Text = "";
            }
        }
    }
}
