using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDBConnection
    {
        public List<GetSyukoListDTO> SyukoGetData(string strName)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Syukko in context.T_Syukkos
                         join Employee in context.M_Employees
                         on Syukko.EmID equals Employee.EmID
                         join Client in context.M_Clients
                         on Syukko.ClID equals Client.ClID
                         join SOffice in context.M_SalesOffices
                         on Syukko.SoID equals SOffice.SoID
                         join Order in context.T_Orders
                         on Syukko.OrID equals Order.OrID
                         where Syukko.SyFlag.Equals(0)&&
                         Syukko.SyStateFlag.Equals(0)
                         

                         select new GetSyukoListDTO
                         {
                             SyID = Syukko.SyID.ToString(),
                             SyDetailID = SyukkoDetail.ToString(),
                             EmName = Employee.EmName,
                             SoName = SOffice.SoName,
                             PoName = Position.PoName,
                             EmHiredate = Employee.EmHiredate.ToString(),
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