using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ChumonDbConnection
    {
        public int GetChID()
        {
            var context =new SalesManagement_DevContext();
            return context.T_Chumons.Max(x => x.ChID);

        }

        public List<DispChumonDataListDTO> ChumonGetData(string strClCharge)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Chumon in context.T_Chumons

                         join SOffice in context.M_SalesOffices
                         on Chumon.SoID equals SOffice.SoID

                         join Employee in context.M_Employees
                         on Chumon.EmID equals Employee.EmID

                         join Client in context.M_Clients
                         on Chumon.ClID equals Client.ClID

                         join Order in context.T_OrderDetails
                         on Chumon.OrID equals Order.OrID

                         join Product in context.M_Products
                         on Chumon.PrName equals Product.PrName

                         join ChumonDate in context.T_Chumons
                         on Chumon.ChDate equals ChumonDate.ChDate

                         where
                         Chumon.ChStateFlag.Equals(0) &&
                         Chumon.ChFlag.Equals(0)

                         select new DispChumonDataListDTO
                         {
                             ChID = Chumon.ChID,
                             ChDetailID = Chumon.ChID,
                             SoName = SOffice.SoName,
                             EmName = Employee.EmName,
                             ClName = Client.ClName,
                             OrID = Order.OrID,
                             PrName = Product.PrName,
                             ChDate = Chumon.ChDate,
                         };
                return tb.ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

    }
}
