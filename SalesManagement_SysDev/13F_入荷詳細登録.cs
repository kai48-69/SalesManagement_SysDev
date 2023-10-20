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
    public partial class F_入荷詳細登録 : Form
    {
        public F_入荷詳細登録()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            F_入荷管理 f_nyuka = new F_入荷管理();
            f_nyuka.Show();
        }
    }
}
