using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class OrderDataAccess
    {
        public decimal  GetPrice(int PrID)
        {
            var context = new SalesManagement_DevContext();
            decimal Price = 0;
            bool flg = context.M_Products.Any(x => x.PrID == PrID);

            if (flg)
            {
                var Product = context.M_Products.Single(x => x.PrID == PrID);
                Price = Product.Price;
            }
            return Price;
        }

        public bool AddOrderData(T_Order regOr)
        {
            return true;
        }
    }
}
