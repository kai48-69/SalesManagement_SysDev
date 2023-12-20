using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SaleDataAccess
    {
        public bool AddSaleData(T_Sale Sale)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Sale.Add(Sale);
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

        public bool AddSaleDetailData(T_SaleDetail SDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_SaleDetails.Add(SDetail);
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

        public bool HideSaleData(T_Sale hidSa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Sale = context.T_Sale.Single(x => x.SaID == hidSa.SaID);
                Sale.SaFlag = hidSa.SaFlag;
                Sale.SaHidden = hidSa.SaHidden;

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
