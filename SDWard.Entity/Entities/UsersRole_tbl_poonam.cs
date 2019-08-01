using SDWard.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Entity.Entities
{
  public  class UsersRole_tbl_poonam: BaseEntity
    {
        [Key]
        public int UserRole { get; set; }
        public string UserType { get; set; }      
        public virtual ICollection<User_tbl_Poonam> User_tbl_Poonam { get; set; }

    }
}
