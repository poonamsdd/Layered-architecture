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
    public class RecordSet_tbl_Poonam : BaseEntity
    {
        [Key]
        public int RecordId{ get; set; }      
        public string FName { get; set; }
        public string LName { get; set; }
        public int RoomNo { get; set; }
        public string  DiseaseName { get; set; }
        public string Description { get; set; }        
        public DateTime? AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set; }      
       
    }
}
