using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class WarehouseDbConnection
    {
        public int GetWaID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Warehousings.Max(x => x.WaID);
        }

        public List<DispWarehousingListDTO> WareHousingGetData()
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

                         select new DispWarehousingListDTO
                         {
                             HaID = WareHousing.HaID,
                             WaID = WareHousing.WaID,
                             WaDetailID = WareHousingDetails.WaDetailID,
                             PrName = Product.PrName,
                             WaQuantity = WareHousingDetails.WaQuantity,

                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispWarehousingListDTO> GetWareHousingData(T_Warehousing selectCondition)
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

                         select new DispWarehousingListDTO
                         {
                             WaID = WareHousing.WaID,
                             WaDetailID = WareHousingDetails.WaDetailID,
                             HaID = WareHousing.HaID,
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

        public List<GetNyukoDataDTO> SetNyukoData(T_Warehousing selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Warehouse in context.T_Warehousings
                         join WarehouseD in context.T_WarehousingDetails
                         on Warehouse.WaID equals WarehouseD.WaID
                         where WarehouseD.WaID.Equals(selectCondition.WaID)
                       

                         select new GetNyukoDataDTO
                         {
                           PrID=WarehouseD.PrID,
                           WaQuantity=WarehouseD.WaQuantity
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
