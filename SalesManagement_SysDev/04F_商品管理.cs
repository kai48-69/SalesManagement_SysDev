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
    public partial class F_商品管理 : Form
    {
        public F_商品管理()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流();
            f_buturyuu.Show();
        }

        private void 小分類管理へ_Click(object sender, EventArgs e)
        {
            this.Close();
            F_小分類管理 f_bunrui = new F_小分類管理();
            f_bunrui.Show();
        }
    }
}
