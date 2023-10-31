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
        public F_売上管理()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }

    }
}
