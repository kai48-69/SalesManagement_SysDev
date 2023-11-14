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
    public partial class F_社員管理 : Form
    {
        public F_社員管理()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_管理者 f_Admin = new F_管理者();
            f_Admin.Show();
        }

        private void ButtonExe_Click(object sender, EventArgs e)
        {

        }

        private void F_社員管理_Load(object sender, EventArgs e)
        {

        }
    }
}
