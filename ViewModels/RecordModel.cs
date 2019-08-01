using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class RecordModel
    {
        public int RecordId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int RoomNo { get; set; }
        public string DiseaseName { get; set; }
        public string Description { get; set; }
        public DateTime? AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set; }
    }
}
