using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_出荷管理 : Form
    {

        readonly LoginData LoginData;
        private static List<M_SalesOffice> SoNameDsp;
        private static List<M_Client> ClNameDsp;
        readonly private InputCheck ichk = new InputCheck();
        readonly ShipDbConnection DB = new ShipDbConnection();
        readonly EmployeeDbConnection DB1 = new EmployeeDbConnection();
        readonly ShipDbConnection DB2 = new ShipDbConnection();
        readonly SaleDbConnection DB3 = new SaleDbConnection();
        readonly OrderDbConnection DB4 = new OrderDbConnection();
        readonly SaleDataAccess SDA = new SaleDataAccess();
        readonly ShipDataAccess ShDA=new ShipDataAccess();

        public F_出荷管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }

        private void F_出荷管理_Load(object sender, EventArgs e)
        {
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = false;

            SetFormComboBox();
            if (!GetDataGridView())
            {
                MessageBox.Show("商品情報を取得することができません。", "商品確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool GetDataGridView()
        {
            //商品情報の全件取得
            List<DispShipListDTO> tb = DB.ShipGetData();
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        private void SetDataGridView(List<DispShipListDTO> tb)
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


            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (RadioKensaku.Checked != true)
                {
                    TextboxSyukkaID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    ComboKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    TextboxOrderID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                }
            }
            catch
            {
                //何も処理を行わない
            }
        }

        private void SetFormComboBox()
        {
            ClNameDsp = DB4.GetClientNameDspData();
            ComboKokyakuName.Items.AddRange(ClNameDsp.ToArray());
            ComboKokyakuName.DisplayMember = "ClName";
            ComboKokyakuName.ValueMember = "ClID";
            ComboKokyakuName.DataSource = ClNameDsp;

            SoNameDsp = DB1.GetSoNameDspData();
            ComboEigyousyoName.Items.AddRange(SoNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "SoName";
            ComboEigyousyoName.ValueMember = "SoID";
            ComboEigyousyoName.DataSource = SoNameDsp;

            //初期値を-1に
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;

            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboKokyakuName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

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

                var hidSh = GenereteDataAtHidden();
                HideSh(hidSh);
            }
        }

        //確定ボタン
        private void ButtonKakutei_Click(object sender, EventArgs e)
        {
            if (!CheckDataAtConfirm())
            {
                return;
            }

            ConfirmSh();
            var ConSa = GenereteDataAtUpdateFlg();
            UpdShFlag(ConSa);
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxSyukkaID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyukkaID.Text.Trim()))
                {
                    MessageBox.Show("出荷IDはすべて半角数字で入力してください", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    TextboxSyukkaID.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool GenerateDataAtSelect() //検索データ生成
        {
            int SoID;
            int ClID;
           
            if (ComboEigyousyoName.SelectedIndex == -1)
            {
                SoID = -1;
            }
            else
            {
                SoID = int.Parse(ComboEigyousyoName.SelectedValue.ToString());
            }

            if (ComboKokyakuName.SelectedIndex == -1)
            {
               ClID = -1;
            }
            else
            {
                ClID = int.Parse(ComboKokyakuName.SelectedValue.ToString());
            }

            //整数型(int)に変換する準備
            var ShID = TextboxSyukkaID.Text;
            var OrID = TextboxOrderID.Text;
            //変換処理

            if (!int.TryParse(ShID, out int SyukkaID))
            {
                SyukkaID = -1;
            }

            if (!int.TryParse(OrID, out int JutyuID))
            {
                JutyuID = -1;
            }


            T_Shipment selectCondition = new T_Shipment()
            {
                ShID = SyukkaID,
                SoID = SoID,
                ClID = ClID,
                OrID= JutyuID,  
            };

            List<DispShipListDTO> tb = DB.GetShipData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //非表示処理----------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxSyukkaID.Text.Trim()))
            {
                MessageBox.Show("非表示にする受注データを選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(TextboxHihyouji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private T_Shipment GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            return new T_Shipment
            {
                ShID = int.Parse(TextboxSyukkaID.Text),

                ShFlag = 2,
                ShHidden = TextboxHihyouji.Text,
            };
        }

        private void HideSh(T_Shipment hidSh)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("受注データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = ShDA.HideShipData(hidSh);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSyukkaID.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //確定処理------------------------------------------------------------------------
        private bool CheckDataAtConfirm()
        {
            if (String.IsNullOrEmpty(TextboxSyukkaID.Text.Trim()))
            {
                MessageBox.Show("確定を行うデータが選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ConfirmSh()//注文テーブルにデータを登録する
        {
            DialogResult result = MessageBox.Show("出荷情報を確定します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            T_Shipment selectCondition = new T_Shipment ()
            {

                ShID = int.Parse(TextboxSyukkaID.Text),
            };
            List<GetSyukkaDataDTO> Data1 = DB2.SetSyukkaData(selectCondition);

            //形式変換(DispOrderListDTO→T_Chumon)
            T_Sale Sale = new T_Sale
            {
                OrID = Data1[0].OrID,
                SoID = Data1[0].SoID,
                ClID = Data1[0].ClID,
                EmID=LoginData.EmID,
                SaDate=DateTime.Now,
            };
            //登録処理
            SDA.AddSaleData(Sale);
            //詳細確定------------------------------------------------------------------------
            //登録したChIDを取得
            int SaID = DB3.GetSaID();
            T_SaleDetail SaleDetail = new T_SaleDetail();
            T_Stock Stock = new T_Stock();
            for (int i = 0; i < Data1.Count; i++)
            {
                //各データをchumonDetailに代入
                SaleDetail.SaID = SaID;
                SaleDetail.PrID = Data1[i].PrID;
                SaleDetail.SaQuantity = Data1[i].ShQuantity;
                //chumonDetail登録
                SDA.AddSaleDetailData(SaleDetail);
             
            }
            MessageBox.Show("データを確定しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private T_Shipment GenereteDataAtUpdateFlg()　//確定データ生成(フラグの更新データ生成)
        {
            return new T_Shipment
            {
                ShID = int.Parse(TextboxSyukkaID.Text),
                ShStateFlag = 1,
            };
        }
        private void UpdShFlag(T_Shipment ConSh)　//フラグ更新処理
        {
            ShDA.UpdShipFlg(ConSh);

            ClearInput();

            GetDataGridView();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業(LoginData);
            f_eigyou.Show();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            TextboxSyukkaID.Text = "";
            TextboxOrderID.Text = "";
            TextboxHihyouji.Text = "";
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
        }

        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyukkaID.Enabled = true;
            TextboxOrderID.Enabled = true;
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
            ComboEigyousyoName.Enabled = true;
            ComboKokyakuName.Enabled = true;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;
        }

        private void RadioHihyouji_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyukkaID.Enabled = false;
            TextboxOrderID.Enabled = false;
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
            ComboEigyousyoName.Enabled = false;
            ComboKokyakuName.Enabled = false;
            TextboxHihyouji.Enabled = true;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = false;
        }

        private void RadioKakutei_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyukkaID.Enabled = false;
            TextboxOrderID.Enabled = false;
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
            ComboEigyousyoName.Enabled = false;
            ComboKokyakuName.Enabled = false;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = true;
            ButtonExe.Visible = false;
        }
    }
}



