using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_出庫管理 : Form
    {
        readonly LoginData LoginData;
        private static List<M_Client> ClNameDsp;
        private static List<M_SalesOffice> SoNameDsp;
        readonly SyukkoDBConnection DB = new SyukkoDBConnection();
        readonly EmployeeDbConnection DB1 = new EmployeeDbConnection();
        readonly OrderDbConnection DB2 = new OrderDbConnection();
        readonly ArrivalDbConnection DB3= new ArrivalDbConnection();
        readonly SyukkoDateAccess SDA = new SyukkoDateAccess();
        readonly ArrivalDataAccess ADA=new ArrivalDataAccess();
        readonly InputCheck ichk = new InputCheck();
        public F_出庫管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }

        //画面ロード時処理
        private void F_出庫管理_Load(object sender, EventArgs e)
        {
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = false;
            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("出庫情報を取得することができません。", "出庫確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //商品情報の全件取得
            List<DispSyukkoListDTO> tb = DB.SyukoGetData();
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            ClNameDsp = DB2.GetClientNameDspData();
            ComboKokyakuName.Items.AddRange(ClNameDsp.ToArray());
            ComboKokyakuName.DisplayMember = "ClName";
            ComboKokyakuName.ValueMember = "ClID";
            ComboKokyakuName.DataSource = ClNameDsp;

            SoNameDsp = DB1.GetSoNameDspData();
            ComboEigyousyoName.Items.AddRange(SoNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "SoName";
            ComboEigyousyoName.ValueMember = "SoID";
            ComboEigyousyoName.DataSource = SoNameDsp;

            //初期値を０に
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;

            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboKokyakuName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispSyukkoListDTO> tb)
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
            //出庫ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 40;
            //顧客ID
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].Width = 40;
            //顧客名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].Width = 80;
            //営業所名
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].Width = 80;
            //社員ID
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].Width = 40;
            ////入社年月日
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].Width = 70;
            //社員名
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[6].Width = 80;

            dataGridView1.Refresh();
        }

        //データグリッドビューをクリックしたときの処理
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (RadioKensaku.Checked != true)
                {
                    TextboxSyukkoID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    ComboKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    TextboxOrderID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                }
            }
            catch
            {
                //何も処理を行わない
            }
        }

        //実行ボタン
        private void ButtonExe_Click(object sender, EventArgs e)
        {
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
            //非表示処理-----------------------------------------------------------------
            if (RadioHihyouji.Checked == true)
            {
                if (!GetVaildDataAtHide())
                {
                    return;
                }
                var hidSy = GenereteDataAtHidden();

                HideSy(hidSy);
            }
        }

        private void ButtonKakutei_Click(object sender, EventArgs e)
        {
            if (!CheckDataAtConfirm())
            {
                return;
            }

            ConfirmSy();
            var ConSy = GenereteDataAtUpdateFlg();
            UpdSyFlag(ConSy);

        }

        //検索処理----------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxSyukkoID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyukkoID.Text.Trim()))
                {
                    MessageBox.Show("出庫IDはすべて半角数字で入力してください。");
                    TextboxSyukkoID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxOrderID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxOrderID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは半角数字で入力してください");
                    TextboxOrderID.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool GenerateDataAtSelect() //検索データ生成
        {
            int ClID;
            if (ComboKokyakuName.SelectedIndex == -1)
            {
                ClID = -1;
            }
            else
            {
                ClID = int.Parse(ComboKokyakuName.SelectedValue.ToString());
            }
            int SoID;
            if (ComboEigyousyoName.SelectedIndex == -1)
            {
                SoID = -1;
            }
            else
            {
                SoID = int.Parse(ComboEigyousyoName.SelectedValue.ToString());
            }
            //整数型(int)に変換する準備
            var OrID = TextboxOrderID.Text.Trim();
            var SyID = TextboxSyukkoID.Text.Trim();

            //変換処理
            if (!int.TryParse(OrID, out int JutyuID))
            {
                JutyuID = -1;
            }

            if (!int.TryParse(SyID, out int SyukkoID))
            {
                SyukkoID = -1;
            }


            T_Syukko selectCondition = new T_Syukko()
            {
                OrID = JutyuID,
                SoID = SoID,
                ClID = ClID,
                SyID = SyukkoID,
            };

            List<DispSyukkoListDTO> tb = DB.GetSyukkoData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //非表示処理----------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxSyukkoID.Text.Trim()))
            {
                MessageBox.Show("非表示にする注文データを選択してください", "エラー");
                return false;
            }

            if (String.IsNullOrEmpty(TextboxHihyouji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private T_Syukko GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            return new T_Syukko
            {
                SyID = int.Parse(TextboxSyukkoID.Text),
                SyFlag = 2,
                SyHidden = TextboxHihyouji.Text,
            };
        }

        private void HideSy(T_Syukko hidSy)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("出庫データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }


            bool flg = SDA.HideSyukkoData(hidSy);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSyukkoID.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //確定処理------------------------------------------------------------------------
        private bool CheckDataAtConfirm()
        {
            if (String.IsNullOrEmpty(TextboxSyukkoID.Text.Trim()))
            {
                MessageBox.Show("確定を行うデータが選択されていません");
                return false;
            }
            return true;
        }
        private void ConfirmSy()//注文テーブルにデータを登録する
        {
            DialogResult result = MessageBox.Show("出庫情報を確定します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            T_Syukko selectCondition = new T_Syukko()
            {
                SyID = int.Parse(TextboxSyukkoID.Text),
            };
            List<GetSyukkoDataDTO> Data1 = DB.SetSyukkoData(selectCondition);

            //形式変換(DispOrderListDTO→T_Chumon)
            T_Arrival Nyuka = new T_Arrival
            {
                OrID = Data1[0].OrID,
                SoID = Data1[0].SoID,
                ClID = Data1[0].ClID,
                ArDate = DateTime.Now,
            };
            //登録処理
            ADA.AddArrivalData(Nyuka);
            //詳細確定------------------------------------------------------------------------
            //登録したChIDを取得
            int ArID = DB3.GetArID();
            T_ArrivalDetail NyukaDetail = new T_ArrivalDetail();
            for (int i = 0; i < Data1.Count; i++)
            {
                //各データをchumonDetailに代入
                NyukaDetail.ArID = ArID;
                NyukaDetail.PrID = Data1[i].PrID;
                NyukaDetail.ArQuantity = Data1[i].SyQuantity;
                //chumonDetail登録
                ADA.AddArrivalDetailData(NyukaDetail);
            }
            MessageBox.Show("データを確定しました");
        }

        private T_Syukko GenereteDataAtUpdateFlg()　//確定データ生成(フラグの更新データ生成)
        {
            return new T_Syukko
            {
                SyID = int.Parse(TextboxSyukkoID.Text),
                EmID=LoginData.EmID,
                SyDate = DateTime.Now,
                SyStateFlag = 1,
            };
        }

        private void UpdSyFlag(T_Syukko ConSy)　//フラグ更新処理
        {
            SDA.UpdSyukkoFlg(ConSy);

            ClearInput();

            GetDataGridView();
        }

        //戻るボタン
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流(LoginData);
            f_buturyuu.Show();
        }

        //リセットボタン
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        //入力リセット--------------------------------------------------------------------
        private void ClearInput()
        {
            TextboxOrderID.Text = "";
            TextboxSyukkoID.Text = "";
            TextboxHihyouji.Text = "";
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
        }

        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyukkoID.Enabled = true;
            TextboxOrderID.Enabled = true;
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
            ComboEigyousyoName.Enabled = true;
            ComboKokyakuName.Enabled = true;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;

        }

        private void RadioHihyouji_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyukkoID.Enabled = false;
            TextboxOrderID.Enabled = false;
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
            ComboEigyousyoName.Enabled = false;
            ComboKokyakuName.Enabled = false;
            TextboxHihyouji.Enabled = true;
            ButtonKakutei.Enabled = false;
            ButtonExe.Visible = true;
        }

        private void RadioKakutei_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxSyukkoID.Enabled = false;
            TextboxOrderID.Enabled = false;
            ComboEigyousyoName.SelectedIndex = -1;
            ComboKokyakuName.SelectedIndex = -1;
            ComboEigyousyoName.Enabled = false;
            ComboKokyakuName.Enabled = false;
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = true;
            ButtonExe.Visible = false;
        }
    }
}

