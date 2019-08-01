using SDWard.Entity.Entities;
using SDWard.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using SDWard.Data.Infrastructure;
using SDWard.Repository.UnitOfWork;
using SDWard.Repository.Repository.User;
using AutoMapper;

namespace SDWard.Repository.Repository.Verification
{
    public class VerificationRepository : GenericRepository<Verification_poonam>,IVerificationRepository
    {
        private readonly IUOW _iuow;
        private readonly IUserRepository _user;
        public VerificationRepository(IUOW iuow, IUserRepository user) : base(iuow.DbContext())
        {
            _user = user;
            _iuow = iuow;
        }

        public VerifyModel AddVerification(VerifyModel model)
        {
            var obj = Mapper.Map<VerifyModel, Verification_poonam>(model);
            var obj1 = base.Add(obj);
            _iuow.SaveChanges();
            return Mapper.Map<Verification_poonam, VerifyModel>(obj1);
        }

        public string CompareCode(VerifyModel model)
        {
            var obj = base.GetList().Where(x => ((x.Email == model.Email) && (x.ConfirmEmail == model.ConfirmEmail))).SingleOrDefault();
            if (obj==null)
            {
                return "verification not matched";
            }
            var obj1 = DelVerification(obj);
            if (obj1 == null)
            {
                return "Error";
            }
            var obj2 = _user.Verify(model.Email);
            if (obj2==null)
            {
                return "not found";
            }
         return "Success";

        }
       
        public VerifyModel DelVerification(Verification_poonam model)
        {
           var a =  base.Delete(model);
            _iuow.SaveChanges();
           
            return Mapper.Map<Verification_poonam, VerifyModel>(a);
        }

        public string Reset(ResetModel model)
        {
            var obj = base.GetList().Where(x => (x.Email == model.Email) && (x.ConfirmEmail == model.Code)).FirstOrDefault();
            if (obj==null)
            {
                return "Enter the required field";
            }
            var obj1 = DelVerification(obj);
            if (obj1 == null)
            {
                return "Error";
            }
            _user.ResetPassword(model);

            return "success";
                         
        }
    }
}
