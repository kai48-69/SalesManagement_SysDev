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
        public List<DispEmployeeListDTO> EmployeeGetData(string strName, int flg)
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
                              = Product.PrName,
                             Price = Product.Price,
                             ScText = SmallClassifications.ScName,
                             PrSafetyStock = Product.PrSafetyStock,
                             PrColor = Product.PrColor,
                             PrModelNumber = Product.PrModelNumber,
                             PrReleaseDate = Product.PrReleaseDate,
                             PrHidden = Product.PrHidden,

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
        public List<M_SalesOffice>GetSoNameDspData()
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
    }
}
