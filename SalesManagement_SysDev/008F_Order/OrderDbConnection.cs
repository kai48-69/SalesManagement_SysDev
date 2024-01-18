using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
                             OrDetailID = OrDetail.OrDetailID.ToString(),
                             SoName = SOffice.SoName,
                             EmName = Employee.EmName,
                             ClName = Client.ClName,
                             ClCharge = Order.ClCharge,
                             PrName = Product.PrName,
                             PrQuantity = OrDetail.OrQuantity.ToString(),
                             OrTotalPrice = OrDetail.OrTotalPrice.ToString(),
                             OrDate = Order.OrDate.ToString(),
                             EmID = Employee.EmID,
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispOrderDetailListDTO> OrderDetailGetData(int OrID)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from OrderDetail in context.T_OrderDetails
                         join Order in context.T_Orders
                         on OrderDetail.OrID equals Order.OrID
                         join Product in context.M_Products
                         on OrderDetail.PrID equals Product.PrID
                         where OrderDetail.OrID == (OrID)


                         select new DispOrderDetailListDTO
                         {
                             OrID = Order.OrID.ToString(),
                             OrDetailID = OrderDetail.OrDetailID.ToString(),
                             PrName = Product.PrName,
                             OrQuantity = OrderDetail.OrQuantity,
                             OrTotalPrice = OrderDetail.OrTotalPrice.ToString(),
                             PrID = Product.PrID,
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
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
                Clname = context.M_Clients.Where(x => x.ClName != null && x.ClFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Clname;
        }

        public int GetOrID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Orders.Max(x => x.OrID);
        }

        public int GetQuantity(int PrID)
        {
            var context = new SalesManagement_DevContext();
            int OrID = GetOrID();
            int Quantity = 0;
            bool flg1 = context.T_OrderDetails.Any(x => x.OrID == OrID);
            if (flg1)
            {
                List<DispOrderDetailListDTO> tb = OrderDetailGetData(OrID);
                bool flg = tb.Any(x => x.PrID == PrID);
                if (flg)
                {
                    var OrD = tb.Single(x => x.PrID == PrID);
                    Quantity = OrD.OrQuantity;
                    return Quantity;

                }

                return -1;
            }
            return -1;
        }

            public List<DispOrderListDTO> GetOrderData(T_Order selectCondition)
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

                             where Order.ClCharge.Contains(selectCondition.ClCharge) &&
                             ((selectCondition.OrID == -1) ? true :
                             Order.OrID == selectCondition.OrID) &&
                             ((selectCondition.EmID == -1) ? true :
                             Order.EmID == selectCondition.EmID) &&
                            ((selectCondition.SoID == -1) ? true :
                            Order.SoID == selectCondition.SoID) &&
                            ((selectCondition.ClID == -1) ? true :
                            (Order.ClID == selectCondition.ClID)) &&
                             Order.OrFlag.Equals(0) &&
                             Order.OrStateFlag.Equals(0)

                             select new DispOrderListDTO
                             {
                                 OrID = Order.OrID.ToString(),
                                 OrDetailID = OrDetail.OrDetailID.ToString(),
                                 SoName = SOffice.SoName,
                                 EmName = Employee.EmName,
                                 ClName = Client.ClName,
                                 ClCharge = Order.ClCharge,
                                 PrName = Product.PrName,
                                 PrQuantity = OrDetail.OrQuantity.ToString(),
                                 OrTotalPrice = OrDetail.OrTotalPrice.ToString(),
                                 OrDate = Order.OrDate.ToString(),
                             };

                    return tb.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }

            public List<GetOrderDataDTO> SetOrderData(T_Order selectCondition)
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
                             where Order.OrID.Equals(selectCondition.OrID) &&
                             Order.OrFlag.Equals(0) &&
                             Order.OrStateFlag.Equals(0)

                             select new GetOrderDataDTO
                             {
                                 OrID = Order.OrID,
                                 SoID = SOffice.SoID,
                                 ClID = Client.ClID,
                                 OrDetailID = OrDetail.OrDetailID,
                                 PrID = Product.PrID,
                                 PrQuantity = OrDetail.OrQuantity,
                                 OrDate = Order.OrDate,
                             };

                    return tb.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }


        }
    }
