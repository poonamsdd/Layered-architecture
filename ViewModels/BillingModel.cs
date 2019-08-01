using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class BillingModel
    {
        public int Bill_Id { get; set; }      
        public int RecordId { get; set; }
        public string MedicineName { get; set; }
        public DateTime? AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string TotalBill { get; set; }

    }
}
