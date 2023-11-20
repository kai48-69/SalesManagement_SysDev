using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ClientDbConnection
    {
        public List<DispClientListDTO> ClientGetData(string strName, string strSOffice, int safety)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Client in context.M_Clients
                         join SOffice in context.M_SalesOffices
                         on Client.SoID equals SOffice.SoID
                         where Client.ClName.Contains(strName) &&
                         SOffice.SoName.Contains(strSOffice) &&
                         Client.ClFlag.Equals(0)

                         select new DispClientListDTO
                         {
                             ClID = Client.ClID.ToString(),
                             SoName = SOffice.SoName,
                             ClName = Client.ClName,
                             ClAddress = Client.ClAddress,
                             ClPhone = Client.ClPhone,
                             Clpostel = Client.ClPostal,
                             ClFAX = Client.ClFAX,
                             ClHidden = Client.ClHidden,
                             
                         };
                return tb.ToList();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("在庫データ取得時に例外エラーが発生しました", "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public List<M_SalesOffice> GetSoNameDspData()
        {

            List<M_SalesOffice> SoName = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                SoName = context.M_SalesOffices.Where(x => x.SoName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SoName;
        }
        public List<DispClientListDTO> GetClientData(M_Client selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Client in context.M_Clients
                         join SOffice in context.M_SalesOffices
                         on Client.SoID equals SOffice.SoID
                         where Client.ClAddress.Contains(selectCondition.ClAddress) &&
                          ((selectCondition.ClID == -1) ? true :
                          Client.ClID == selectCondition.ClID) &&
                         ((selectCondition.SoID == -1) ? true :
                         Client.SoID == selectCondition.SoID) &&
                          Client.ClFlag.Equals(0)


                         select new DispClientListDTO
                         {
                             ClID = Client.ClID.ToString(),
                             SoName = SOffice.SoName,
                             ClName = Client.ClName,
                             ClAddress = Client.ClAddress,
                             ClPhone = Client.ClPhone,
                             Clpostel = Client.ClPostal,
                             ClFAX = Client.ClFAX,
                             ClHidden = Client.ClHidden,

                         };

                return tb.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
