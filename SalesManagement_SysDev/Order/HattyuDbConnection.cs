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
        public List<DispHattyuDetailListDTO> HattyuGetData(string strClCharge)
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
                         where Hattyu.HaFlag.Equals(0)&&
                         Hattyu.WaWarehouseFlag.Equals(0)

                         select new DispHattyuDetailListDTO
                         {
                             HaID = Hattyu.HaID.ToString(),
                             HaDitailID=HattyuDetail.HaDetailID.ToString(),
                             MaName = Maker.MaName.ToString(),
                             EmName = Employee.EmName,
                             PrName= Product.PrName.ToString(),
                             HaQuantity=HattyuDetail.HaQuantity.ToString(),
                             HaDate=Hattyu.HaDate.ToString(),
                            
                           
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
