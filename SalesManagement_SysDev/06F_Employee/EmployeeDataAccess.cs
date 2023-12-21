using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class EmployeeDataAccess
    {
       

        public bool AddEmployeeData(M_Employee regEmp)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Employees.Add(regEmp);
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

        public bool UpdateEmployeeData(M_Employee updEmp)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Employee = context.M_Employees.First(x => x.EmID == updEmp.EmID);
                Employee.SoID = updEmp.SoID+1;
                Employee.PoID = updEmp.PoID+1;
                Employee.EmName = updEmp.EmName;
                Employee.EmPhone = updEmp.EmPhone;
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

        public bool HideEmployeeData(M_Employee hidEmp)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Employee = context.M_Employees.Single(x => x.EmID == hidEmp.EmID);
                Employee.EmFlag = hidEmp.EmFlag;
                Employee.EmHidden= hidEmp.EmHidden;

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

        public bool RegistrationPW(M_Employee RegPW)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Employee = context.M_Employees.First(x => x.EmID == RegPW.EmID);
                Employee.EmPassword = RegPW.EmPassword;
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

        public bool CheckCascadeEmployee(int EmID)
        {
            var context = new SalesManagement_DevContext();
            bool flg = context.T_Orders.Any(x => x.EmID == EmID);

            return flg;
        }

    }
}
