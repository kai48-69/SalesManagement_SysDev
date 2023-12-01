using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Order
{
    internal class WareHousingDataAccess
    {
        public bool AddWareHousingData(T_Warehousing regWh)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Warehousings.Add(regWh);
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

        public bool AddWareHousingDetailData(T_WarehousingDetail regWhD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_WarehousingDetails.Add(regWhD);
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
    }
}
