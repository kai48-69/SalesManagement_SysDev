using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ClientDataAccess
    {
        public bool AddClientData(M_Client regCl)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Clients.Add(regCl);
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

        public bool UpdateClientData(M_Client updCl)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Client = context.M_Clients.First(x => x.ClID == updCl.ClID);
                Client.SoID = updCl.SoID;
                Client.ClName = updCl.ClName;
                Client.ClAddress = updCl.ClAddress;
                Client.ClPhone = updCl.ClPhone;
                Client.ClPostal = updCl.ClPostal;
                Client.ClFAX = updCl.ClFAX;

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

        public bool CheckCascadeClient(int ClID)
        {
            var context = new SalesManagement_DevContext();
            bool flg = context.T_Orders.Any(x => x.ClID == ClID);

            return flg;
        }

        public bool HideClientData(M_Client hidCl)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Client = context.M_Clients.Single(x => x.ClID == hidCl.ClID);
                Client.ClFlag = hidCl.ClFlag;

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
