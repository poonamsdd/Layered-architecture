using SDWard.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Entity.Entities
{
   public class Department_tbl_poonam: BaseEntity
    {
        [Key]
        public int DeptId{ get; set; }
        public string DeptName { get; set; }     
        public string Designation { get; set; }
        public virtual ICollection<User_tbl_Poonam> User_Poonam { get; set; }
    }
}
