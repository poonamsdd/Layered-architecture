using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class HealthNotesModel
    {
        public int HealthNoteId { get; set; }
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string Assessment { get; set; }
        public string Plan { get; set; }       
       // public int StaffId { get; set; }       
       // public int PaitentId { get; set; }       
        public int AppointmentId { get; set; }
    }
}
