using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class ChumonDbConnection
    {
        public int GetChID()
        {
            var context = new SalesManagement_DevContext();
            return context.T_Chumons.Max(x => x.ChID);
        }
    }
}
