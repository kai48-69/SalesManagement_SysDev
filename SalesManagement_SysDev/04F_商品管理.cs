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
    public partial class F_商品管理 : Form
    {
        private InputCheck ichk = new InputCheck();
        ProductDataAccess ProductDataAccess = new ProductDataAccess();
        ProductDbConnection DB = new ProductDbConnection();
        private static List<M_Maker> MNameDsp;
        private static List<M_SmallClassification> ScDsp;

        public F_商品管理()
        {
            InitializeComponent();
        }

        private bool GetDataGridView()
        {
            //在庫情報の全件取得
            List<DispProductListDTO> tb = DB.ProductGetData("", "", 0);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        private void F_商品管理_Load(object sender, EventArgs e)
        {
            SetFormComboBox();

            if (!GetDataGridView())
            {
                MessageBox.Show("商品情報を取得することができません。", "商品確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SetFormComboBox()
        {
            MNameDsp = DB.GetMakerNameDspData();
            ComboMakerName.Items.AddRange(MNameDsp.ToArray());
            ComboMakerName.DisplayMember = "MaName";
            ComboMakerName.ValueMember = "MaID";
            ComboMakerName.DataSource = MNameDsp;

            ScDsp = DB.GetScDspData();
            ComboSyobunrui.Items.AddRange(ScDsp.ToArray());
            ComboSyobunrui.DisplayMember = "ScName";
            ComboSyobunrui.ValueMember = "ScID";
            ComboSyobunrui.DataSource = ScDsp;

            //初期値を０に
            ComboMakerName.SelectedIndex = 0;
            ComboSyobunrui.SelectedIndex = 0;

            //読み込み専用に
           ComboMakerName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSyobunrui.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SetDataGridView(List<DispProductListDTO> tb)
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
            ////商品コード
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 100;
            ////商品名
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].Width = 150;
            //商品名カナ
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].Width = 120;
            //商品区分
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].Width = 100;
            ////メーカー名
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].Width = 100;
            ////安全在庫数
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].Width = 50;
            ////数量単位名称
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 50;
            ////仕入れ価格
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].Width = 80;
            ////標準価格
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].Width = 80;
            ////販売価格    
            dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[9].Width = 80;


            dataGridView1.Refresh();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流();
            f_buturyuu.Show();
        }

        private void ButtonBunruikanri_Click(object sender, EventArgs e)
        {
            this.Close();
            F_小分類管理 f_bunrui = new F_小分類管理();
            f_bunrui.Show();
        }

        private void ButtonExe_Click(object sender, EventArgs e)
        {
            if (RadioTouroku.Checked == true)
            {
                if (!CheckInputData())
                {
                    return;
                }
                var regPro = GenerateDataAtRegistration();

                RegistrationProduct(regPro);
            }
            if (RadioKensaku.Checked == true)
            {
                {
                    if (!CheckInputData())
                    {
                        return;
                    }
                    GenerateDataAtSelect();
                }
            }
        }
        private bool CheckInputData()
        {
            if (!String.IsNullOrEmpty(TextboxSyouhinID.Text))
            {
                if (!ichk.IntegerCheck(TextboxSyouhinID.Text.Trim()))
                {
                    MessageBox.Show("商品コードはすべて半角数字で入力してください。");
                    TextboxSyouhinID.Focus();
                    return false;
                }
                if (TextboxSyouhinID.TextLength < 13)
                {
                    MessageBox.Show("商品コードは13桁です。");
                    TextboxSyouhinID.Focus();
                    return false;
                }
                if (ichk.CheckProductCDExistence(TextboxSyouhinID.Text.Trim()))
                {
                    MessageBox.Show("入力された商品コードは既に存在します。");
                    TextboxSyouhinID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("商品コードが入力されていません");
                TextboxSyouhinID.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxSyohinName.Text.Trim()))
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
                    MessageBox.Show("仕入価格は半角数字で入力してください");
                    TextboxKakaku.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("仕入価格が入力されていません");
                TextboxKakaku.Focus();
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxColor.Text.Trim()))
            {
                MessageBox.Show("色が入力されていません");
                TextboxColor.Focus();
                return false;
            }

            return true;
        }

        private M_Product GenerateDataAtRegistration()
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

        private void RegistrationProduct(M_Product regPro)
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

        private void GenerateDataAtSelect()
        {

        }

        private void ClearInput()
        {
            TextboxSyouhinID.Text = "";
            TextboxSyohinName.Text = "";
            TextboxKakaku.Text = "";
            TextboxStock.Text = "";
            ComboSyobunrui.Text = "";
            TextboxKataban.Text = "";
            TextboxColor.Text = "";
            HatubaiDate.Value = DateTime.Now;
            TextboxHihyouji.Text = "";

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

       
    }
}
