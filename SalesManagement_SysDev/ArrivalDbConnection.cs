using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SalesManagement_SysDev
{
    internal class ArrivalDbConnection
    {
        public List<DispArrivalListDTO> ArrivalGetData(string strClCharge)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Arrival in context.T_Arrivals
                         join SOffice in context.M_SalesOffices
                         on Arrival.SoID equals SOffice.SoID
                         join Employee in context.M_Employees
                         on Arrival.EmID equals Employee.EmID
                         join Client in context.M_Clients
                         on Arrival.ClID equals Client.ClID
                         join ArDetail in context.T_ArrivalDetails
                         on Arrival.ArID equals ArDetail.ArID
                         join Product in context.M_Products
                         on ArDetail.PrID equals Product.PrID
                         join Order in context.T_Orders
                         on Arrival.OrID equals Order.OrID
                         where Order.ClCharge.Contains(strClCharge) &&
                         Arrival.ArFlag.Equals(0) &&
                         Arrival.ArStateFlag.Equals(0)

                         select new DispArrivalListDTO
                         {
                          ArID=Arrival.ArID.ToString(),
                          ArDetailID=ArDetail.ArDetailID.ToString(),
                          SoName=SOffice.SoName,
                          EmName=Employee.EmName,
                          ClName=Client.ClName,
                          PrName=Product.PrName,
                          ArQuantity=ArDetail.ArQuantity.ToString(),
                          ArDate=Arrival.ArDate.ToString(), 

                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispArrivalListDTO> GetArrivalData(T_Arrival selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Arrival in context.T_Arrivals
                         join SOffice in context.M_SalesOffices
                         on Arrival.SoID equals SOffice.SoID
                         join Employee in context.M_Employees
                         on Arrival.EmID equals Employee.EmID
                         join Client in context.M_Clients
                         on Arrival.ClID equals Client.ClID
                         join ArDetail in context.T_ArrivalDetails
                         on Arrival.ArID equals ArDetail.ArID
                         join Product in context.M_Products
                         on ArDetail.PrID equals Product.PrID
                         join Order in context.T_Orders
                         on Arrival.OrID equals Order.OrID
                         where((selectCondition.ArID == -1) ? true :
                         Arrival.ArID == selectCondition.ArID) &&
                         ((selectCondition.EmID == -1) ? true :
                         Arrival.EmID == selectCondition.EmID) &&
                        ((selectCondition.SoID == -1) ? true :
                        Arrival.SoID == selectCondition.SoID) &&
                        ((selectCondition.ClID == -1) ? true :
                        (Arrival.ClID == selectCondition.ClID)) &&
                         Arrival.ArFlag.Equals(0) &&
                         Arrival.ArStateFlag.Equals(0)

                         select new DispArrivalListDTO
                         {
                             ArID = Arrival.ArID.ToString(),
                             ArDetailID = ArDetail.ArDetailID.ToString(),
                             SoName = SOffice.SoName,
                             EmName = Employee.EmName,
                             ClName = Client.ClName,
                             PrName = Product.PrName,
                             ArQuantity = ArDetail.ArQuantity.ToString(),
                             ArDate = Arrival.ArDate.ToString(),
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public bool HideOrderData(T_Arrival hidAr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Arder = context.T_Arrivals.Single(x => x.ArID == hidAr.ArID);
                Arder.ArFlag = hidAr.ArFlag;
                Arder.ArHidden = hidAr.ArHidden;

                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



    }
}
