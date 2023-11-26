using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SalesManagement_SysDev
{
    class DispProductListDTO
    {
        [DisplayName("商品ID")]
        public string PrID { get; set; }
        [DisplayName("メーカー名")]
        public string MaName { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("価格")]
        public decimal Price { get; set; }
        [DisplayName("安全在庫数")]
        public int PrSafetyStock { get; set; }
        [DisplayName("小分類")]
        public string ScText { get; set; }
        [DisplayName("型番")]
        public string PrModelNumber { get; set; }
        [DisplayName("色")]
        public string PrColor { get; set; }
        [DisplayName("発売日")]
        public DateTime PrReleaseDate { get; set; }
        [DisplayName("非表示理由")]
        public string PrHidden { get; set; }
    }

    class DispEmployeeListDTO
    {
        [DisplayName("社員ID")]
        public string EmID { get; set; }
        [DisplayName("社員名")]
        public string EmName { get; set; }
        [DisplayName("営業所名")]
        public string SoName { get; set; }
        [DisplayName("役職名")]
        public string PoName { get; set; }
        [DisplayName("入社年月日")]
        public string EmHiredate { get; set; }
        [DisplayName("電話番号")]
        public string EmPhone { get; set; }
        [DisplayName("非表示理由")]
        public string EmHidden { get; set; }
    }

    class DispClientListDTO
    {
        [DisplayName("顧客ID")]
        public string ClID { get; set; }
        [DisplayName("営業所名")]
        public string SoName { get; set; }
        [DisplayName("顧客名")]
        public string ClName { get; set; }
        [DisplayName("住所")]
        public string ClAddress { get; set; }
        [DisplayName("電話番号")]
        public string ClPhone { get; set; }
        [DisplayName("郵便番号")]
        public string Clpostel { get; set; }
        [DisplayName("FAX")]
        public string ClFAX { get; set; }
        [DisplayName("非表示理由")]
        public string ClHidden { get; set; }
    }

    class DispOrderListDTO
    {
        [DisplayName("受注ID")]
        public string OrID { get; set; }
        [DisplayName("受注詳細ID")]
        public string OrDetailID { get; set; }  
        [DisplayName("営業所名")]
        public string SoName { get; set; }
        [DisplayName("社員名")]
        public string EmName { get; set; }
        [DisplayName("顧客名")]
        public string ClName { get; set; }
        [DisplayName("顧客担当者名")]
        public string ClCharge { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public string PrQuantity { get; set; }
        [DisplayName("合計金額")]
        public string OrTotalPrice { get; set; }
        [DisplayName("受注年月日")]
        public string OrDate { get; set; }
        [DisplayName("非表示理由")]
        public string OrHidden { get; set; }
    }

    class DispOrderDetailListDTO
    {
        [DisplayName("受注ID")]
        public string OrID { get; set; }
        [DisplayName("受注詳細ID")]
        public string OrDetailID { get; set;}
        [DisplayName("商品ID")]
        public string PrID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public string PrQuantity { get; set; }
        [DisplayName("合計金額")]
        public string OrTotalPrice { get; set;}
    }

    class GetOrderDataDTO
    {
        [DisplayName("受注ID")]
        public string OrID { get; set; }
        [DisplayName("受注詳細ID")]
        public string OrDetailID { get; set; }
        [DisplayName("営業所ID")]
        public string SoID { get; set; }
        [DisplayName("社員ID")]
        public string EmID { get; set; }
        [DisplayName("顧客ID")]
        public string ClID { get; set; }
        [DisplayName("商品ID")]
        public string PrID { get; set; }
        [DisplayName("数量")]
        public string PrQuantity { get; set; }
    }
    class SetLoginDataDTO
    {
        public int EmID { get; set; }
        public string EmName { get; set; }
        public string SoName { get; set; }
        public int PoID { get; set; }
    }
}

