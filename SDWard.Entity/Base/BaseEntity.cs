using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Entity.Base
{
  public   class BaseEntity
    {
       
        public bool IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}

