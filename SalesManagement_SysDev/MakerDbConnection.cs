using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Employee
{
    internal class MakerDbConnection
    {
        public List<M_Maker> GetMaNameDspData()
        {
            List<M_Maker> MaName = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                MaName = context.M_Makers.Where(x => x.MaName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MaName;
        }
    }
    }
}
