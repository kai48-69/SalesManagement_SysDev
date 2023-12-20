using SalesManagement_SysDev.Employee;
using SalesManagement_SysDev.Order;
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
    public partial class F_発注管理 : Form
    {
        readonly HattyuDbConnection DB = new HattyuDbConnection();
        readonly MakerDbConnection DB1 = new MakerDbConnection();
        readonly EmployeeDbConnection DB2 = new EmployeeDbConnection();
        readonly WarehouseDbConnection DB3 = new WarehouseDbConnection();
        readonly private InputCheck ichk = new InputCheck();
        readonly private HattyuDataAccess HDA = new HattyuDataAccess();
        readonly private WarehouseDataAccess WDA = new WarehouseDataAccess();
        private static List<M_Maker> MNameDsp;
        readonly LoginData LoginData;
        public F_発注管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }
        //画面ロード時処理
        private void F_発注管理_Load(object sender, EventArgs e)
        {
            TextboxHattyuID.Enabled = false;
            ButtonKakutei.Enabled = false;
            TextboxHihyouji.Enabled = false;
            TextboxSyainID.Text=LoginData.EmID.ToString();
            TextboxSyainID.ReadOnly = true;
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
            List<DispHattyuListDTO> tb = DB.HattyuGetData("");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            MNameDsp = DB1.GetMaNameDspData();
            ComboMakerName.Items.AddRange(MNameDsp.ToArray());
            ComboMakerName.DisplayMember = "MaName";
            ComboMakerName.ValueMember = "MaID";
            ComboMakerName.DataSource = MNameDsp;


            //初期値を０に
            ComboMakerName.SelectedIndex = 0;

            //読み込み専用に
            ComboMakerName.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispHattyuListDTO> tb)
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
            //発注ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 40;
            ////発注詳細ID
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 50;
            //メーカー名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 80;
            //社員名
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 80;
            //商品名
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].Width = 80;
            //数量
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].Width = 120;
            //発注年月日
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 70;
            //発注年月日
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[7].Visible = false;


            dataGridView1.Refresh();
        }
        //データグリッドビューをクリックしたときの処理
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextboxHattyuID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            ComboMakerName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
           // TextboxSyainName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            TextboxSyainID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
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

                var regHa = GenerateDataAtRegistration();

                RegistrationHattyu(regHa);
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
            if (!CheckDataAtConfirm())
            {
                return;
            }

            ConfirmHa();
            var ConHa = GenereteDataAtUpdateFlg();
            UpdWaFlag(ConHa);
        }

        //登録処理--------------------------------------------------------------------------
        private bool GetVaildDataAtRegistration() //入力データチェック
        {
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

            if (String.IsNullOrEmpty(TextboxSyainName.Text))
            {
                MessageBox.Show("正しい社員ID を入力して下さい");
                return false;
            }
            return true;
        }

        private T_Hattyu GenerateDataAtRegistration() //登録データ生成
        {
            int MaID = ComboMakerName.SelectedIndex;

            return new T_Hattyu
            {
                MaID = MaID + 1,
                EmID = int.Parse(TextboxSyainID.Text.Trim()),
                HaDate = DateTime.Now,
                WaWarehouseFlag = 0,
                HaFlag = 0,
                HaHidden = null
            };
        }

        private void RegistrationHattyu(T_Hattyu regHa) //データ登録処理
        {
            DialogResult result = MessageBox.Show("発注データの登録を開始します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = HDA.AddOrderData(regHa);
            if (flg == true)
            {
                DialogResult result1 = MessageBox.Show("続けて商品の登録を行います");
                if (result1 == DialogResult.OK)
                {
                    this.Close();
                    _101F_発注詳細登録 f_HattyuSyousai = new _101F_発注詳細登録(LoginData);
                    f_HattyuSyousai.Show();

                }
            }
            else
            {
                MessageBox.Show("データの登録を開始できませんでした");
                TextboxSyainName.Focus();
            }
            ClearInput();
            GetDataGridView();
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxHattyuID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxHattyuID.Text.Trim()))
                {
                    MessageBox.Show("受注IDはすべて半角数字で入力してください。");
                    TextboxHattyuID.Focus();
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
            int MaID;
            if (ComboMakerName.SelectedIndex == -1)
            {
                MaID = -1;
            }
            else
            {
                MaID = int.Parse(ComboMakerName.SelectedValue.ToString());
            }

            //整数型(int)に変換する準備
            //発注ID
            var HaID = TextboxHattyuID.Text.Trim();
            //社員ID
            var EmID = TextboxSyainID.Text.Trim();

            //変換処理
            if (!int.TryParse(HaID, out int HattyuID))
            {
                HattyuID = -1;
            }

            if (!int.TryParse(EmID, out int SyainID))
            {
                SyainID = -1;
            }


            T_Hattyu selectCondition = new T_Hattyu()
            {
                HaID = HattyuID,
                EmID = SyainID,
                MaID = MaID,
            };

            List<DispHattyuListDTO> tb = DB.GetOrderData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }
        //非表示処理----------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxHattyuID.Text.Trim()))
            {
                MessageBox.Show("非表示にする受注データを選択してください", "エラー");
                return false;
            }


            if (String.IsNullOrEmpty(TextboxHihyouji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private T_Hattyu GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            return new T_Hattyu
            {
                HaID = int.Parse(TextboxHattyuID.Text),
                HaFlag = 2,
                HaHidden = TextboxHihyouji.Text,
            };
        }

        private void HideOr(T_Hattyu hidHa)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("受注データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = HDA.HideHattyuData(hidHa);
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
        private bool CheckDataAtConfirm()
        {
            if (String.IsNullOrEmpty(TextboxHattyuID.Text.Trim()))
            {
                MessageBox.Show("確定を行うデータが選択されていません");
                return false;
            }
            return true;
        }

        private void ConfirmHa()//注文テーブルにデータを登録する
        {
            DialogResult result = MessageBox.Show("発注情報を確定します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            T_Hattyu selectCondition = new T_Hattyu()
            {
                HaID = int.Parse(TextboxHattyuID.Text),
            };
            List<GetHattyuDataDTO> Data1 = DB.SetHattyuData(selectCondition);

            //形式変換(DispOrderListDTO→T_Chumon)
            T_Warehousing Warehouse = new T_Warehousing
            {
                HaID = int.Parse(Data1[0].HaID),
                WaDate = DateTime.Now,
                EmID=LoginData.EmID,
            };
            //登録処理
            bool flg1 = WDA.AddWarehouseData(Warehouse);
            //詳細確定------------------------------------------------------------------------
            //登録したChIDを取得
            int WaID = DB3.GetWaID();
            T_WarehousingDetail WarehouseDetail = new T_WarehousingDetail();
            for (int i = 0; i < Data1.Count; i++)
            {
                //各データをchumonDetailに代入
                WarehouseDetail.WaID = WaID;
                WarehouseDetail.PrID = int.Parse(Data1[i].PrID);
                WarehouseDetail.WaQuantity = int.Parse(Data1[i].HaQuantity);
                //chumonDetail登録
                WDA.AddChumonDetailData(WarehouseDetail);
            }
            MessageBox.Show("データを確定しました");
        }

        private T_Hattyu GenereteDataAtUpdateFlg()　//確定データ生成(フラグの更新データ生成)
        {
            return new T_Hattyu
            {
                HaID = int.Parse(TextboxHattyuID.Text),
                EmID = LoginData.EmID,
                HaDate = DateTime.Now,
                WaWarehouseFlag = 1,
            };
        }

        private void UpdWaFlag(T_Hattyu ConHa)　//フラグ更新処理
        {
            HDA.UpdWaFlg(ConHa);
            ClearInput();
            GetDataGridView();
        }

        //戻るボタン----------------------------------------------------------------------
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流(LoginData);
            f_buturyuu.Show();
        }

        //入力リセット--------------------------------------------------------------------
        private void ClearInput()
        {
            if (RadioTouroku.Checked == true)
            {
                TextboxSyainID.Text = LoginData.EmID.ToString() ;
                ComboMakerName.SelectedIndex = 0;
                TextboxHattyuID.Text = "※入力不要です";
            }
            else
            {
                TextboxSyainID.Text = "";
                TextboxSyainName.Text = "";
                ComboMakerName.SelectedIndex = -1;
                TextboxHattyuID.Text = "";
            }
        }

        //リセットボタン------------------------------------------------------------------
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        //社員名自動入力
        private void TextboxSyainID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextboxSyainID.Text.Trim(), out int EmID))
            {
                if (DB2.CheckCascadeEmployeesID(EmID) != -1)
                {
                    TextboxSyainName.Text = DB2.GetEmName(EmID);
                }
            }
            if (String.IsNullOrEmpty(TextboxSyainID.Text))
            {
                TextboxSyainName.Text = "";
            }
        }

        private void RadioTouroku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxHattyuID.Enabled = false;
            TextboxSyainID.ReadOnly = true;
            ComboMakerName.Enabled = true;
            TextboxHihyouji.Enabled = true;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;
          
        }

        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxHattyuID.Enabled = true;
            TextboxSyainID.ReadOnly = false;
            ComboMakerName.Enabled = true;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;
        }
        

        private void RadioHihyouji_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxHattyuID.Enabled = false;
            TextboxSyainID.ReadOnly = true;
            ComboMakerName.Enabled = false;
            TextboxHihyouji.Enabled = true;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;
        }

        private void RadioKakutei_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxHattyuID.Enabled = false;
            TextboxSyainID.ReadOnly = true;
            ComboMakerName.Enabled = false;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = true;
            ButtonExe.Visible = false;
        }

    }
}

