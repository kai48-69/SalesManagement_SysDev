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
            List<DispProductListDTO> tb = DB.ProductGetData("", "", 0);
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

        private void ButtonExe_Click(object sender, EventArgs e)
        {

        }
    }
}
