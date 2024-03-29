﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ProductDbConnection
    {
        public List<DispProductListDTO> ProductGetData(string strName, string strMaker)
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
                         Manufacturer.MaName.Contains(strMaker)&&
                         Product.PrFlag.Equals(0)

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

        public List<M_Product> GetPrNameDspData()
        {
            List<M_Product> PrName = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                PrName = context.M_Products.Where(x => x.PrName != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return PrName;
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
                          ((selectCondition.PrID == -1) ? true :
                          Product.PrID == selectCondition.PrID) &&
                         ((selectCondition.MaID == -1) ? true :
                         Product.MaID == selectCondition.MaID) &&
                         ((selectCondition.ScID == -1) ? true :
                         Product.ScID == selectCondition.ScID) &&
                         ((selectCondition.Price == -1) ? true :
                         Product.Price == selectCondition.Price) &&
                         ((selectCondition.PrSafetyStock == -1) ? true :
                         Product.PrSafetyStock == selectCondition.PrSafetyStock)&&
                         ((selectCondition.PrFlag==0)?true:
                         Product.PrFlag==selectCondition.PrFlag)


                         select new DispProductListDTO
                         {
                             PrID = Product.PrID.ToString(),
                             PrName = Product.PrName,
                             ScText = SmallClassifications.ScName,
                             MaName = Manufacturer.MaName,
                             PrSafetyStock = Product.PrSafetyStock,
                             PrColor = Product.PrColor,
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

        public decimal GetPrice(int PrID)
        {
            var context = new SalesManagement_DevContext();
            decimal Price = 0;
            bool flg = context.M_Products.Any(x => x.PrID == PrID);

            if (flg)
            {
                var Product = context.M_Products.Single(x => x.PrID == PrID);
                Price = Product.Price;
            }
            return Price;
        }

      

        public string GetPrName(int PrID, int HaID)
        {
            var context = new SalesManagement_DevContext();

            var Pr = context.M_Products.Single(x => x.PrID == PrID);
            if (HaID != 0)
            {
                 var Ha = context.T_Hattyus.Single(x => x.HaID == HaID);
                string PrName = Pr.PrName;
                if (Pr.PrFlag == 0 && Pr.MaID == Ha.MaID)
                {
                    return PrName;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                string PrName = Pr.PrName;
                 if (Pr.PrFlag == 0 && HaID == 0)
                {
                    return PrName;
                }
                else
                {
                    return "";
                }
            }
        }

        public int CheckCascadeProduct(int PrID)//非表示か確認する
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var Product = context.M_Products.Single(x => x.PrID == PrID);
                int SyohinID = Product.PrID;
                if (Product.PrFlag == 0)
                {
                    return SyohinID;
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }

        public bool HideCheckProduct(int PrID)//在庫数が０か確認する
        {
            var context = new SalesManagement_DevContext();
            var Stock=context.T_Stocks.Single( x => x.PrID ==PrID);
            if(Stock.StQuantity != 0)
            {
                return false;
            }
            return true;
        }

        public int GetPrID()
        {
            var context = new SalesManagement_DevContext();
            return context.M_Products.Max(x => x.PrID);
        }

    }
}
