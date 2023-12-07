using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class StockDataAccess
    {
        public bool AddStockData(T_Stock regSt)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Stocks.Add(regSt);
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

        public bool UpdateStockData(T_Stock updSt)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Client = context.T_Stocks.First(x => x.StID == updSt.StID);
                Client.StID = updSt.StID;
                Client.StQuantity = updSt.StQuantity;

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
