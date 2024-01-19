using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OrderDataAccess
    {
        OrderDbConnection ODC=new OrderDbConnection();

        public bool AddOrderData(T_Order regOr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Orders.Add(regOr);
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

        public bool AddOrderDetailData(T_OrderDetail regOrD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_OrderDetails.Add(regOrD);
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

        public bool UpdateOrderDetailData(T_OrderDetail updOrD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var OrderDetail = context.T_OrderDetails.First(x => x.OrID == updOrD.OrID && x.PrID == updOrD.PrID);
                
                OrderDetail.OrQuantity = updOrD.OrQuantity;
                OrderDetail.OrTotalPrice = updOrD.OrTotalPrice;

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

        public bool HideOrderData(T_Order hidOr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Order = context.T_Orders.Single(x => x.OrID == hidOr.OrID);
                Order.OrFlag = hidOr.OrFlag;
                Order.OrHidden = hidOr.OrHidden;

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

        public bool UpdOrderFlg(T_Order UpdOrFlag)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Order = context.T_Orders.Single(x => x.OrID == UpdOrFlag.OrID);
                Order.OrStateFlag = UpdOrFlag.OrStateFlag;

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

        public bool CheckCascadeOrderID(int OrID)
        {
            var context = new SalesManagement_DevContext();
            bool flg = context.T_Chumons.Any(x => x.OrID == OrID);

            return flg;
        }

        public bool CheckProductID(int PrID)
        {
            var context = new SalesManagement_DevContext();
            int OrID= ODC.GetOrID();
            bool flg1 =context.T_OrderDetails.Any(x=>x.OrID==OrID);
            if (flg1)
            {
                List<DispOrderDetailListDTO> tb=ODC.OrderDetailGetData(OrID);
                bool flg=tb.Any(x => x.PrID == PrID);
                return flg;
            }
           
            return flg1;
        }
    }
}
