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
    public partial class F_PW新規登録 : Form
    {
        public F_PW新規登録()
        {
            InitializeComponent();
        }
        private void F_PW新規登録_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void ButtonRegis_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_ログイン画面 f_login = new F_ログイン画面();
            f_login.Show();
        }
    }
}
