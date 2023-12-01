using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDBConnection
    {
        public List<DispSyukkoListDTO> SyukoGetData(string strName)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Syukko in context.T_Syukkos
                         join Employee in context.M_Employees
                         on Syukko.EmID equals Employee.EmID
                         join SyukkoDetail in context.T_SyukkoDetails
                         on Syukko.SyID equals SyukkoDetail.SyID
                         join Client in context.M_Clients
                         on Syukko.ClID equals Client.ClID
                         join SOffice in context.M_SalesOffices
                         on Syukko.SoID equals SOffice.SoID
                         join Order in context.T_Orders
                         on Syukko.OrID equals Order.OrID
                         join Product in context.M_Products
                         on SyukkoDetail.PrID equals Product.PrID
                         where Syukko.SyFlag.Equals(0) &&
                         Syukko.SyStateFlag.Equals(0)


                         select new DispSyukkoListDTO
                         {
                             SyID = Syukko.SyID.ToString(),
                             SyDetailID = SyukkoDetail.SyDetailID.ToString(),
                             EmName = Employee.EmName,
                             ClName = Client.ClName,
                             SoName = SOffice.SoName,
                             OrID = Order.OrID.ToString(),
                             PrName = Product.PrName,
                             SyQuantity = SyukkoDetail.SyQuantity,
                             SyDate = Syukko.ToString()
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