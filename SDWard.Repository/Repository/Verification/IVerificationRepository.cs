using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.Repository.Verification
{
   public interface IVerificationRepository
    {
        VerifyModel AddVerification(VerifyModel model);
        string CompareCode(VerifyModel model);
        string Reset(ResetModel model);
    }
}
