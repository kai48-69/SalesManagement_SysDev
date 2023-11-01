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
    public partial class F_出荷管理 : Form
    {
        public F_出荷管理()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExe_Click(object sender, EventArgs e)
        {

        }

        private void ButtonKakutei_Click(object sender, EventArgs e)
        {

        }

        private void F_出荷管理_Load(object sender, EventArgs e)
        {

        }
    }
}
