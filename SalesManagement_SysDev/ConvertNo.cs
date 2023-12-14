using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class ConvertNo
    {
        public string SetPhoneOrFaxFormat(string[] D )
        {
            string No = string.Format(D[0] + "-" + D[1] + "-" + D[2]);
            
            return No;
        }
    }
}
