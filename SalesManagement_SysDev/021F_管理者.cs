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
    public partial class F_管理者 : Form
    {
        readonly LoginData LoginData;

        public F_管理者(LoginData LData)
        {
            InitializeComponent();
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text=LData.LoginDatetime.ToString();
            LoginData=LData;    
        }

        public void F_管理者_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void ButtonEigyou_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業(LoginData);
            f_eigyou.Show();
        }

        private void ButtonLogis_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流(LoginData);
            f_buturyuu.Show();
        }


        private void ButtonSyain_Click(object sender, EventArgs e)
        {
            this.Close();
            F_社員管理 f_SyainKanri = new F_社員管理(LoginData);
            f_SyainKanri.Show();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ログアウトします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                F_ログイン画面 f_login = new F_ログイン画面();
                f_login.Show();
            }

        }

        
    }
}
