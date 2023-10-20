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
    public partial class F_管理者 : Form
    {
        public F_管理者()
        {
            InitializeComponent();
        }

        private void ButtonEigyou_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }

        private void ButtonLogis_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流();
            f_buturyuu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSyain_Click(object sender, EventArgs e)
        {
            this.Close();
            F_社員管理 f_SyainKanri = new F_社員管理();
            f_SyainKanri.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {

        }

       
    }
}
