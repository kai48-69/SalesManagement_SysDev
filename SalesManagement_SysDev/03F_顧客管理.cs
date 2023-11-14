using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_顧客管理 : Form
    {
        public F_顧客管理()
        {
            InitializeComponent();
        }

        ClientDbConnection DB = new ClientDbConnection();
        private static List<M_SalesOffice> SoNameDsp;

        //画面ロード時処理
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //在庫情報の全件取得
            List<DispClientListDTO> tb = DB.ClientGetData("", "", 0);
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

            //初期値を０に
            ComboEigyousyoName.SelectedIndex = 0;
           

            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;
           
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispClientListDTO> tb)
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExe_Click(object sender, EventArgs e)
        {
            //登録処理----------------------------------------------------------------------
            if (RadioTouroku.Checked == true)
            {
                if (!GetVaildDataAtRegistration())
                {
                    return;
                }
                var regPro = GenerateDataAtRegistration();

                RegistrationProduct(regPro);
            }
        }

        private bool GetVaildDataAtRegistration() //入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxSyohinName.Text.Trim()))
            {
                MessageBox.Show("商品名が入力されていません");
                TextboxSyohinName.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxStock.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxStock.Text.Trim()))
                {
                    MessageBox.Show("安全在庫数は半角数字で入力してください");
                    TextboxStock.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("安全在庫数が入力されていません");
                TextboxStock.Focus();
                return false;
            }


            if (!String.IsNullOrEmpty(TextboxKakaku.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxKakaku.Text.Trim()))
                {
                    MessageBox.Show("価格は半角数字で入力してください");
                    TextboxKakaku.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("価格が入力されていません");
                TextboxKakaku.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxColor.Text.Trim()))
            {
                MessageBox.Show("色が入力されていません");
                TextboxColor.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(TextboxKataban.Text.Trim()))
            {
                MessageBox.Show("型番が入力されていません");
            }

            return true;
        }

        private M_Product GenerateDataAtRegistration() //登録データ生成
        {
            string ManuID = ComboMakerName.SelectedIndex.ToString();
            string PD = ComboSyobunrui.SelectedValue.ToString();
            return new M_Product
            {
                MaID = int.Parse(ManuID),
                PrID = int.Parse(TextboxSyouhinID.Text.Trim()),
                PrName = TextboxSyohinName.Text.Trim(),
                ScID = int.Parse(PD),
                PrModelNumber = TextboxKataban.Text.Trim(),
                PrSafetyStock = int.Parse(TextboxStock.Text.Trim()),
                Price = int.Parse((TextboxKakaku.Text.Trim())),
                PrColor = TextboxColor.Text.Trim(),
                PrReleaseDate = HatubaiDate.Value,
                PrFlag = 0,
                PrHidden = null,
            };
        }

        private void RegistrationProduct(M_Product regPro) //データ登録処理
        {
            DialogResult result = MessageBox.Show("商品データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = ProductDataAccess.AddProductData(regPro);
            if (flg == true)
            {
                MessageBox.Show("データを登録しました");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxSyouhinID.Focus();
            }
            ClearInput();
            GetDataGridView();
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxSyouhinID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyouhinID.Text.Trim()))
                {
                    MessageBox.Show("商品コードはすべて半角数字で入力してください。");
                    TextboxSyouhinID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxStock.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxStock.Text.Trim()))
                {
                    MessageBox.Show("安全在庫数は半角数字で入力してください");
                    TextboxStock.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxKakaku.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxKakaku.Text.Trim()))
                {
                    MessageBox.Show("価格は半角数字で入力してください");
                    TextboxKakaku.Focus();
                    return false;
                }
            }
            if (!String.IsNullOrEmpty(TextboxKataban.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxKataban.Text.Trim()))
                {
                    MessageBox.Show("型番は半角数字で入力してください");
                    TextboxKakaku.Focus();
                    return false;
                }
            }
            return true;
        }
    }

}
