using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class WarehouseDbConnection
    {
        public int GetWaID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Warehousings.Max(x => x.WaID);
        }
    }
}
