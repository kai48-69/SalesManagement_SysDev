using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SalesManagement_SysDev
{
    internal class StockDbConnection
    {
        public List<DispStockListDTO> StockGetData()
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Stock in context.T_Stocks
                         join Product in context.M_Products
                         on Stock.PrID equals Product.PrID
                         where Stock.StFlag.Equals(0)


                         select new DispStockListDTO
                         {
                             StID = Stock.StID,
                             PrName = Product.PrName,
                             StQuantity = Stock.StQuantity,
                             SStock=Product.PrSafetyStock,

                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispStockListDTO> StockGetMinusData()
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Stock in context.T_Stocks
                         join Product in context.M_Products
                         on Stock.PrID equals Product.PrID
                         where Stock.StFlag.Equals(0) &&
                         Stock.StQuantity - Product.PrSafetyStock < 0


                         select new DispStockListDTO
                         {
                             StID = Stock.StID,
                             PrName = Product.PrName,
                             StQuantity = Stock.StQuantity,
                             SStock = Product.PrSafetyStock,

                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<DispStockListDTO> GetStockData(T_Stock selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                
                var tb = from Stock in context.T_Stocks
                         join Product in context.M_Products
                         on Stock.PrID equals Product.PrID
                         where Stock.StFlag.Equals(0)&&
                         ((selectCondition.PrID==-1)?true:
                         Stock.PrID==selectCondition.PrID)

                         select new DispStockListDTO
                         {
                             StID = Stock.StID,
                             PrName = Product.PrName,
                             StQuantity = Stock.StQuantity,
                             SStock = Product.PrSafetyStock,
                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;  
        }

        public int GetStQuantity(int PrID)
        {
            var context = new SalesManagement_DevContext();
            var Stock= context.T_Stocks.Single(x => x.PrID==PrID);
            int StQuantity = Stock.StQuantity;
            return StQuantity;
        }

    }
}
    
