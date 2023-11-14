using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OrderDbConnection
    {
        public List<M_Client> GetClientNameDspData()
        {
            List<M_Client> Clname = new List<M_Client>();
            try
            {
                var context = new SalesManagement_DevContext();
                Clname = context.M_Clients.Where(x => x.ClName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Clname;
        }

    }
}
