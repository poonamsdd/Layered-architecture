using SDWard.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Entity.Entities
{
    public class User_tbl_Poonam: BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UsersRole_tbl_poonam")]
        public int UserRole { get; set; }    
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Index(IsUnique = true)]
        [Column(TypeName = "VARCHAR")]
        [StringLength(13)]
        public string Contact { get; set; }
        [ForeignKey("Department_tbl_poonam")]
        public int? DeptId { get; set; }
        //add new property for varification
        public bool VarifyBit { get; set; }
        public virtual Department_tbl_poonam Department_tbl_poonam { get; set; }
        public virtual UsersRole_tbl_poonam UsersRole_tbl_poonam { get; set; }

    }
}
