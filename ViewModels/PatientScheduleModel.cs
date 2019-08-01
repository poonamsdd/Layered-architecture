using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class PatientScheduleModel
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }

        public int StaffId { get; set; }
        public DateTime AppointmentStartTime { get; set; }
        public DateTime AppointmentEndTime { get; set; }
    }
}
