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
    public partial class F_営業 : Form
    {
        public F_営業()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("ログアウトします。よろしいですか？","確認",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                F_ログイン画面 f_login=new F_ログイン画面();
                f_login.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_受注管理 f_jutyuu = new F_受注管理();
            f_jutyuu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            F_注文管理 f_tyumon = new F_注文管理();
            f_tyumon.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_顧客管理 f_kokyaku = new F_顧客管理();
            f_kokyaku.Show();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_出荷管理 f_syukka = new F_出荷管理();
            f_syukka.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_入荷管理 f_nyuka = new F_入荷管理();
            f_nyuka.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_売上管理　f_uriage =new F_売上管理();
            f_uriage.Show();
        }
    }
}
