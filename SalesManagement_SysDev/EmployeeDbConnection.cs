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
                             EmHidden = Employee.EmHidden,
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("在庫データ取得時に例外エラーが発生しました", "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                         where Employee.EmPhone.Contains(selectCondition.EmPhone) &&

                         ((selectCondition.EmID == -1) ? true :
                         Employee.EmID == selectCondition.EmID) &&
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
                             EmHiredate=Employee.EmHiredate.ToString(),
                             EmHidden = Employee.EmHidden,
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
