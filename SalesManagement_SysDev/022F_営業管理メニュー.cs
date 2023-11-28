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
        readonly LoginData LoginData;
        public F_営業(LoginData LData)
        {
            InitializeComponent();
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
            LoginData = LData;
            int PoID = LData.PoID;
            if (PoID == 1)
            {
                ButtonLogout.Text = "戻る";
            }
        }

        private void F_営業_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            if (ButtonLogout.Text == "戻る")
            {
                this.Close();
                F_管理者 f_Admin = new F_管理者(LoginData);
                f_Admin.Show();
                return;
            }
            DialogResult result= MessageBox.Show("ログアウトします。よろしいですか？","確認",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                F_ログイン画面 f_login=new F_ログイン画面();
                f_login.Show();
            }
        }

        private void ButtonJutyuu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_受注管理 f_jutyuu = new F_受注管理(LoginData);
            f_jutyuu.Show();
        }

        private void ButtonTyumon_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            F_注文管理 f_tyumon = new F_注文管理(LoginData);
            f_tyumon.Show();
        }

        private void ButtonKokyaku_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_顧客管理 f_kokyaku = new F_顧客管理(LoginData);
            f_kokyaku.Show();   
        }

        private void ButtonSyukka_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_出荷管理 f_syukka = new F_出荷管理(LoginData);
            f_syukka.Show();
        }

        private void ButtonNyuka_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_入荷管理 f_nyuka = new F_入荷管理(LoginData);
            f_nyuka.Show();
        }

        private void ButtonUriage_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_売上管理　f_uriage =new F_売上管理(LoginData);
            f_uriage.Show();
        }

        
    }
}
