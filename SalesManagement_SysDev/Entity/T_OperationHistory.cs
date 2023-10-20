﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_OperationHistory
    {
        [Key]
        public int OpHistoryID { get; set; }        //ログイン操作ID		
        public int EmID { get; set; }               //社員ID
        [MaxLength(50)]
        [Required]
        public string ItemName { get; set; }        //項目名
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime OpStartTime { get; set; }   //操作開始時刻	
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? OpEndTime { get; set; }	//操作終了時刻		

        public virtual M_Employee M_Employee { get; set; }
    }
}
