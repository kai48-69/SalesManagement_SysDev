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
        InputCheck ichk = new InputCheck();
        ProductDbConnection DB = new ProductDbConnection();
        OrderDbConnection DB1 = new OrderDbConnection();
        OrderDataAccess ODA = new OrderDataAccess();


        public F_受注詳細登録()
        {
            InitializeComponent();
        }

        private void F_受注詳細登録_Load(object sender, EventArgs e)
        {

        }

        private void ButtonTouroku_Click(object sender, EventArgs e)
        {
            if (!GetVaildDataAtRegistration())
            {
                return;
            }

            var regOrD = GenerateDataAtRegistration();

            RegistrationOrderDetail(regOrD);
        }

        private bool GetVaildDataAtRegistration() //入力データチェック
        {

            if (String.IsNullOrEmpty(TextboxSyohinID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyohinID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは半角数字で入力してください");
                }
            }
            else
            {
                MessageBox.Show("商品IDを入力してください");
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
            DialogResult result = MessageBox.Show("受注詳細データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = ODA.AddOrderDetailData(regOrD);
            if (flg == true)
            {
                 MessageBox.Show("データを登録しました");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxSyohinName.Focus();
            }
            //ClearInput();
            //GetDataGridView();
        }

    }
}
