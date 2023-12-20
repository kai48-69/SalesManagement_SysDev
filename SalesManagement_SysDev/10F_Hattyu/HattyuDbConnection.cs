using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Order
{
    internal class HattyuDbConnection
    {
        public List<DispHattyuListDTO> HattyuGetData(string strClCharge)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Hattyu in context.T_Hattyus
                         join HattyuDetail in context.T_HattyuDetails
                         on Hattyu.HaID equals HattyuDetail.HaID
                         join Maker in context.M_Makers
                         on Hattyu.MaID equals Maker.MaID
                         join Employee in context.M_Employees
                         on Hattyu.EmID equals Employee.EmID
                         join Product in context.M_Products
                         on HattyuDetail.PrID equals Product.PrID
                         where Hattyu.HaFlag.Equals(0) &&
                         Hattyu.WaWarehouseFlag.Equals(0)

                         select new DispHattyuListDTO
                         {
                             HaID = Hattyu.HaID,
                             HaDetailID = HattyuDetail.HaDetailID,
                             MaName = Maker.MaName.ToString(),
                             EmName = Employee.EmName,
                             PrName = Product.PrName.ToString(),
                             HaQuantity = HattyuDetail.HaQuantity,
                             HaDate = Hattyu.HaDate.ToString(),
                             EmID= Employee.EmID,
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public int GetHaID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Hattyus.Max(x => x.HaID);
        }

        public List<DispHattyuDetailListDTO> HattyuDetailGetData(int HaID)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from HattyuDetail in context.T_HattyuDetails
                         join Hattyu in context.T_Hattyus
                         on HattyuDetail.HaID equals Hattyu.HaID
                         join Product in context.M_Products
                         on HattyuDetail.PrID equals Product.PrID
                         where HattyuDetail.HaID == (HaID)


                         select new DispHattyuDetailListDTO
                         {
                             HaDetailID = HattyuDetail.HaDetailID.ToString(),
                             HaID = Hattyu.HaID.ToString(),
                             PrName = Product.PrName,
                             HaQuantity = HattyuDetail.HaQuantity.ToString(),

                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispHattyuListDTO> GetOrderData(T_Hattyu selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Hattyu in context.T_Hattyus
                         join HattyuDetail in context.T_HattyuDetails
                         on Hattyu.HaID equals HattyuDetail.HaID
                         join Maker in context.M_Makers
                         on Hattyu.MaID equals Maker.MaID
                         join Employee in context.M_Employees
                         on Hattyu.EmID equals Employee.EmID
                         join Product in context.M_Products
                         on HattyuDetail.PrID equals Product.PrID
                         where ((selectCondition.HaID == -1) ? true :
                         Hattyu.HaID == selectCondition.HaID) &&
                         ((selectCondition.EmID == -1) ? true :
                         Hattyu.EmID == selectCondition.EmID) &&
                        ((selectCondition.MaID == -1) ? true :
                        Hattyu.MaID == selectCondition.MaID) &&
                        Hattyu.HaFlag.Equals(0) &&
                         Hattyu.WaWarehouseFlag.Equals(0)


                         select new DispHattyuListDTO
                         {
                             HaID = Hattyu.HaID,
                             HaDetailID = HattyuDetail.HaDetailID,
                             MaName = Maker.MaName.ToString(),
                             EmName = Employee.EmName,
                             PrName = Product.PrName.ToString(),
                             HaQuantity = HattyuDetail.HaQuantity,
                             HaDate = Hattyu.HaDate.ToString(),
                             EmID = Employee.EmID,
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public List<GetHattyuDataDTO> SetHattyuData(T_Hattyu selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Hattyu in context.T_Hattyus
                         join HattyuDetail in context.T_HattyuDetails
                         on Hattyu.HaID equals HattyuDetail.HaID
                         join Maker in context.M_Makers
                         on Hattyu.MaID equals Maker.MaID
                         join Employee in context.M_Employees
                         on Hattyu.EmID equals Employee.EmID
                         join Product in context.M_Products
                         on HattyuDetail.PrID equals Product.PrID
                         where Hattyu.HaID.Equals(selectCondition.HaID) &&
                         Hattyu.HaFlag.Equals(0) &&
                         Hattyu.WaWarehouseFlag.Equals(0)

                         select new GetHattyuDataDTO
                         {
                             HaID = Hattyu.HaID.ToString(),
                             PrID = Product.PrID.ToString(),
                             HaQuantity = HattyuDetail.HaQuantity.ToString()
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public int GetHattyuID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Hattyus.Max(x => x.HaID);

        }

    }
}
