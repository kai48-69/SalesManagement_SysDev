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
    public partial class F_売上管理 : Form
    {
        readonly LoginData LoginData;
        private static List<M_Client> ClNameDsp;
        private static List<M_Product> PrNameDsp;
        readonly SaleDbConnection DB = new SaleDbConnection();
        readonly ClientDbConnection DB1 = new ClientDbConnection();
        readonly OrderDbConnection DB2 = new OrderDbConnection();
        readonly EmployeeDbConnection DB3 = new EmployeeDbConnection();
        readonly ProductDbConnection DB4=new ProductDbConnection();
        readonly SaleDataAccess SDA = new SaleDataAccess();
        private static List<M_SalesOffice> SoNameDsp;
        readonly private InputCheck ichk = new InputCheck();

        public F_売上管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }

        //画面ロード時処理
        private void F_売上管理_Load(object sender, EventArgs e)
        {
            TextboxHihyouji.Enabled = false;
            TextboxUriageID.ReadOnly = true;
            TextboxJuchuID.ReadOnly = true;
            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("売上情報を取得することができません。", "商品確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //商品情報の全件取得
            List<DispSaleListDTO> tb = DB.SaleGetData("");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            ClNameDsp = DB2.GetClientNameDspData();
            ComboKokyakuName.Items.AddRange(ClNameDsp.ToArray());
            ComboKokyakuName.DisplayMember = "ClName";
            ComboKokyakuName.ValueMember = "ClID";
            ComboKokyakuName.DataSource = ClNameDsp;

            SoNameDsp = DB3.GetSoNameDspData();
            ComboEigyousyoName.Items.AddRange(SoNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "SoName";
            ComboEigyousyoName.ValueMember = "SoID";
            ComboEigyousyoName.DataSource = SoNameDsp;

            PrNameDsp = DB4.GetPrNameDspData();
            ComboSyohinName.Items.AddRange(PrNameDsp.ToArray());
            ComboSyohinName.DisplayMember = "PrName";
            ComboSyohinName.ValueMember = "PrID";
            ComboSyohinName.DataSource = PrNameDsp;

            //初期値を０に
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
            ComboSyohinName.SelectedIndex = -1; 

            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboKokyakuName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSyohinName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispSaleListDTO> tb)
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

            dataGridView1.Refresh();
        }

        //データグリッドビューをクリックしたときの処理
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (RadioKensaku.Checked != true)
                {
                    TextboxUriageID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    TextboxSyainID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    ComboKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                    TextboxTantousyaName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                }
            }
            catch
            {
                //何も処理を行わない
            }
           
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

                var hidSa = GenereteDataAtHidden();

                HideSa(hidSa);
            }
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxUriageID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxUriageID.Text.Trim()))
                {
                    MessageBox.Show("売上IDはすべて半角数字で入力してください。");
                    TextboxUriageID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxJuchuID.Text.Trim()))
            {

                if (!ichk.IntegerCheck(TextboxJuchuID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは半角数字で入力してください");
                    TextboxJuchuID.Focus();
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
            int PrID;
            if (ComboSyohinName.SelectedIndex == -1)
            {
                PrID = -1;
            }
            else
            {
                PrID = int.Parse(ComboKokyakuName.SelectedValue.ToString());
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

            int ClID;
            if (ComboSyohinName.SelectedIndex == -1)
            {
                ClID = -1;
            }
            else
            {
                ClID = int.Parse(ComboKokyakuName.SelectedValue.ToString());
            }

            //整数型(int)に変換する準備
            //売上ID
            var SaID = TextboxUriageID.Text.Trim();
            //受注ID
            var OrID = TextboxJuchuID.Text.Trim();
            //社員ID
            var EmID = TextboxSyainID.Text.Trim();

            //変換処理
            if (!int.TryParse(SaID, out int UriageID))
            {
                UriageID = -1;
            }

            if (!int.TryParse(OrID, out int JutyuID))
            {
                JutyuID = -1;
            }

            if (!int.TryParse(EmID, out int SyainID))
            {
                SyainID = -1;
            }


            SaleselectCondition selectCondition = new SaleselectCondition()
            {
                SaID = UriageID,
                OrID = JutyuID,
                SoID = SoID,
                EmID = SyainID,
                ClID = ClID,
                PrID = PrID,
               
            };

            List<DispSaleListDTO> tb =DB.GetSaleData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //非表示処理----------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxUriageID.Text.Trim()))
            {
                MessageBox.Show("非表示にする売上データを選択してください", "エラー");
                return false;
            }


            if (String.IsNullOrEmpty(TextboxHihyouji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private T_Sale GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            return new T_Sale
            {
                SaID = int.Parse(TextboxUriageID.Text),
                SaFlag = 2,
                SaHidden = TextboxHihyouji.Text,
            };
        }

        private void HideSa(T_Sale hidSa)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("売上データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }


            bool flg = SDA.HideSaleData(hidSa);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxUriageID.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //戻るボタン----------------------------------------------------------------------
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業(LoginData);
            f_eigyou.Show();
        }

        //入力リセット--------------------------------------------------------------------
        private void ClearInput()
        {
            //検索時、非表示時はコンボボックスの値を空にする
            {
                TextboxUriageID.Text = "";
                ComboEigyousyoName.SelectedIndex = -1;
                ComboKokyakuName.SelectedIndex = -1;
                TextboxTantousyaName.Text = "";
                TextboxSyainID.Text = "";
            }

        }

        //リセットボタン------------------------------------------------------------------
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            //検索時、非表示時はコンボボックスの値を空にする
            {
                ClearInput();
            }

        }

        //検索時の入力項目選択-----------------------------------------------------------
        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxUriageID.ReadOnly = false;
            ComboKokyakuName.SelectedIndex = -1;
            TextboxTantousyaName.ReadOnly = false;
            ComboEigyousyoName.SelectedIndex = -1;
            TextboxSyainID.Visible = true;
            LblUriageID.Visible = true;
            TextboxHihyouji.Enabled = false;
            ButtonExe.Visible = true;
            ComboEigyousyoName.Enabled = true;
            ComboKokyakuName.Enabled = true;
            GetDataGridView();
        }

        //非表示時の入力項目選択---------------------------------------------------------
        private void RadioHihyouji_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxUriageID.ReadOnly = true;
            ComboKokyakuName.SelectedIndex = -1;
            TextboxTantousyaName.ReadOnly = true;
            ComboEigyousyoName.SelectedIndex = -1;
            TextboxSyainID.Visible = false;
            LblUriageID.Visible = false;
            TextboxHihyouji.Enabled = true;
            ButtonExe.Visible = true;
            ComboEigyousyoName.Enabled = true;
            ComboKokyakuName.Enabled = true;
            GetDataGridView();
        }


    }
}
