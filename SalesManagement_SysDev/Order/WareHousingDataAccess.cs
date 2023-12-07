using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Order
{
    internal class WarehouseDataAccess
    {
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
    }
}
