using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class EmployeeDbConnection
    {
        public List<DispEmployeeListDTO> EmployeeGetData(string strName)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Employee in context.M_Employees
                         join SOffice in context.M_SalesOffices
                         on Employee.SoID equals SOffice.SoID
                         join Position in context.M_Positions
                         on Employee.PoID equals Position.PoID
                         where Employee.EmName.Contains(strName) &&
                         Employee.EmFlag.Equals(0)

                         select new DispEmployeeListDTO
                         {
                             EmID = Employee.EmID.ToString(),
                             EmName = Employee.EmName,
                             SoName = SOffice.SoName,
                             PoName = Position.PoName,
                             EmHiredate = Employee.EmHiredate.ToString(),
                             EmPhone = Employee.EmPhone,
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }
        public List<M_SalesOffice> GetSoNameDspData()
        {
            List<M_SalesOffice> SoName = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                SoName = context.M_SalesOffices.Where(x => x.SoName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SoName;
        }

        public List<M_Position> GetPoNameDspData()
        {
            List<M_Position> PoName = new List<M_Position>();
            try
            {
                var context = new SalesManagement_DevContext();
                PoName = context.M_Positions.Where(x => x.PoName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return PoName;
        }

        public List<DispEmployeeListDTO> GetEmployeeData(M_Employee selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Employee in context.M_Employees
                         join SOffice in context.M_SalesOffices
                         on Employee.SoID equals SOffice.SoID
                         join Position in context.M_Positions
                         on Employee.PoID equals Position.PoID
                         where
                         (selectCondition.EmID == -1 ? true :
                         Employee.EmID.ToString().Contains(selectCondition.EmID.ToString())) &&
                        ((selectCondition.SoID == -1) ? true :
                        Employee.SoID == selectCondition.SoID) &&
                        ((selectCondition.PoID == -1) ? true :
                        (Employee.PoID == selectCondition.PoID)) &&
                         Employee.EmFlag.Equals(0)

                         select new DispEmployeeListDTO
                         {
                             EmID = Employee.EmID.ToString(),
                             EmName = Employee.EmName,
                             SoName = SOffice.SoName,
                             PoName = Position.PoName,
                             EmPhone = Employee.EmPhone,
                             EmHiredate = Employee.EmHiredate.ToString(),
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        //IDの存在チェック
        public int CheckCascadeEmployeesID(int EmID)
        {
            var context = new SalesManagement_DevContext();
            var Syain = context.M_Employees.SingleOrDefault(x => x.EmID == EmID);
            if (Syain != null)
            {
                int SyainID = Syain.EmID;
                if (Syain.EmFlag == 0)
                {
                    return SyainID;
                }
                return -1;
            }
            else
            { 
                return -1; 
            }

        }

        //PWチェック
        public bool CheckEmployeesPW(string EmPassword, int SyainID)
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
        public bool GetPoID(int EmID, out int PolID)
        {
            var context = new SalesManagement_DevContext();
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
        public string GetEmName(int EmID)
        {
            var context = new SalesManagement_DevContext();

            var Emp = context.M_Employees.Single(x => x.EmID == EmID);
            string EmName = Emp.EmName;
            if (Emp.EmFlag == 0)
            {
                return EmName;
            }
            return "";

        }

        public List<SetLoginDataDTO> SetLoginData(M_Employee selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Employee in context.M_Employees
                         join Soffice in context.M_SalesOffices
                         on Employee.SoID equals Soffice.SoID
                         where Employee.EmID.Equals(selectCondition.EmID) &&
                         Employee.EmFlag.Equals(0)

                         select new SetLoginDataDTO
                         {
                             EmID = Employee.EmID,
                             EmName = Employee.EmName,
                             SoName = Soffice.SoName.ToString(),
                             PoID = Employee.PoID,

                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

    }
}
