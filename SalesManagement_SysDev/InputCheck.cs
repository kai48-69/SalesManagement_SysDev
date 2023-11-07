using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class InputCheck
    {
        public bool IntegerCheck(string chkData)
        {
            Regex regex = new Regex("^-?[0-9]+$");
            if (!regex.IsMatch(chkData))
                return false;
            else
                return true;
        }

        public bool CheckProductCDExistence(string SyohinID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //商品カテゴリCDで一致するデータが存在するか
                int ProductID = int.Parse(SyohinID);
                flg = context.M_Products.Any(x => x.PrID == ProductID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
    }
}
