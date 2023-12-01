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
    public partial class F_出庫管理 : Form
    {
        readonly LoginData LoginData;
        private static List<M_Client> ClNameDsp;
        private static List<M_SalesOffice> SoNameDsp;
        readonly SyukkoDBConnection DB = new SyukkoDBConnection();
        readonly EmployeeDbConnection DB1 = new EmployeeDbConnection();
        readonly ClientDbConnection DB2 = new ClientDbConnection();
        readonly OrderDbConnection DB3 = new OrderDbConnection();
        public F_出庫管理(LoginData LData)
        {
            InitializeComponent();
            LoginData=LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流(LoginData);
            f_buturyuu.Show();
        }


        private void ButtonExe_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        //画面ロード時処理
        private void F_出庫管理_Load(object sender, EventArgs e)
        {
            TextboxHihyouji.Enabled = false;
            ButtonExe.Enabled = false;
            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("出庫情報を取得することができません。", "出庫確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //商品情報の全件取得
            List<DispSyukkoListDTO> tb = DB.SyukoGetData("");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            ClNameDsp = DB3.GetClientNameDspData();
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
        private void SetDataGridView(List<DispSyukkoListDTO> tb)
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
            //出庫ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 40;
            //顧客ID
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].Width = 40;
            //顧客名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].Width = 80;
            //営業所名
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].Width = 80;
            //社員ID
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].Width = 40;
            ////入社年月日
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].Width = 70;
            //社員名
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[6].Width = 80;

            dataGridView1.Refresh();
        }

        //データグリッドビューをクリックしたときの処理
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RadioKensaku.Checked == true)
            {
                TextboxSyukkoID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TextboxKokyakuID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                ComboKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                textBoxSyainID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                textBoxSyainName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            }
            else
            {
                TextboxSyukkoID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TextboxKokyakuID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                ComboKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                textBoxSyainID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                textBoxSyainName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonExe_Click_1(object sender, EventArgs e)
        {

        }
    }
}

