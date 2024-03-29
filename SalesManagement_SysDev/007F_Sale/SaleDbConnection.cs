﻿using System;
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
                             SaTotalPrice=SaleDetail.SaTotalPrice,
                             SyainID=Employee.EmID
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }




        public List<DispSaleListDTO> GetSaleData(SaleselectCondition selectCondition)
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

                         where ((selectCondition.SaID == -1) ? true :
                         Sale.SaID == selectCondition.SaID) &&
                         ((selectCondition.OrID == -1) ? true :
                         Sale.OrID == selectCondition.OrID) &&
                        ((selectCondition.SoID == -1) ? true :
                        Sale.SoID == selectCondition.SoID) &&
                        ((selectCondition.EmID == -1) ? true :
                        Sale.EmID == selectCondition.EmID) &&
                        ((selectCondition.ClID == -1) ? true :
                        Sale.ClID == selectCondition.ClID) &&
                        ((selectCondition.PrID == -1) ? true :
                        SaleDetail.PrID == selectCondition.PrID) &&
                       Sale.SaFlag.Equals(0)


                         select new DispSaleListDTO
                         {
                             SaID = Sale.SaID,
                             SaDetailID = SaleDetail.SaDetailID,
                             OrID = Order.OrID,
                             SoName = SOffice.SoName,
                             EmName = Employee.EmName,
                             ClName = Client.ClName,
                             PrName = Product.PrName,
                             SaQuantity = SaleDetail.SaQuantity,
                             SaTotalPrice = SaleDetail.SaTotalPrice,
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
