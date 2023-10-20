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
    public partial class F_物流 : Form
    {
        public F_物流()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ログアウトします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                F_ログイン画面 f_login = new F_ログイン画面();
                f_login.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            F_発注管理　f_hattyu =new F_発注管理();
            f_hattyu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_入庫管理 f_nyuko = new F_入庫管理();
            f_nyuko.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_出庫管理 f_syukko = new F_出庫管理();
            f_syukko.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_商品管理 f_syouhin = new F_商品管理();
            f_syouhin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_在庫管理 f_zaiko = new F_在庫管理();
            f_zaiko.Show();
        }
    }
}
