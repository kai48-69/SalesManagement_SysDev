using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ProductDbConnection
    {
        public List<DispProductListDTO> ProductGetData(string strName, string strMaker, int safety)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Product in context.M_Products
                         join Manufacturer in context.M_Makers
                         on Product.MaID equals Manufacturer.MaID
                         join SmallClassifications in context.M_SmallClassifications
                         on Product.ScID equals SmallClassifications.ScID
                         where Product.PrName.Contains(strName) &&
                         Manufacturer.MaName.Contains(strMaker)

                         select new DispProductListDTO
                         {
                             PrID = Product.PrID.ToString(),
                             MaName=Manufacturer.MaName,
                             PrName = Product.PrName,
                             Price=Product.Price,
                             ScText = SmallClassifications.ScName,
                             PrSafetyStock = Product.PrSafetyStock,
                             PrColor = Product.PrColor, 
                             PrModelNumber= Product.PrModelNumber, 
                             PrReleaseDate = Product.PrReleaseDate,
                             PrHidden = Product.PrHidden,

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

        public List<M_Maker> GetMakerNameDspData()
        {
            List<M_Maker> Mname = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                Mname = context.M_Makers.Where(x => x.MaName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Mname;
        }

        public List<M_SmallClassification> GetScDspData()
        {
            List<M_SmallClassification> ScName = new List<M_SmallClassification>();
            try
            {
                var context = new SalesManagement_DevContext();
                ScName = context.M_SmallClassifications.Where(x => x.ScName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ScName;
        }

        public List<DispProductListDTO> GetProductData(M_Product selectCondition)
        {
            var context = new SalesManagement_DevContext();
            try
            {
                var tb = from Product in context.M_Products
                         join Manufacturer in context.M_Makers
                         on Product.MaID equals Manufacturer.MaID
                         join SmallClassifications in context.M_SmallClassifications
                         on Product.ScID equals SmallClassifications.ScID
                         where Product.PrName.Contains(selectCondition.PrName) &&
                         Product.PrColor.Contains(selectCondition.PrColor) &&
                         Product.PrModelNumber.Contains(selectCondition.PrModelNumber) &&
                         Product.PrReleaseDate.CompareTo(value:selectCondition.PrReleaseDate)
                          ((selectCondition.PrID == -1) ? true :
                          Product.PrID == selectCondition.PrID) &&
                         ((selectCondition.MaID == -1) ? true :
                         Product.MaID == selectCondition.MaID) &&
                         ((selectCondition.ScID == -1) ? true :
                         Product.ScID == selectCondition.ScID) &&
                         ((selectCondition.Price == -1) ? true :
                         Product.Price == selectCondition.Price) &&
                         ((selectCondition.PrSafetyStock == -1) ? true :
                         Product.PrSafetyStock == selectCondition.PrSafetyStock) 

                         select new DispProductListDTO
                         {
                             PrID = Product.ProductCD,
                             PrName = Product.ProductName,
                             ScText = SmallClassifications.ScName,
                             MaName = Manufacturer.ManufacturerName,
                             PrSafetyStock = Product.SafetyStockCnt,
                             PrColor = Product.Color,
                             Price = Product.Price,
                             PrModelNumber = Product.PrModelNumber,
                             PrReleaseDate= Product.PrReleaseDate,
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
