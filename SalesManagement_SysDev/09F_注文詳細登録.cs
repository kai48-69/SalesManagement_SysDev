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
    public partial class F_注文詳細登録 : Form
    {
        public F_注文詳細登録()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();   
            F_注文管理　f_tyumon =new F_注文管理();
            f_tyumon.Show();
        }
    }
}
