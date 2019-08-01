using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Veification
{
   public interface IVerifyService
    {
        VerifyModel AddVerification(VerifyModel model);
        string CompareCode(VerifyModel model);
        string ResetCode(ResetModel model);
    }
}
