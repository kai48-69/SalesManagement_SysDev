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
        public F_受注管理()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void F_受注管理_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業　f_eigyou=new F_営業();
            f_eigyou.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            F_受注詳細登録 f_syousai = new F_受注詳細登録();
            f_syousai.Show();
        }
    }
}
