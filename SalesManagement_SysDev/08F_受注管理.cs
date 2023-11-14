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
    public partial class F_受注管理 : Form
    {
        OrderDbConnection DB = new OrderDbConnection();
        private static List<M_Client> ClNameDsp;

        public F_受注管理()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void F_受注管理_Load(object sender, EventArgs e)
        {
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
            List<DispProductListDTO> tb = DB.ProductGetData("", "", 0);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        private void SetFormComboBox()
        {
            ClNameDsp = DB.GetClientNameDspData();
            ComboKokyakuName.Items.AddRange(ClNameDsp.ToArray());
            ComboKokyakuName.DisplayMember = "MaName";
            ComboKokyakuName.ValueMember = "MaID";
            ComboKokyakuName.DataSource = ClNameDsp;
        }

        private void ButtonBack(object sender, EventArgs e)
        {
            this.Close();
            F_営業　f_eigyou=new F_営業();
            f_eigyou.Show();
        }

        private void ButtonExe_Click(object sender, EventArgs e)
        {

        }
    }
}
