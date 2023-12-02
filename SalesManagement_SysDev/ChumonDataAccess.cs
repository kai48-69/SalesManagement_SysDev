using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ChumonDataAccess
    {
        public bool AddChumonData(T_Chumon Chumon)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Chumons.Add(Chumon);
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
        public bool AddChumonDetailData(T_ChumonDetail CDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ChumonDetails.Add(CDetail);
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

        public bool HideChumonData(T_Chumon hidCh)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Chumon = context.T_Chumons.Single(x => x.ChID == hidCh.ChID);
                Chumon.ChFlag = hidCh.ChFlag;
                Chumon.ChHidden = hidCh.ChHidden;

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
