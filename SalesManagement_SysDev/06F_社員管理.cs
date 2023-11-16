using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_社員管理 : Form
    {
        public F_社員管理()
        {
            InitializeComponent();
        }

        private InputCheck ichk = new InputCheck();
        EmployeeDbConnection DB = new EmployeeDbConnection();
        private static List<M_SalesOffice> SoNameDsp;
        private static List<M_Position> PoNameDsp;

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_管理者 f_Admin = new F_管理者();
            f_Admin.Show();
        }

        private void F_社員管理_Load(object sender, EventArgs e)
        {
            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("商品情報を取得することができません。", "商品確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool GetDataGridView()
        {
            //在庫情報の全件取得
            List<DispEmployeeListDTO> tb = DB.EmployeeGetData("", 0);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        private void SetFormComboBox()
        {
            SoNameDsp = DB.GetSoNameDspData();
            ComboEigyousyoName.Items.AddRange(SoNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "SoName";
            ComboEigyousyoName.ValueMember = "SoID";
            ComboEigyousyoName.DataSource = SoNameDsp;

            PoNameDsp = DB.GetPoNameDspData();
            ComboYakusyokuName.Items.AddRange(PoNameDsp.ToArray());
            ComboYakusyokuName.DisplayMember = "PoName";
            ComboYakusyokuName.ValueMember = "PoID";
            ComboYakusyokuName.DataSource = PoNameDsp;

            //初期値を０に
            ComboEigyousyoName.SelectedIndex = 0;
            ComboYakusyokuName.SelectedIndex = 0;

            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboYakusyokuName.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void SetDataGridView(List<DispEmployeeListDTO> tb)
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
            if (RadioTouroku.Checked == true)
            {
                if (!GetVaildDataAtRegistration())
                {
                    return;
                }
                var regPro = GenerateDataAtRegistration();

                RegistrationProduct(regPro);
            }
        }

        private bool GetVaildDataAtRegistration() //入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxSyainName.Text.Trim()))
            {
                MessageBox.Show("社員名が入力されていません");
                TextboxSyainName.Focus();
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

                else
                {
                    MessageBox.Show("電話番号が入力されていません");
                    TextboxTelNo.Focus();
                    return false;
                }
            }
            return true;
        }

        private M_Employee GenerateDataAtRegistration() //登録データ生成
        {
            int SoID = ComboEigyousyoName.SelectedIndex;
            int PoID = ComboYakusyokuName.SelectedIndex;
            return new M_Employee
            {
                EmID = int.Parse(TextboxSyainID.Text.Trim()),
                EmName = TextboxSyainName.Text.Trim(),
                PoID = PoID,
                EmPhone = TextboxTelNo.Text.Trim(),
                SoID = SoID,
                EmFlag = 0,
                EmHidden = null,
            };

        }
    }
}
