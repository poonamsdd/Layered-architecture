using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Entity.Entities
{
  public class Poonam_Patientschedule
    {
        
        [Key]
        public int AppointmentId { get; set; }
        [ForeignKey("User_tbl_Poonam")]
        public int PatientId { get; set; }
        [ForeignKey("User_tbl_Staff")]
        public int StaffId { get; set; }
        public DateTime AppointmentStartTime { get; set; }
        public DateTime AppointmentEndTime { get; set; }
        public ICollection<HealthNotes_Poonam> healthnotes { get; set; }
        public virtual User_tbl_Poonam User_tbl_Poonam { get; set; }
        public virtual User_tbl_Poonam User_tbl_Staff { get; set; }


    }
}
