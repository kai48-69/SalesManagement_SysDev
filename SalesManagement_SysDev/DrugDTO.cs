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
            public string ScText { get; set;}
            [DisplayName("型番")]
            public string PrModelNumber { get; set; }
            [DisplayName("色")]
            public string PrColor { get; set; }
            [DisplayName("発売日")]
            public DateTime PrReleaseDate { get; set; }
            [DisplayName("非表示理由")]
            public string PrHidden { get; set; }
        }
    }

