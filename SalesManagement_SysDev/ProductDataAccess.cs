using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ProductDataAccess
    { 
        public bool AddProductData(M_Product regPro)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Products.Add(regPro);
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

        public bool UpdateProductData(M_Product updPro)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Product = context.M_Products.First(x => x.PrID == updPro.PrID);
                Product.MaID = updPro.MaID;
                Product.PrName = updPro.PrName;
                Product.ScID= updPro.ScID;
                Product.PrSafetyStock= updPro.PrSafetyStock;
                Product.Price= updPro.Price;
                Product.PrModelNumber= updPro.PrModelNumber;
                Product.PrColor= updPro.PrColor;
                Product.PrReleaseDate= updPro.PrReleaseDate;

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

      

        public bool HideProductData(M_Product hidPro)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Product = context.M_Products.Single(x => x.PrID == hidPro.PrID);
                Product.PrFlag = hidPro.PrFlag;

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
