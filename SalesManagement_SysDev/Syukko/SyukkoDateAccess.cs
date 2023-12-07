using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Hierarchy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDateAccess
    {
        public bool AddSyukkoData(T_Syukko Syukko)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Syukkos.Add(Syukko);
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

        public bool AddSyukkoDetailData(T_SyukkoDetail SDetail)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_SyukkoDetails.Add(SDetail);
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

        public bool HideSyukkoData(T_Syukko hidSy)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Chumon = context.T_Syukkos.Single(x => x.SyID == hidSy.SyID);
                Chumon.SyFlag = hidSy.SyFlag;
                Chumon.SyHidden = hidSy.SyHidden;

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
