using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public  class JSONModel
    {
        public string Status { get; set; }
        public object Data { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
