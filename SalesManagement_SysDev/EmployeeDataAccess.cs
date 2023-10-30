using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class EmployeeDataAccess
    {
        public bool CheckCascadeEmployeesID(int EmID)
        {
            var context = new SalesManagement_DevContext();
            bool flg = context.M_Employees.Any(x => x.EmID==EmID);
            return flg;
        }
        public bool CheckCascadeEmployeesPW(string EmPassword)
        {
            var context= new SalesManagement_DevContext();
            bool flg = context.M_Employees.Any(x => x.EmPassword == EmPassword);
            return flg;
        }
    }
}
