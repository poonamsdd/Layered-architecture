using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
  public  class UserModel
    {
        public int Id { get; set; }
       
        public int UserRole { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        
        public string Email { get; set; }
       
        public string Password { get; set; }
       
        public string Contact { get; set; }
       
        public int? DeptId { get; set; }
        public bool VarifyBit { get; set; }


   }
}
