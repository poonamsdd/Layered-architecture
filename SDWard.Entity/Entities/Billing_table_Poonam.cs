using SDWard.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Entity.Entities
{
     public  class Billing_table_Poonam: BaseEntity
    {
        [Key]
        public int Bill_Id { get; set; }
        [ForeignKey("RecordSet_tbl_Poonam")]
        public int RecordId { get; set; }
        public string MedicineName { get; set; }
        public DateTime? AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set;}
        public string TotalBill { get; set; }
        public virtual RecordSet_tbl_Poonam RecordSet_tbl_Poonam { get; set; }
    }
}
