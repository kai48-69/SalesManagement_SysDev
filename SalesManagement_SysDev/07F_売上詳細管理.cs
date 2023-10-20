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
    public partial class F_売上詳細管理 : Form
    {
        public F_売上詳細管理()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            F_売上管理　f_uriage =new F_売上管理();
            f_uriage.Show();
        }
    }
}
