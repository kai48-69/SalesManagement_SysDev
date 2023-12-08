using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class SaleDbConnection
    {
        public int GetSaID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Sale.Max(x => x.SaID);
        }
    }
}
