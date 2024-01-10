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
        public bool AddStockData(T_Stock regSto)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Stocks.Add(regSto);
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
                var Stock = context.T_Stocks.Single(x => x.PrID == updSt.PrID);
                Stock.StQuantity = updSt.StQuantity;

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

        public bool HideStockData(T_Stock hidSt)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Stock = context.T_Stocks.Single(x => x.PrID == hidSt.PrID);
                Stock.StFlag = hidSt.StFlag;
           
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
