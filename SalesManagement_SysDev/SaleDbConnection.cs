using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesManagement_SysDev
{
    internal class SaleDbConnection
    {
        public List<DispSaleListDTO> SaleGetData(string strClCharge)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Sale in context.T_Sale

                         join Client in context.M_Clients
                        on Sale.ClID equals Client.ClID

                         join SOffice in context.M_SalesOffices
                         on Sale.SoID equals SOffice.SoID

                         join Employee in context.M_Employees
                        on Sale.EmID equals Employee.EmID

                         join Order in context.T_Orders
                          on Sale.OrID equals Order.OrID

                         join SaleDetail in context.T_SaleDetails
                         on Sale.SaID equals SaleDetail.SaID

                         join Product in context.M_Products
                         on SaleDetail.PrID equals Product.PrID

                         join OrDetail in context.T_OrderDetails
                         on Order.OrID equals OrDetail.OrID


                         where
                         Sale.SaFlag.Equals(0)

                         select new DispSaleListDTO
                         {
                             SaID = Sale.SaID,
                             SaDetailID = SaleDetail.SaDetailID,
                             OrID = Order.OrID,
                             SoName = SOffice.SoName,
                             EmName = Employee.EmName,
                             ClName = Client.ClName,
                             PrName=Product.PrName,
                             SaQuantity=SaleDetail.SaQuantity,
                             SaTotalPrice=OrDetail.OrTotalPrice.ToString(),
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispSaleDetailListDTO> SaleDetailGetData(int SaID)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from SaleDetail in context.T_SaleDetails
                         join Sale in context.T_Sale
                         on SaleDetail.SaID equals Sale.SaID

                         join Product in context.M_Products
                         on SaleDetail.SaID equals Product.PrID

                         where SaleDetail.SaID == (SaID)


                         select new DispSaleDetailListDTO
                         {
                             SaDetailID = SaleDetail.SaDetailID,
                             SaID = Sale.SaID,
                             PrName = Product.PrName,
                             SaQuantity = SaleDetail.SaQuantity,
                             SaTotalPrice = SaleDetail.SaTotalPrice.ToString(),
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;


        }
        public int GetSaID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Sale.Max(x => x.SaID);
        }

    }
}
