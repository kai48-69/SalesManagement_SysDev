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
    public partial class F_入荷管理 : Form
    {
        readonly OrderDbConnection DB = new OrderDbConnection();
        readonly ArrivalDbConnection DB1= new ArrivalDbConnection();    
        private static List<M_Client> ClNameDsp;
        readonly private InputCheck ichk = new InputCheck();
        readonly LoginData LoginData;
        readonly ArrivalDbConnection DB2 = new ArrivalDbConnection();


        public F_入荷管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }



        private void F_入荷管理_Load(object sender, EventArgs e)
        {
            TextBoxHidden.Enabled = false;
            button1.Enabled = false;
            
            
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
            //商品情報の全件取得
            List<DispArrivalListDTO> tb = DB1.ArrivalGetData("");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        private void SetFormComboBox()
        {
            ClNameDsp = DB.GetClientNameDspData();
            ComboEigyousyoName.Items.AddRange(ClNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "ClName";
            ComboEigyousyoName.ValueMember = "ClID";
            ComboEigyousyoName.DataSource = ClNameDsp;


            //初期値を０に
            ComboEigyousyoName.SelectedIndex = 0;

            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SetDataGridView(List<DispArrivalListDTO> tb)
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
            //受注ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 40;
            ////受注詳細ID
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 50;
            //営業所名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 80;
            //社員名
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 80;
            //顧客名
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].Width = 80;
            //顧客担当者名
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].Width = 120;
            //商品名
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 70;
            //数量
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].Width = 70;
            //合計金額
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].Width = 80;

            dataGridView1.Refresh();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業(LoginData);
            f_eigyou.Show();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        //入力リセット--------------------------------------------------------------------
        private void ClearInput()
        {
                TextBoxNyuukaID.Text = "";
                ComboEigyousyoName.SelectedIndex = -1;
                TextBoxkokyakuID.Text="";
                TextBoxkokyakuName.Text = "";
                TextBoxSyainID.Text = "";
                TextBoxSyainName.Text = "";
            
        }

        private void ButtonKakutei_Click(object sender, EventArgs e)
        {

        }



        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {

        }

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

            //非表示処理--------------------------------------------------------------------
            if (RadioHihyouji.Checked == true)
            {
                if (!GetVaildDataAtHide())
                {
                    return;
                }

                var hidAr = GenereteDataAtHidden();

                HideAr(hidAr);
            }

        }

        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextBoxNyuukaID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextBoxNyuukaID.Text.Trim()))
                {
                    MessageBox.Show("入荷IDはすべて半角数字で入力してください。");
                    TextBoxNyuukaID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextBoxkokyakuID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextBoxkokyakuID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDは半角数字で入力してください");
                    TextBoxkokyakuID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextBoxSyainID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextBoxSyainID.Text.Trim()))
                {
                    MessageBox.Show("IDはすべて半角数字で入力してください。");
                    TextBoxSyainID.Focus();
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
            //整数型(int)に変換する準備
            //価格
            var EmID = TextBoxSyainID.Text.Trim();
            var ArID =TextBoxNyuukaID.Text.Trim();
            var ClID=TextBoxkokyakuID.Text.Trim();


            //変換処理
            if (!int.TryParse(ArID,out int NyukaID))
            {
                NyukaID = -1;
            }

            if (!int.TryParse(EmID, out int SyainID))
            {
                SyainID = -1;
            }

            if (!int.TryParse(ClID, out int KokyakuID))
            {
                KokyakuID = -1;
            }


            T_Arrival selectCondition = new T_Arrival()
            {
                ArID = NyukaID,
                SoID = SoID,
                ClID = KokyakuID,
                EmID = SyainID,
            };

            List<DispArrivalListDTO> tb = DB1.GetArrivalData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }
 
        //非表示処理----------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextBoxNyuukaID.Text.Trim()))
            {
                MessageBox.Show("非表示にする受注データを選択してください", "エラー");
                return false;
            }


            if (String.IsNullOrEmpty(TextBoxHidden.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private T_Arrival GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            return new T_Arrival
            {
                ArID = int.Parse(TextBoxNyuukaID.Text),
                ArFlag = 2,
                ArHidden = TextBoxHidden.Text,
            };
        }

        private void HideAr(T_Arrival hidAr)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("受注データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = DB2.HideOrderData(hidAr);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxSyainName.Focus();
            }
            ClearInput();

            GetDataGridView();
        }





    }
}
