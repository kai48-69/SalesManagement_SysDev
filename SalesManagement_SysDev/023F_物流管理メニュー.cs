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
        readonly LoginData LoginData;
        public F_物流(LoginData LData)
        {
            InitializeComponent();
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
            LoginData = LData;
             int PoID=LData.PoID;
            if (PoID == 1 ) 
            {
                ButtonLogout.Text = "戻る";
            }
        }

        private void F_物流_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            if (ButtonLogout.Text=="戻る")
            {
                this .Close();
                F_管理者 f_Admin = new F_管理者(LoginData);
                f_Admin.Show();
                return;
            }
            DialogResult result = MessageBox.Show("ログアウトします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                F_ログイン画面 f_login = new F_ログイン画面();
                f_login.Show();
            }
        }

        private void ButtonHattyu_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            F_発注管理　f_hattyu =new F_発注管理(LoginData);
            f_hattyu.Show();
        }

        private void ButtonNyuko_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_入庫管理 f_nyuko = new F_入庫管理(LoginData);
            f_nyuko.Show();
        }

        private void ButtonSyukko_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_出庫管理 f_syukko = new F_出庫管理(LoginData);
            f_syukko.Show();
        }

        private void ButtonSyouhin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_商品管理 f_syouhin = new F_商品管理(LoginData);
            f_syouhin.Show();
        }

        private void ButtonZaiko_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_在庫管理 f_zaiko = new F_在庫管理(LoginData);
            f_zaiko.Show();
        }

       
    }
}
