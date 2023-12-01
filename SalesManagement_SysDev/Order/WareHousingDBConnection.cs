using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.WarHousing
{
    internal class WareHousingDBConnection
    {
        public List<DispWareHousingListDTO> WareHousingGetData(string strClCharge)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from WareHousing in context.T_Warehousings
                         join WareHousingDetails in context.T_WarehousingDetails
                         on WareHousing.WaID equals WareHousingDetails.WaID
                         join Product in context.M_Products
                         on WareHousingDetails.PrID equals Product.PrID
                         where
                         WareHousing.WaFlag.Equals(0) &&
                         WareHousing.WaShelfFlag.Equals(0)

                         select new DispWareHousingListDTO
                         {
                             WaID = WareHousing.WaID.ToString(),
                             WaDetailID = WareHousingDetails.WaDetailID.ToString(),
                             PrName = Product.PrName,
                             WaQuantity = WareHousingDetails.WaQuantity.ToString(),

                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispWareHousingListDTO> GetWareHousingData(T_Warehousing selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from WareHousing in context.T_Warehousings
                         join WareHousingDetails in context.T_WarehousingDetails
                         on WareHousing.WaID equals WareHousingDetails.WaID
                         join Product in context.M_Products
                         on WareHousingDetails.PrID equals Product.PrID
                         where ((selectCondition.WaID == -1) ? true :
                         WareHousing.WaID == selectCondition.WaID) &&
                         ((selectCondition.EmID == -1) ? true :
                         WareHousing.EmID == selectCondition.EmID) &&
                        ((selectCondition.HaID == -1) ? true :
                         WareHousing.HaID == selectCondition.HaID) &&
                         WareHousing.WaFlag.Equals(0) &&
                         WareHousing.WaShelfFlag.Equals(0)

                         select new DispWareHousingListDTO
                         {
                             WaID = WareHousing.WaID,
                             WaDetailID = WareHousingDetails.WaDetailID,
                             HaID=WareHousing.HaID,
                             PrName = Product.PrName,
                             WaQuantity = WareHousingDetails.WaQuantity
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
