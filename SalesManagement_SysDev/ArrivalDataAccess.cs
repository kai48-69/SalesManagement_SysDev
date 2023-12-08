using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ArrivalDataAccess
    {
        public bool AddArrivalData(T_Arrival Arrival)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Arrivals.Add(Arrival);
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
        public bool AddArrivalDetailData(T_ArrivalDetail ADetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ArrivalDetails.Add(ADetail);
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

        public bool HideArrivalData(T_Arrival hidAr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Arder = context.T_Arrivals.Single(x => x.ArID == hidAr.ArID);
                Arder.ArFlag = hidAr.ArFlag;
                Arder.ArHidden = hidAr.ArHidden;

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
