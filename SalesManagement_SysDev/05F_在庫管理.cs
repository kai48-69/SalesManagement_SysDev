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
    public partial class F_在庫管理 : Form
    {
        readonly WarehouseDbConnection DB2 = new WarehouseDbConnection();
        readonly WarehouseDataAccess WDA = new WarehouseDataAccess();
        readonly StockDataAccess SDA = new StockDataAccess();
        readonly private InputCheck ichk = new InputCheck();
        readonly LoginData LoginData;
        public F_在庫管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流(LoginData);
            f_buturyuu.Show();
        }

        private void F_入庫管理_Load(object sender, EventArgs e)
        {
            if (!GetDataGridView())
            {
                MessageBox.Show("在庫情報を取得することができません。", "在庫確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //商品情報の全件取得
            List<DispWarehousingListDTO> tb = DB2.WareHousingGetData();
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        private void SetDataGridView(List<DispWarehousingListDTO> tb)
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
            //受注年月日
            dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].Width = 90;

            dataGridView1.Refresh();
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
            //更新処理----------------------------------------------------------------------
            if (RadioKousin.Checked == true)
            {
                if (!GetVaildDataAtUpdate())
                {
                    return;
                }

                var updProduct = GenereteDataAtUpdate();

                UpdateStock(updProduct);
            }


        }
        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxShouhinID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSuryo.Text.Trim()))
                {
                    MessageBox.Show("数量は半角数字で入力してください。");
                    TextboxSuryo.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxShouhinID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSuryo.Text.Trim()))
                {
                    MessageBox.Show("発注IDは半角数字で入力してください");
                    TextboxShouhinID.Focus();
                    return false;
                }
            }
            return true;
        }



        private bool GenerateDataAtSelect() //検索データ生成
        {

            //整数型(int)に変換する準備

            var PrID = TextboxShouhinID.Text.Trim();



            var Suryo = TextboxSuryo.Text.Trim();

            //変換処理
            if (!int.TryParse(PrID, out int ShouhinID))
            {
                ShouhinID = -1;
            }



            if (!int.TryParse(Suryo, out int Kazu))
            {
                Kazu = -1;
            }


            T_Warehousing selectCondition = new T_Warehousing()
            {
                WaID = ShouhinID,

                HaID = Kazu
            };

            List<DispWarehousingListDTO> tb = DB2.GetWareHousingData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //更新処理-----------------------------------------------------------------------
        private bool GetVaildDataAtUpdate()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxShouhinID.Text.Trim()))
            {
                MessageBox.Show("更新する在庫データを選択してください");
            }

            if (String.IsNullOrEmpty(TextboxSuryo.Text.Trim()))
            {
                MessageBox.Show("数量が入力されていません");
                TextboxSuryo.Focus();
                return false;
            }
            return true;
        }

        private T_Stock GenereteDataAtUpdate() //更新データ生成
        {
            string StID = TextboxShouhinID.ToString();
            string StQuantity = TextboxSuryo.ToString();
            return new T_Stock
            {
                StID = int.Parse(StID),
                StQuantity = int.Parse(StQuantity)
            };
        }

        private void UpdateStock(T_Stock updSt) //データ更新処理
        {
            DialogResult result = MessageBox.Show("在庫データを更新します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = SDA.UpdateStockData(updSt);
            if (flg == true)
            {
                MessageBox.Show("データを更新しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの更新に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxShouhinID.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //入力リセット--------------------------------------------------------------------
        private void ClearInput()
        {
            TextboxShouhinID.Text = "";
            TextboxSuryo.Text = "";
        }
        //リセットボタン------------------------------------------------------------------
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }











        private void RadioKousin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}