using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_受注管理 : Form
    {
        OrderDbConnection DB = new OrderDbConnection();
        OrderDataAccess ODA=new OrderDataAccess();
        private static List<M_Client> ClNameDsp;
        private InputCheck ichk = new InputCheck();

        public F_受注管理()
        {
            InitializeComponent();
        }
        //画面ロード時処理
        private void F_受注管理_Load(object sender, EventArgs e)
        {
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
            List<DispOrderListDTO> tb = DB.OrderGetData("");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            ClNameDsp = DB.GetClientNameDspData();
            ComboKokyakuName.Items.AddRange(ClNameDsp.ToArray());
            ComboKokyakuName.DisplayMember = "MaName";
            ComboKokyakuName.ValueMember = "MaID";
            ComboKokyakuName.DataSource = ClNameDsp;
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispOrderListDTO> tb)
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
            ////商品ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 40;
            ////メーカー名
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].Width = 50;
            //商品名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].Width = 80;
            //価格
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].Width = 80;
            ////安全在庫数
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].Width = 40;
            ////小分類
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].Width = 80;
            ////型番
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 30;
            ////色
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].Width = 70;
            ////発売日
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].Width = 80;
            ////非表示理由 
            dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[9].Width = 400;

            dataGridView1.Refresh();
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

                var regOr = GenerateDataAtRegistration();
                var regDetailOr = GenerateDataAtDetailRegistration();

                RegistrationOrder(regOr);
            }
        }

        //登録処理--------------------------------------------------------------------------
        private bool GetVaildDataAtRegistration() //入力データチェック
        {

            if (!String.IsNullOrEmpty(TextboxTantousyaName.Text.Trim()))
            {
                MessageBox.Show("顧客担当者名が入力されていません");
                TextboxTantousyaName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxSyohinID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyohinID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは半角数字で入力してください");
                    TextboxSyohinID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("商品IDが入力されていません");
                TextboxSyohinID.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxSyainID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyainID.Text.Trim()))
                {
                    MessageBox.Show("社員IDは半角数字で入力してください");
                    TextboxSyainID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("社員IDが入力されていません");
                TextboxSyainID.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxSuryou.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSuryou.Text.Trim()))
                {
                    MessageBox.Show("数量は半角数字で入力してください");
                    TextboxSyohinID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("数量が入力されていません");
                TextboxSyohinID.Focus();
                return false;
            }
            return true;
        }

        private T_Order GenerateDataAtRegistration() //登録データ生成
        {
            int ClID = ComboKokyakuName.SelectedIndex;
            int SoID=ComboEigyousyoName.SelectedIndex;
            return new T_Order
            {
                OrID = int.Parse(TextboxJutyuID.Text.Trim()),
                SoID = SoID,
                EmID = int.Parse(TextboxSyainID.Text.Trim()),
                ClID = ClID,
                ClCharge = TextboxTantousyaName.Text.Trim(),
                OrDate = DateTime.Now,
                OrHidden = TextboxHihyouji.Text.Trim(),
            };
        }

        private T_OrderDetail GenerateDataAtDetailRegistration() //詳細用登録データ生成
        {
            int PrID = int.Parse(TextboxSyohinID.Text.Trim());
           int Suryou= int.Parse(TextboxSuryou.Text.Trim());
            decimal Price =ODA.GetPrice(PrID);

            return new T_OrderDetail
            {
                OrDetailID = int.Parse(TextboxSyosaiID.Text.Trim()),
                OrID = int.Parse(TextboxJutyuID.Text.Trim()),
                PrID = PrID,
                OrQuantity = int.Parse(TextboxSuryou.Text.Trim()),
                OrTotalPrice=Suryou*Price,
            };
        }

        private void RegistrationOrder(T_Order regOr) //データ登録処理
        {
            DialogResult result = MessageBox.Show("商品データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = ODA.AddOrderData(regOr);
            if (flg == true)
            {
                MessageBox.Show("データを登録しました");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxSyainName.Focus();
            }
            ClearInput();
            GetDataGridView();
        }


        //戻るボタン----------------------------------------------------------------------
        private void ButtonBack(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }
        private void ClearInput()
        {

        }
        //リセットボタン------------------------------------------------------------------
        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
