using SDWard.Repository.Repository.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Veification
{
    public class VerifyService : IVerifyService
    {
        private readonly IVerificationRepository _ver;
       
        public VerifyService (IVerificationRepository ver)
        {
            _ver = ver;
        }
        public VerifyModel AddVerification(VerifyModel model)
        {
           return _ver.AddVerification(model);
        }

        public string CompareCode(VerifyModel model)
        {
           return _ver.CompareCode(model);
        }

        public string ResetCode(ResetModel model)
        {
            return _ver.Reset(model);
        }
    }
}
