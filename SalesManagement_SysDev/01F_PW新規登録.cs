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
        readonly InputCheck ichk = new InputCheck();
        EmployeeDataAccess EmployeeDataAccess = new EmployeeDataAccess();
        readonly LoginData LoginData;

        public F_PW新規登録(LoginData LData)
        {
            InitializeComponent();
            this.TextboxSyainID.Text = LData.EmID.ToString();
            LoginData = LData;
        }
        private void F_PW新規登録_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void ButtonRegis_Click(object sender, EventArgs e)
        {
            if (!GetVaildDataAtRegPW())
            {
                return;
            }

            var RegPW = GenereteDataAtRegPW();

            RegistrationPW(RegPW);

            FormShow();
        }

        private bool GetVaildDataAtRegPW()//入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxPW.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxPW.Text))
                {
                    MessageBox.Show("新パスワードは半角数字で入力してください");
                    TextboxPW.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("新パスワードを入力してください");
                TextboxPW.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(TextboxConPW.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxConPW.Text))
                {
                    MessageBox.Show("新パスワード(確認)は半角数字で入力してください");
                    TextboxPW.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("新パスワード(確認)を入力してください");
                TextboxPW.Focus();
                return false;
            }
            if (TextboxPW.Text != TextboxConPW.Text)
            {
                MessageBox.Show("入力されたパスワードが一致していません。\n再度入力してください。");
                TextboxPW.Focus();
                return false;
            }
            return true;
        }

        private M_Employee GenereteDataAtRegPW()　//更新データ生成
        {
            return new M_Employee
            {
                EmID = int.Parse(TextboxSyainID.Text.Trim()),
                EmPassword = TextboxPW.Text.Trim(),
            };
        }

        private void RegistrationPW(M_Employee RegPW)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("社員データを更新します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = EmployeeDataAccess.RegistrationPW(RegPW);
            if (flg == true)
            {
                MessageBox.Show("パスワードを登録しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("パスワードの登録に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxPW.Focus();
            }
        }

        public void FormShow()
        {
            int PolID = LoginData.PoID;

            if (PolID == 1)
            {
                this.Visible = false;
                F_管理者 f_Admin = new F_管理者(LoginData);
                f_Admin.Show();
                return;
            }
            if (PolID == 2)
            {
                this.Visible = false;
                F_営業 f_Eigyou = new F_営業(LoginData);
                f_Eigyou.Show();
                return;
            }
            if (PolID == 3)
            {
                this.Visible = false;
                F_物流 f_buturyu = new F_物流(LoginData);
                f_buturyu.Show();
                return;
            }
            else
            {
                this.Visible = false;
                F_PW新規登録 f_SinkiTouroku = new F_PW新規登録(LoginData);
                f_SinkiTouroku.Show();
                return;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_ログイン画面 f_login = new F_ログイン画面();
            f_login.Show();
        }

    }
}
