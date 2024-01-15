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
    
    public partial class F_受注詳細登録 : Form
    {
       readonly InputCheck ichk = new InputCheck();
       readonly ProductDbConnection DB = new ProductDbConnection();
       readonly OrderDbConnection DB1 = new OrderDbConnection();
       readonly OrderDataAccess ODA = new OrderDataAccess();
        readonly LoginData LoginData;


        public F_受注詳細登録(LoginData LData)
        {
            InitializeComponent();
            LoginData= LData;
            
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //商品情報の全件取得
            List<DispOrderDetailListDTO> tb = DB1.OrderDetailGetData(DB1.GetOrID());
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispOrderDetailListDTO> tb)
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


            dataGridView1.Refresh();
        }

        //登録ボタン-------------------------------------------------------------------------------
        private void ButtonTouroku_Click(object sender, EventArgs e)
        {
            if (!GetVaildDataAtRegistration())
            {
                return;
            }

            var regOrD = GenerateDataAtRegistration();

            RegistrationOrderDetail(regOrD);

         
        }

        //登録処理----------------------------------------------------------------------------------
        private bool GetVaildDataAtRegistration() //入力データチェック
        {

            if (!String.IsNullOrEmpty(TextboxSyohinID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyohinID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは半角数字で入力してください");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("商品IDを入力してください");
                return false;
            }

            if (String.IsNullOrEmpty(TextboxSyohinName.Text))
            {
                MessageBox.Show("正しい商品IDを入力してください");
                return false;
            }

            if (!String.IsNullOrEmpty(TextboxSuryou.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSuryou.Text.Trim()))
                {
                    MessageBox.Show("数量は半角数字で入力してください");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("数量が入力されていません");
                return false;
            }

            return true;
        }

        private T_OrderDetail GenerateDataAtRegistration() //登録データ生成
        {
            int Quantity = int.Parse(TextboxSuryou.Text);
            int PrID = int.Parse(TextboxSyohinID.Text);
            decimal Price = DB.GetPrice(PrID);
            return new T_OrderDetail
            {
                OrID=DB1.GetOrID(),
                PrID=PrID,
                OrQuantity=Quantity,
                OrTotalPrice=Quantity*Price,
            };
        }

        private void RegistrationOrderDetail(T_OrderDetail regOrD) //データ登録処理
        {
            DialogResult result = MessageBox.Show("受注商品データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = ODA.AddOrderDetailData(regOrD);
            if (flg == true)
            {
                GetDataGridView();
                ButtonBack.Visible = true;
                DialogResult result1= MessageBox.Show("データを登録しました\n続けて登録しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result1 == DialogResult.Yes)
                {
                    
                    return;
                }
                else
                {
                    this.Close();
                    F_受注管理 f_jutyu = new F_受注管理(LoginData);
                    f_jutyu.Visible=true;
                }
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxSyohinName.Focus();
                return;
            }
            //ClearInput();
            //GetDataGridView();
        }

        //戻るボタン--------------------------------------------------------------------------------
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_受注管理 f_jutyuu = new F_受注管理(LoginData);
            f_jutyuu.Show();
        }

        private void TextboxSyohinID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextboxSyohinID.Text.Trim(), out int PrID))
            {
                if (DB.CheckCascadeProduct(PrID) != -1)
                {
                    TextboxSyohinName.Text = DB.GetPrName(PrID,0);
                }
                else
                {
                    TextboxSyohinName.Text = "";
                }
            }
            if (String.IsNullOrEmpty(TextboxSyohinID.Text))
            {
                TextboxSyohinName.Text = "";
            }
            
        }
    }
}
