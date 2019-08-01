using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class VerifyModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
    }
}
