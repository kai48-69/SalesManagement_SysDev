using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class EmployeeDataAccess
    {
        //IDの存在チェック
        public bool CheckCascadeEmployeesID(int EmID)
        {
            var context = new SalesManagement_DevContext();
            bool flg = context.M_Employees.Any(x => x.EmID == EmID);
            return flg;
        }
        //PWチェック
        public bool CheckCascadeEmployeesPW(string EmPassword, int SyainID)
        {
            var context = new SalesManagement_DevContext();
            var syain = context.M_Employees.Single(x => x.EmID == SyainID);
            if (syain.EmPassword == EmPassword)
            {
                return true;
            }
            return false;
        }
        //役職IDの取得
        public bool GetPolID(int EmID,out int PolID)
        {
            var context= new SalesManagement_DevContext();
            PolID = 0;
            bool flg = context.M_Employees.Any(x => x.EmID == EmID);

            if (flg)
            {
                var Emp = context.M_Employees.Single(x => x.EmID == EmID);
                PolID = Emp.PoID;
            }
            return true;
        }

        //社員名の取得
        public bool GetEmName(int EmID,out string EmName)
        {
            var context=new SalesManagement_DevContext();
            EmName = "";
            bool flg = context.M_Employees.Any(x => x.EmID == EmID);

            if (flg)
            {
                var Emp=context.M_Employees.Single(x=> x.EmID == EmID);
                EmName = Emp.EmName;
            }
            return true;
        }
    }
}
