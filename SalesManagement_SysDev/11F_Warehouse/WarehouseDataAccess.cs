using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class WarehouseDataAccess
    {
        public bool AddWarehouseData(T_Warehousing Warehouse)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Warehousings.Add(Warehouse);
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

        public bool AddChumonDetailData(T_WarehousingDetail WDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_WarehousingDetails.Add(WDetail);
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

        public bool HideWarehouseData(T_Warehousing hidWa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Warehouse = context.T_Warehousings.Single(x => x.WaID == hidWa.WaID);
                Warehouse.WaFlag = hidWa.WaFlag;
                Warehouse.WaHidden = hidWa.WaHidden;

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

        public bool UpdWarehouseFlg(T_Warehousing UpdWaFlag)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Warehouse = context.T_Warehousings.Single(x => x.WaID == UpdWaFlag.WaID);
                Warehouse.WaShelfFlag = UpdWaFlag.WaShelfFlag;

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
