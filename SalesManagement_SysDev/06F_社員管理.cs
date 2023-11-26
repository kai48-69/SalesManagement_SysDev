using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesManagement_SysDev
{
    public partial class F_社員管理 : Form
    {
        readonly EmployeeDataAccess EmployeeDataAccess = new EmployeeDataAccess();
        private readonly InputCheck ichk = new InputCheck();
        readonly EmployeeDbConnection DB = new EmployeeDbConnection();
        private static List<M_SalesOffice> SoNameDsp;
        private static List<M_Position> PoNameDsp;
        readonly LoginData LoginData;

        public F_社員管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }

        //画面ロード時処理
        private void F_社員管理_Load(object sender, EventArgs e)
        {
            TextboxHihyoji.Enabled = false;
            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("商品情報を取得することができません。", "商品確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //在庫情報の全件取得
            List<DispEmployeeListDTO> tb = DB.EmployeeGetData("");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            SoNameDsp = DB.GetSoNameDspData();
            ComboEigyousyoName.Items.AddRange(SoNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "SoName";
            ComboEigyousyoName.ValueMember = "SoID";
            ComboEigyousyoName.DataSource = SoNameDsp;

            PoNameDsp = DB.GetPoNameDspData();
            ComboYakusyokuName.Items.AddRange(PoNameDsp.ToArray());
            ComboYakusyokuName.DisplayMember = "PoName";
            ComboYakusyokuName.ValueMember = "PoID";
            ComboYakusyokuName.DataSource = PoNameDsp;

            //初期値を０に
            ComboEigyousyoName.SelectedIndex = 0;
            ComboYakusyokuName.SelectedIndex = 0;

            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboYakusyokuName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispEmployeeListDTO> tb)
        {
            dataGridView1.DataSource = tb;
            //列幅自動設定解除
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //ヘッダーの高さ
            dataGridView1.ColumnHeadersHeight = 50;
            //ヘッダーの折り返し表示
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //行単位選択     
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー文字位置、セル文字位置、列幅の設定
            //社員ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 40;
            //社員名
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].Width = 80;
            //営業所名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].Width = 80;
            //役職名
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].Width = 65;
            ////入社年月日
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].Width = 70;
            ////電話番号
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].Width = 80;
            ////非表示理由
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 513;

            dataGridView1.Refresh();
        }

        //データグリッドビューをクリックしたときの処理
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RadioTouroku.Checked == true)
            {
                TextboxSyainID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TextboxSyainName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                ComboYakusyokuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                NyusyaDate.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                TextboxTelNo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            }
            else
            {
                TextboxSyainID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TextboxSyainName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                ComboYakusyokuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                TextboxTelNo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            }
        }


        //実行ボタン
        private void ButtonExe_Click(object sender, EventArgs e)
        {
            //登録処理----------------------------------------------------------------------
            if (RadioTouroku.Checked == true)
            {
                if (!GetVaildDataAtRegistration())
                {
                    return;
                }
                var regEmp = GenerateDataAtRegistration();

                RegistrationProduct(regEmp);
            }

            //検索処理----------------------------------------------------------------------
            if (RadioKensaku.Checked == true)
            {
                {
                    if (!GetVaildDataAtSelect())
                    {
                        return;
                    }
                    GenerateDataAtSelect();
                }
            }

            //更新処理----------------------------------------------------------------------
            if (RadioKousin.Checked == true)
            {
                if (!GetVaildDataAtUpdate())
                {
                    return;
                }

                var updEmployee = GenereteDataAtUpdate();

                UpdateEmployee(updEmployee);
            }

            // 非表示処理--------------------------------------------------------------------
            if (RadioHihyouji.Checked == true)
            {
                if (!GetVaildDataAtHide())
                {
                    return;
                }

                var hidEmployee = GenereteDataAtHidden();

                HideEmployee(hidEmployee);
            }
        }

        //登録処理--------------------------------------------------------------------------

        private bool GetVaildDataAtRegistration() //入力データチェック
        {
            if (DB.CheckCascadeEmployeesID(int.Parse(TextboxSyainID.Text)) != -1)
            {
                MessageBox.Show("その社員IDは既に使われているため、登録できません");
                TextboxSyainID.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxSyainName.Text.Trim()))
            {
                MessageBox.Show("社員名が入力されていません");
                TextboxSyainName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxTelNo.Text.Trim()))
            {
                MessageBox.Show("電話番号が入力されていません");
                TextboxTelNo.Focus();
                return false;
            }

            return true;
        }

        private M_Employee GenerateDataAtRegistration() //登録データ生成
        {
            int SoID = ComboEigyousyoName.SelectedIndex;
            int PoID = ComboYakusyokuName.SelectedIndex;
            return new M_Employee
            {
                EmID = int.Parse(TextboxSyainID.Text.Trim()),
                EmName = TextboxSyainName.Text.Trim(),
                EmPhone = TextboxTelNo.Text.Trim(),
                SoID = SoID + 1,
                PoID = PoID,
                EmHiredate = NyusyaDate.Value,
                EmPassword = "oic",
                EmFlag = 0,
                EmHidden = null,
            };
        }

        private void RegistrationProduct(M_Employee regEmp) //データ登録処理
        {
            DialogResult result = MessageBox.Show("社員データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = EmployeeDataAccess.AddEmployeeData(regEmp);
            if (flg == true)
            {
                MessageBox.Show("データを登録しました");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxSyainID.Focus();
            }
            ClearInput();
            GetDataGridView();
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxSyainID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyainID.Text.Trim()))
                {
                    MessageBox.Show("社員IDはすべて半角数字で入力してください。");
                    TextboxSyainID.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool GenerateDataAtSelect() //検索データ生成
        {
            int SoID;
            if (ComboEigyousyoName.SelectedIndex == -1)
            {
                SoID = -1;
            }
            else
            {
                SoID = int.Parse(ComboEigyousyoName.SelectedValue.ToString());
            }
            int PoID;
            if (ComboYakusyokuName.SelectedIndex == -1)
            {
                PoID = -1;
            }
            else
            {
                PoID = int.Parse(ComboYakusyokuName.SelectedValue.ToString());
            }
            //整数型(int)に変換する準備

            var EmID = TextboxSyainID.Text.Trim();

            //変換処理
            if (!int.TryParse(EmID, out int SyainID))
            {
                SyainID = -1;
            }

            M_Employee selectCondition = new M_Employee()
            {
                EmPhone = TextboxTelNo.Text.Trim(),
                EmID = SyainID,
                SoID = SoID,
                PoID = PoID,
                //EmFlag = 0,
            };

            List<DispEmployeeListDTO> tb = DB.GetEmployeeData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //更新処理-----------------------------------------------------------------------
        private bool GetVaildDataAtUpdate()//入力データチェック
        {

            if (String.IsNullOrEmpty(TextboxSyainID.Text.Trim()))
            {
                MessageBox.Show("更新する社員データを選択してください");
                return false;
            }

            if (String.IsNullOrEmpty(TextboxSyainName.Text.Trim()))
            {
                MessageBox.Show("社員名が入力されていません");
                TextboxSyainName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxTelNo.Text.Trim()))
            {
                MessageBox.Show("電話番号が入力されていません");
                TextboxTelNo.Focus();
                return false;
            }

            return true;
        }

        private M_Employee GenereteDataAtUpdate()　//更新データ生成
        {
            int SoID = ComboEigyousyoName.SelectedIndex;
            int PoID = ComboYakusyokuName.SelectedIndex;
            return new M_Employee
            {
                EmID = int.Parse(TextboxSyainID.Text.Trim()),
                EmName = TextboxSyainName.Text.Trim(),
                EmPhone = TextboxTelNo.Text.Trim(),
                SoID = SoID + 1,
                PoID = PoID,
                EmFlag = 0,
                EmHidden = null,
            };
        }

        private void UpdateEmployee(M_Employee updEmp)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("社員データを更新します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = EmployeeDataAccess.UpdateEmployeeData(updEmp);
            if (flg == true)
            {
                MessageBox.Show("データを更新しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの更新に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSyainName.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //非表示処理--------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxSyainID.Text.Trim()))
            {
                MessageBox.Show("非表示にするする社員データを選択してください");
                return false;
            }

            if (EmployeeDataAccess.CheckCascadeEmployee(int.Parse(TextboxSyainID.Text.Trim())))
            {
                MessageBox.Show("選択された社員IDは他で使用されているため非表示にできません。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(TextboxHihyoji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private M_Employee GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            int SoID = ComboEigyousyoName.SelectedIndex;
            int PoID = ComboYakusyokuName.SelectedIndex;
            return new M_Employee
            {
                EmID = int.Parse(TextboxSyainID.Text.Trim()),
                EmName = TextboxSyainName.Text.Trim(),
                EmPhone = TextboxTelNo.Text.Trim(),
                SoID = SoID + 1,
                PoID = PoID,
                EmFlag = 2,
                EmHidden = TextboxHihyoji.Text.Trim(),
            };
        }

        private void HideEmployee(M_Employee hidEmp)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("顧客データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = EmployeeDataAccess.HideEmployeeData(hidEmp);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSyainName.Focus();
            }
            ClearInput();

            GetDataGridView();
        }


        //入力クリア----------------------------------------------------------------------
        private void ClearInput()
        {

            if (RadioKensaku.Checked == true || RadioHihyouji.Checked == true)//検索時、非表示時はコンボボックスの値を空にする
            {
                ComboEigyousyoName.SelectedIndex = -1;
                ComboYakusyokuName.SelectedIndex = -1;
                TextboxSyainID.Text = "";
                TextboxSyainName.Text = "";
                TextboxTelNo.Text = "";
                TextboxHihyoji.Text = "";
            }
            else   //上記以外の場合は表示する
            {
                ComboEigyousyoName.SelectedIndex = 0;
                ComboYakusyokuName.SelectedIndex = 0;
                TextboxSyainID.Text = "";
                TextboxSyainName.Text = "";
                TextboxTelNo.Text = "";
                TextboxHihyoji.Text = "";
            }
        }

        //戻るボタン----------------------------------------------------------------------
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_管理者 f_Admin = new F_管理者(LoginData);
            f_Admin.Show();
        }

        //入力リセットボタン-------------------------------------------------------------
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }


        //登録時の入力項目選択-----------------------------------------------------------
        private void RadioTouroku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyainID.ReadOnly = false;
            TextboxSyainName.ReadOnly = false;
            TextboxTelNo.ReadOnly = false;
            ComboEigyousyoName.SelectedIndex = 0;
            ComboYakusyokuName.SelectedIndex = 0;
            TextboxHihyoji.Enabled = false;
            NyusyaDate.Value = DateTime.Now;
            NyusyaDate.Visible = true;
            LblNyusyaDate.Visible = true;
        }

        //検索時の入力項目選択-----------------------------------------------------------
        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyainID.ReadOnly = false;
            TextboxSyainName.ReadOnly = false;
            TextboxTelNo.ReadOnly = false;
            ComboEigyousyoName.SelectedIndex = -1;
            ComboYakusyokuName.SelectedIndex = -1;
            TextboxHihyoji.Enabled = false;
            NyusyaDate.Visible = false;
            LblNyusyaDate.Visible = false;
        }

        //更新時の入力項目選択-----------------------------------------------------------
        private void RadioKousin_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyainID.ReadOnly = true;
            TextboxSyainName.ReadOnly = false;
            TextboxTelNo.ReadOnly = false;
            ComboEigyousyoName.SelectedIndex = 0;
            ComboYakusyokuName.SelectedIndex = 0;
            TextboxHihyoji.Enabled = false;
            NyusyaDate.Value = DateTime.Now;
            NyusyaDate.Visible = false;
            LblNyusyaDate.Visible = false;
        }

        //非表示時の入力項目選択-----------------------------------------------------------
        private void RadioHihyouji_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyainID.ReadOnly = true;
            TextboxSyainName.ReadOnly = true;
            TextboxTelNo.ReadOnly = true;
            ComboEigyousyoName.SelectedIndex = -1;
            ComboYakusyokuName.SelectedIndex = -1;
            TextboxHihyoji.Enabled = true;
            NyusyaDate.Value = DateTime.Now;
            NyusyaDate.Visible = false;
            LblNyusyaDate.Visible = false;
        }
    }
}
