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
            var context = new SalesManagement_DevContext();
            return context.T_Chumons.Max(x => x.ChID);
        }

        public List<DispChumonListDTO> ChumonGetData()
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Chumon in context.T_Chumons
                         join ChumonDetail in context.T_ChumonDetails
                         on Chumon.ChID equals ChumonDetail.ChID
                         join SOffice in context.M_SalesOffices
                         on Chumon.SoID equals SOffice.SoID
                         join Client in context.M_Clients
                         on Chumon.ClID equals Client.ClID
                         join Order in context.T_Orders
                         on Chumon.OrID equals Order.OrID
                         join Product in context.M_Products
                         on ChumonDetail.PrID equals Product.PrID
                         where Chumon.ChFlag.Equals(0) &&
                         Chumon.ChStateFlag.Equals(0) &&
                         Chumon.EmID==null

                         select new DispChumonListDTO
                         {
                             ChID = Chumon.ChID,
                             ChDID = ChumonDetail.ChDetailID,
                             SoName = SOffice.SoName,
                             ClName = Client.ClName,
                             OrID = Order.OrID,
                             PrName = Product.PrName,
                             ChQuantity = ChumonDetail.ChQuantity,
                         
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispChumonListDTO> GetChumonData(T_Chumon selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Chumon in context.T_Chumons
                         join ChumonDetail in context.T_ChumonDetails
                         on Chumon.ChID equals ChumonDetail.ChID
                         join SOffice in context.M_SalesOffices
                         on Chumon.SoID equals SOffice.SoID
                         join Client in context.M_Clients
                         on Chumon.ClID equals Client.ClID
                         join Order in context.T_Orders
                         on Chumon.OrID equals Order.OrID
                         join Product in context.M_Products
                         on ChumonDetail.PrID equals Product.PrID
                         where
                        ((selectCondition.SoID == -1) ? true :
                        Chumon.SoID == selectCondition.SoID) &&
                        ((selectCondition.ClID == -1) ? true :
                        (Chumon.ClID == selectCondition.ClID)) &&
                        ((selectCondition.ChID == -1) ? true :
                        (Chumon.ChID == selectCondition.ChID)) &&
                         Chumon.ChFlag.Equals(0) &&
                         Chumon.ChStateFlag.Equals(0)


                         select new DispChumonListDTO
                         {
                             ChID = Chumon.ChID,
                             ChDID = ChumonDetail.ChDetailID,
                             SoName = SOffice.SoName,
                             ClName = Client.ClName,
                             OrID = Order.OrID,
                             PrName = Product.PrName,
                             ChQuantity = ChumonDetail.ChQuantity,
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public List<GetChumonDataDTO> SetChumonData(T_Chumon selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Chumon in context.T_Chumons
                         join ChumonDetail in context.T_ChumonDetails
                         on Chumon.ChID equals ChumonDetail.ChID
                         join SOffice in context.M_SalesOffices
                         on Chumon.SoID equals SOffice.SoID
                         join Client in context.M_Clients
                         on Chumon.ClID equals Client.ClID
                         join Order in context.T_Orders
                         on Chumon.OrID equals Order.OrID
                         join Product in context.M_Products
                         on ChumonDetail.PrID equals Product.PrID
                         where Chumon.ChID.Equals(selectCondition.ChID) &&
                         Chumon.ChFlag.Equals(0) &&
                         Chumon.ChStateFlag.Equals(0)

                         select new GetChumonDataDTO
                         {
                             ChID = Chumon.ChID,
                             SoID = SOffice.SoID,
                             ClID = Client.ClID,
                             ChDetailID = ChumonDetail.ChDetailID,
                             PrID = Product.PrID,
                             ChQuantity = ChumonDetail.ChQuantity,
                             OrID=Chumon.OrID,
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
