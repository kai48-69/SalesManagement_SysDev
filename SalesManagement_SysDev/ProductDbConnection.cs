﻿using System;
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
    }
}
