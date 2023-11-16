using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OrderDbConnection
    {
        public List<DispOrderListDTO> OrderGetData(string strClCharge)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Order in context.T_Orders
                         join SOffice in context.M_SalesOffices
                         on Order.SoID equals SOffice.SoID
                         join Employee in context.M_Employees
                         on Order.EmID equals Employee.EmID
                         join Client in context.M_Clients
                         on Order.ClID equals Client.ClID
                         join OrDetail in context.T_OrderDetails
                         on Order.OrID equals OrDetail.OrID
                         join Product in context.M_Products
                         on OrDetail.PrID equals Product.PrID
                         where Order.ClCharge.Contains(strClCharge) &&
                         Order.OrFlag.Equals(0) &&
                         Order.OrStateFlag.Equals(0)

                         select new DispOrderListDTO
                         {
                             OrID = Order.OrID.ToString(),
                             SoName = SOffice.SoName,
                             EmName = Employee.EmName,
                             ClName = Client.ClName,
                             ClCharge=Order.ClCharge,
                             PrName=Product.PrName,
                             PrQuantity=OrDetail.OrQuantity.ToString(),
                             OrTotalPrice=OrDetail.OrTotalPrice.ToString(),
                             OrDate=Order.OrDate.ToString(),
                             OrHidden=Order.OrHidden,
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("在庫データ取得時に例外エラーが発生しました", "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<M_Client> GetClientNameDspData()
        {
            List<M_Client> Clname = new List<M_Client>();
            try
            {
                var context = new SalesManagement_DevContext();
                Clname = context.M_Clients.Where(x => x.ClName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Clname;
        }

    }
}
