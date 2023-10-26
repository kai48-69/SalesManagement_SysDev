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
    public partial class F_出庫詳細管理 : Form
    {
        public F_出庫詳細管理()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_出庫管理 f_syukko =new F_出庫管理();
            f_syukko.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
