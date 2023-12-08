using SalesManagement_SysDev.Order;
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
    public partial class F_入庫管理 : Form
    {
        readonly WarehouseDbConnection DB2 = new WarehouseDbConnection();
        readonly WarehouseDataAccess WDA = new WarehouseDataAccess();
        readonly StockDataAccess SDA = new StockDataAccess();
        readonly private InputCheck ichk = new InputCheck();
        readonly LoginData LoginData;

        public F_入庫管理(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
            this.LblEmName.Text = LData.EmName;
            this.LblSoName.Text = LData.SoName;
            this.LblLoginDate.Text = LData.LoginDatetime.ToString();
        }


        //画面ロード時処理
        private void F_入庫管理_Load(object sender, EventArgs e)
        {
            TextboxHihyouji.Enabled = false;
            ButtonKakutei.Enabled = false;

            if (!GetDataGridView())
            {
                MessageBox.Show("入庫情報を取得することができません。", "入庫確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //データグリッドビューの表示設定
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
        { //検索処理----------------------------------------------------------------------
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

                var hidWa = GenereteDataAtHidden();

                HideWa(hidWa);
            }
        }
        //確定ボタン----------------------------------------------------------------------
        private void ButtonKakutei_Click(object sender, EventArgs e)
        {
            if (!CheckDataAtConfirm())
            {
                return;
            }
            ConfirmWa();
            var ConWa = GenereteDataAtUpdateFlg();
            UpdWaFlag(ConWa);
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxNyukoID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxNyukoID.Text.Trim()))
                {
                    MessageBox.Show("受注IDは半角数字で入力してください。");
                    TextboxNyukoID.Focus();
                    return false;
                }
            }

            if (!String.IsNullOrEmpty(TextboxHattyuID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxHattyuID.Text.Trim()))
                {
                    MessageBox.Show("発注IDは半角数字で入力してください");
                    TextboxHattyuID.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool GenerateDataAtSelect() //検索データ生成
        {
           
            //整数型(int)に変換する準備
            
            var WaID = TextboxNyukoID.Text.Trim();
            
    

            var HaID=TextboxHattyuID.Text.Trim();    

            //変換処理
            if (!int.TryParse(WaID, out int JutyuID))
            {
                JutyuID = -1;
            }

        

            if(!int.TryParse(HaID,out int HattyuID))
            {
                HattyuID = -1;   
            }


           T_Warehousing  selectCondition = new T_Warehousing()
            {
                WaID = JutyuID,
             
                HaID= HattyuID
            };

            List<DispWarehousingListDTO> tb = DB2.GetWareHousingData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //非表示処理----------------------------------------------------------------------
        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxNyukoID.Text.Trim()))
            {
                MessageBox.Show("非表示にする入庫データを選択してください", "エラー");
                return false;
            }


            if (String.IsNullOrEmpty(TextboxHihyouji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private T_Warehousing GenereteDataAtHidden()　//非表示データ生成(フラグの更新データ生成)
        {
            return new T_Warehousing
            {
                WaID = int.Parse(TextboxNyukoID.Text),
                WaFlag = 2,
                WaHidden = TextboxHihyouji.Text,
            };
        }

        private void HideWa(T_Warehousing hidWa)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("受注データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = WDA.HideWarehouseData(hidWa);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNyukoID.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流(LoginData);
            f_buturyuu.Show();
        }

        //確定処理------------------------------------------------------------------------
        private bool CheckDataAtConfirm()
        {
            if (String.IsNullOrEmpty(TextboxNyukoID.Text.Trim()))
            {
                MessageBox.Show("確定を行うデータが選択されていません");
                return false;
            }
            return true;
        }

        private void ConfirmWa()//注文テーブルにデータを登録する
        {
            DialogResult result = MessageBox.Show("入庫情報を確定します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            T_Warehousing selectCondition = new T_Warehousing()
            {
                WaID = int.Parse(TextboxNyukoID.Text),
            };
            List<GetNyukoDataDTO> Data1 = DB2.SetNyukoData(selectCondition);
           
            T_Stock Stock = new T_Stock();
            for (int i = 0; i < Data1.Count; i++)
            {
                Stock.StQuantity =Data1[i].WaQuantity;
                SDA.UpdateStockData(Stock);
            }
      
             MessageBox.Show("データを確定しました");
        }

        private T_Warehousing GenereteDataAtUpdateFlg()　//確定データ生成(フラグの更新データ生成)
        {
            return new T_Warehousing
            {
                WaID = int.Parse(TextboxNyukoID.Text),
                WaShelfFlag = 1,
            };
        }

        private void UpdWaFlag(T_Warehousing ConWa)　//フラグ更新処理
        {
            WDA.UpdWarehouseFlg(ConWa);

            ClearInput();

            GetDataGridView();
        }

        //入力リセット--------------------------------------------------------------------
        private void ClearInput()
        {
            TextboxHattyuID.Text = "";
            TextboxNyukoID.Text = "";
        }
        //リセットボタン------------------------------------------------------------------
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
