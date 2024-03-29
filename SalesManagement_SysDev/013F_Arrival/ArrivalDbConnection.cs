﻿using System;
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
        public List<DispArrivalListDTO> ArrivalGetData()
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Arrival in context.T_Arrivals
                         join SOffice in context.M_SalesOffices
                         on Arrival.SoID equals SOffice.SoID
                         join Client in context.M_Clients
                         on Arrival.ClID equals Client.ClID
                         join ArDetail in context.T_ArrivalDetails
                         on Arrival.ArID equals ArDetail.ArID
                         join Product in context.M_Products
                         on ArDetail.PrID equals Product.PrID
                         join Order in context.T_Orders
                         on Arrival.OrID equals Order.OrID
                         where
                         Arrival.ArFlag.Equals(0) &&
                         Arrival.ArStateFlag.Equals(0)

                         select new DispArrivalListDTO
                         {
                             ArID = Arrival.ArID,
                             ArDetailID = ArDetail.ArDetailID,
                             SoName = SOffice.SoName,
                             ClName = Client.ClName,
                             OrID = Order.OrID,
                          PrName=Product.PrName,
                          ArQuantity=ArDetail.ArQuantity,
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
                         ((selectCondition.OrID == -1) ? true :
                         Arrival.OrID == selectCondition.OrID) &&
                        ((selectCondition.SoID == -1) ? true :
                        Arrival.SoID == selectCondition.SoID) &&
                        ((selectCondition.ClID == -1) ? true :
                        (Arrival.ClID == selectCondition.ClID)) &&
                         Arrival.ArFlag.Equals(0) &&
                         Arrival.ArStateFlag.Equals(0)

                         select new DispArrivalListDTO
                         {
                             ArID = Arrival.ArID,
                             ArDetailID = ArDetail.ArDetailID,
                             SoName = SOffice.SoName,
                             OrID=Arrival.OrID,
                             ClName = Client.ClName,
                             PrName = Product.PrName,
                             ArQuantity = ArDetail.ArQuantity,
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        
       public int GetArID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Arrivals.Max(x => x.ArID);
        }

        public List<GetNyukaDataDTO> SetNyukaData(T_Arrival selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Arrival in context.T_Arrivals
                         join SOffice in context.M_SalesOffices
                         on Arrival.SoID equals SOffice.SoID
                         join Client in context.M_Clients
                         on Arrival.ClID equals Client.ClID
                         join ArDetail in context.T_ArrivalDetails
                         on Arrival.ArID equals ArDetail.ArID
                         join Product in context.M_Products
                         on ArDetail.PrID equals Product.PrID
                         join Order in context.T_Orders
                         on Arrival.OrID equals Order.OrID
                         where Arrival.ArID.Equals(selectCondition.ArID) &&
                         Arrival.ArFlag.Equals(0) &&
                         Arrival.ArStateFlag.Equals(0)

                         select new GetNyukaDataDTO
                         {
                             ArID = Arrival.ArID,
                             SoID = SOffice.SoID,
                             ClID = Client.ClID,
                             ArDetailID = ArDetail.ArDetailID,
                             PrID = Product.PrID,
                             ArQuantity = ArDetail.ArQuantity,
                             OrID = Arrival.OrID,
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
