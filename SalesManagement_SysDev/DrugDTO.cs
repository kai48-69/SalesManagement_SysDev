using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Runtime.InteropServices;

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
    }

    class DispOrderDetailListDTO
    {
        [DisplayName("受注ID")]
        public string OrID { get; set; }
        [DisplayName("受注詳細ID")]
        public string OrDetailID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public string PrQuantity { get; set; }
        [DisplayName("合計金額")]
        public string OrTotalPrice { get; set; }
    }

    class GetOrderDataDTO
    {
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        [DisplayName("受注詳細ID")]
        public int OrDetailID { get; set; }
        [DisplayName("営業所ID")]
        public int SoID { get; set; }
        [DisplayName("顧客ID")]
        public int ClID { get; set; }
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("数量")]
        public int PrQuantity { get; set; }
        [DisplayName("受注年月日")]
        public DateTime OrDate { get; set; }
    }
    class DispArrivalListDTO
    {
        [DisplayName("入荷ID")]
        public string ArID { get; set; }
        [DisplayName("入荷詳細ID")]
        public string ArDetailID { get; set; }
        [DisplayName("営業所名")]
        public string SoName { get; set; }
        [DisplayName("社員名")]
        public string EmName { get; set; }
        [DisplayName("顧客名")]
        public string ClName { get; set; }
        [DisplayName("受注ID")]
        public string OrID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public string ArQuantity { get; set; }
        [DisplayName("入荷年月日")]
        public string ArDate { get; set; }
    }

    class SetLoginDataDTO
    {
        public int EmID { get; set; }
        public string EmName { get; set; }
        public string SoName { get; set; }
        public int PoID { get; set; }
    }

    class DispHattyuListDTO
    {
        [DisplayName("発注ID")]
        public string HaID { get; set; }
        [DisplayName("発注詳細ID")]
        public string HaDetailID { get; set; }
        [DisplayName("メーカー名")]
        public string MaName { get; set; }
        [DisplayName("社員名")]
        public string EmName { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public string HaQuantity { get; set; }
        [DisplayName("発注年月日")]
        public string HaDate { get; set; }
    }

    class DispHattyuDetailListDTO
    {
        [DisplayName("発注詳細ID")]
        public string HaDetailID { get; set; }
        [DisplayName("発注ID")]
        public string HaID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public string HaQuantity { get; set; }
    }

    class GetHattyuDataDTO
    {
        [DisplayName("発注ID")]
        public string HaID { get; set; }
        [DisplayName("商品ID")]
        public string PrID { get; set; }
        [DisplayName("数量")]
        public string HaQuantity { get; set; }
    }

    class DispShipListDTO
    {
        [DisplayName("出荷ID")]
        public string ShID { get; set; }
        [DisplayName("出荷詳細ID")]
        public string ShDetailID { get; set; }
        [DisplayName("顧客名")]
        public string ClName { get; set; }
        [DisplayName("社員名")]
        public string EmName { get; set; }
        [DisplayName("営業所名")]
        public string SoName { get; set; }
        [DisplayName("受注ID")]
        public string OrID { get; set; }
        [DisplayName("出荷完了年月日")]
        public string ShFinishDate { get; set; }
    }

    class DispSyukkoListDTO
    {
        [DisplayName("出庫ID")]
        public string SyID { get; set; }
        [DisplayName("出庫詳細ID")]
        public string SyDetailID { get; set; }
        [DisplayName("社員名")]
        public string EmName { get; set; }
        [DisplayName("顧客名")]
        public string ClName { get; set; }
        [DisplayName("営業所名")]
        public string SoName { get; set; }
        [DisplayName("受注ID")]
        public string OrID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public int SyQuantity { get; set; }
        [DisplayName("出庫年月日")]
        public string SyDate { get; set; }
    }

    class DispWarehousingListDTO
    {
        [DisplayName("入庫ID")]
        public int WaID { get; set; }
        [DisplayName("入庫詳細ID")]
        public int WaDetailID { get; set; }
        [DisplayName("発注ID")]
        public int HaID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public int WaQuantity { get; set; }
    }

    class DispChumonListDTO
    {
        [DisplayName("注文ID")]
        public int ChID { get; set; }
        [DisplayName("注文詳細ID")]
        public int ChDID { get; set; }
        [DisplayName("営業所名")]
        public string SoName { get; set; }
        [DisplayName("顧客名")]
        public string ClName { get; set; }
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        [DisplayName("商品名")]
        public string PrName { get; set; }
        [DisplayName("数量")]
        public int ChQuantity { get; set; }
    }

    class GetChumonDataDTO
    {
        [DisplayName("注文ID")]
        public int ChID { get; set; }
        [DisplayName("注文詳細ID")]
        public int ChDetailID { get; set; }
        [DisplayName("受注ID")]
        public int OrID { get; set; }
        [DisplayName("営業所ID")]
        public int SoID { get; set; }
        [DisplayName("顧客ID")]
        public int ClID { get; set; }
        [DisplayName("商品ID")]
        public int PrID { get; set; }
        [DisplayName("数量")]
        public int ChQuantity { get; set; }
    }

    class GetNyukoDataDTO
    {
        public int PrID { get; set; }
        public int WaQuantity { get; set; }
    }

}