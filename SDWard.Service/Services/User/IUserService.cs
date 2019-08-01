using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.User
{
   public interface IUserService
    {
        UserModel InsertUser(UserModel model);
        UserModel Update(UserModel model);
        UserModel Delete(int id);
        UserModel GetUserId(int id);
        IEnumerable<UserModel> GetList();
        UserModel LoginUser(LoginModel model);
        ForgetPasswordModel ForgetUser(ForgetPasswordModel model);
    }
}
