using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ShipDbConnection
    {
        public List<DispShipListDTO> ShipGetData(string strClCharge)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Ship in context.T_Shipments
                         join SOffice in context.M_SalesOffices
                         on Ship.SoID equals SOffice.SoID
                         join Employee in context.M_Employees
                         on Ship.EmID equals Employee.EmID
                         join Client in context.M_Clients
                         on Ship.ClID equals Client.ClID
                         join ShDetail in context.T_ShipmentDetails
                         on Ship.ShID equals ShDetail.ShID
                         join Product in context.M_Products
                         on ShDetail.PrID equals Product.PrID
                         join Order in context.T_Orders 
                         on Ship.OrID equals Order.OrID
                         where Order.ClCharge.Contains(strClCharge) &&
                         Ship.ShFlag.Equals(0) &&
                         Ship.ShStateFlag.Equals(0)

                         select new DispShipListDTO
                         {
                            ShID = Ship.ShID.ToString(),
                            ShDetailID = ShDetail.ShDetailID.ToString(),
                            ClName = Client.ClName.ToString(),
                            EmName = Employee.EmName.ToString(),
                            SoName = SOffice.SoName.ToString(),
                            OrID = Order.OrID.ToString(),
                            ShFinishDate = Ship.ShFinishDate.ToString(),    
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispShipListDTO> GetShipData(T_Shipment selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Ship in context.T_Shipments
                         join SOffice in context.M_SalesOffices
                         on Ship.SoID equals SOffice.SoID
                         join Employee in context.M_Employees
                         on Ship.EmID equals Employee.EmID
                         join Client in context.M_Clients
                         on Ship.ClID equals Client.ClID
                         join ShDetail in context.T_ShipmentDetails
                         on Ship.ShID equals ShDetail.ShID
                         join Product in context.M_Products
                         on ShDetail.PrID equals Product.PrID
                         join Order in context.T_Orders
                         on Ship.OrID equals Order.OrID
                         where ((selectCondition.ShID == -1) ? true :
                         Ship.ShID == selectCondition.ShID) &&
                         ((selectCondition.SoID == -1) ? true :
                         Ship.SoID == selectCondition.SoID) &&
                        ((selectCondition.ClID == -1) ? true :
                        Ship.ClID == selectCondition.ClID) &&
                        ((selectCondition.EmID == -1) ? true :
                        (Ship.EmID == selectCondition.EmID)) &&
                        Ship.ShFlag.Equals(0) &&
                         Ship.ShStateFlag.Equals(0)

                         select new DispShipListDTO
                         {
                             ShID = Ship.ShID.ToString(),
                             ShDetailID = ShDetail.ShDetailID.ToString(),
                             ClName = Client.ClName.ToString(),
                             EmName = Employee.EmName.ToString(),
                             SoName = SOffice.SoName.ToString(),
                             OrID = Order.OrID.ToString(),
                             ShFinishDate = Ship.ShFinishDate.ToString(),
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


       

        public List<GetSyukkaDataDTO> SetSyukkaData(T_Shipment selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Ship in context.T_Shipments
                         join SOffice in context.M_SalesOffices
                         on Ship.SoID equals SOffice.SoID
                         join Employee in context.M_Employees
                         on Ship.EmID equals Employee.EmID
                         join Client in context.M_Clients
                         on Ship.ClID equals Client.ClID
                         join ShDetail in context.T_ShipmentDetails
                         on Ship.ShID equals ShDetail.ShID
                         join Product in context.M_Products
                         on ShDetail.PrID equals Product.PrID
                         join Order in context.T_Orders
                         on Ship.OrID equals Order.OrID
                         where Ship.ShID.Equals(selectCondition.ShID) &&
                         Ship.ShFlag.Equals(0) &&
                         Ship.ShStateFlag.Equals(0)

                         select new GetSyukkaDataDTO
                         {
                             ShID = Ship.ShID,
                             SoID = SOffice.SoID,
                             ClID = Client.ClID,
                             ShDetailID = ShDetail.ShDetailID,
                             PrID = Product.PrID,
                             ShQuantity = ShDetail.ShQuantity,
                             OrID = Ship.OrID,
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public int GetShID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Shipments.Max(x => x.ShID);
        }
    }
}
