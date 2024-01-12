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
    public partial class F_ログイン画面 : Form
    {
        readonly EmployeeDbConnection DB = new EmployeeDbConnection();

        public F_ログイン画面()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //入力チェック
            int SyainID = GetVaildDataAtLogin();

            //ログイン機能
            if (SyainID == -1)
            { return; }
            if (!CheckIDPW(SyainID))
            { return; }

            //ログイン判定
            int PoID = DetermineForm(SyainID);

            //画面表示
            FormShow(PoID);
        }

        //入力チェック
        private int GetVaildDataAtLogin()
        {
            if (!int.TryParse(TextboxShainID.Text.Trim(), out int SyainID))
            {
                MessageBox.Show("空欄または使用できない文字が入力されました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxShainID.Focus();
                return -1;
            }
            if (String.IsNullOrEmpty(TextboxPW.Text.Trim()))
            {
                MessageBox.Show("パスワードを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxPW.Focus();
                return -1;
            }
            else
            {
                return SyainID;
            }
        }

        //ログイン機能
        private bool CheckIDPW(int SyainID)
        {
            if (DB.CheckCascadeEmployeesID(SyainID) ==SyainID)
            {
                if (!DB.CheckEmployeesPW(TextboxPW.Text.Trim(), SyainID))
                {
                    MessageBox.Show("IDまたはパスワードが違います", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextboxShainID.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("IDまたはパスワードが違います", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxShainID.Focus();
                return false;
            }
        }

        //ログイン判定
        private int DetermineForm(int SyainID)
        {
            int PoID;

            if (TextboxPW.Text == "oic")
            {
                PoID = 4;
            }
            else
            {
                DB.GetPoID(SyainID, out PoID);
            }
            return PoID;
        }

        //画面表示
        public void FormShow(int PolID)
        {
            LoginData LoginData = SetLoginData();

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

        //アプリ終了ボタン
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("アプリケーションを終了します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public LoginData SetLoginData()
        {
            M_Employee selectCondition = new M_Employee()
            {
                EmID = int.Parse(TextboxShainID.Text),
            };
            List<SetLoginDataDTO> LData = DB.SetLoginData(selectCondition);

            //形式変換(DispOrderListDTO→T_Chumon)
            LoginData LoginData = new LoginData
            {
                EmID = LData[0].EmID,
                EmName = LData[0].EmName,
                SoName = LData[0].SoName,
                PoID = LData[0].PoID,
                LoginDatetime = DateTime.Now.ToString("yy/MM/dd HH:mm")
            };

            return LoginData;
        }

        private void Lbl_tag_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = false;
            _99F_データベース生成 f_CreateDatabase =new _99F_データベース生成();
            f_CreateDatabase.Show();
        }
    }
}
