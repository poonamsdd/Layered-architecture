using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Entity.Entities
{
   public  class HealthNotes_Poonam
    {
        [Key]
        public int HealthNoteId { get; set; }
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string Assessment { get; set; }
        public string Plan { get; set; }       
        [ForeignKey("paitentSchedule")]
        public int AppointmentId { get; set; }
        public virtual Poonam_Patientschedule paitentSchedule { get; set; }
        
    }
}
