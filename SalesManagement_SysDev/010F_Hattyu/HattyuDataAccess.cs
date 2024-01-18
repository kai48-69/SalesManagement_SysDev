using SalesManagement_SysDev.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class HattyuDataAccess
    {
        HattyuDbConnection HDC =new HattyuDbConnection();

        public bool AddOrderData(T_Hattyu regHa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Hattyus.Add(regHa);
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

        public bool AddHattyuDetailData(T_HattyuDetail regHaD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_HattyuDetails.Add(regHaD);
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

        public bool UpdateHattyuDetailData(T_HattyuDetail updHaD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var HattyuDetail = context.T_HattyuDetails.First(x => x.HaID == updHaD.HaID);
                HattyuDetail.HaQuantity = updHaD.HaQuantity;
             
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

        public bool HideHattyuData(T_Hattyu hidHa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Hattyu = context.T_Hattyus.Single(x => x.HaID == hidHa.HaID);
                Hattyu.HaFlag = hidHa.HaFlag;
                Hattyu.HaHidden = hidHa.HaHidden;
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

        public bool UpdWaFlg(T_Hattyu UpdWaFlag)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Hattyu = context.T_Hattyus.Single(x => x.HaID == UpdWaFlag.HaID);
                Hattyu.WaWarehouseFlag = UpdWaFlag.WaWarehouseFlag;

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

        public bool CheckProductID(int PrID)
        {
            var context = new SalesManagement_DevContext();
            int HaID = HDC.GetHaID();
            bool flg1 = context.T_HattyuDetails.Any(x => x.HaID == HaID);
            if (flg1)
            {
                List<DispHattyuDetailListDTO> tb = HDC.HattyuDetailGetData(HaID);
                bool flg = tb.Any(x => x.PrID == PrID);
                return flg;
            }

            return flg1;
        }
    }
}
