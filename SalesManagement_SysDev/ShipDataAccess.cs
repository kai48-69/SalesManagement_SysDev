using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ShipDataAccess
    {
        public bool AddSyukkoData(T_Shipment Syukko)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Shipments.Add(Syukko);
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

        public bool AddSyukkoDetailData(T_ShipmentDetail SDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ShipmentDetails.Add(SDetail);
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

        public bool UpdShipFlg(T_Shipment UpdShFlag)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Ship = context.T_Shipments.Single(x => x.ShID == UpdShFlag.ShID);
                Ship.ShStateFlag = UpdShFlag.ShStateFlag;
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
        public bool HideShipData(T_Shipment hidSh)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Ship = context.T_Shipments.Single(x => x.ShID == hidSh.ShID);
                Ship.ShFlag = hidSh.ShFlag;
                Ship.ShHidden = hidSh.ShHidden;

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
