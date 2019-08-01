using SDWard.Repository.Repository.User;
using SDWard.Repository.Repository.UserRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _role;
        public UserService(IUserRepository role)
        {
           this._role = role;
        }
        public UserModel Delete(int id)
        {
          return  _role.DeleteUser(id);
            
        }

        public IEnumerable<UserModel> GetList()
        {
           return _role.GetUserList();
        }

        public UserModel GetUserId(int id)
        {
            return _role.GetUserById(id);
        }

        public UserModel InsertUser(UserModel model)
        {
            return _role.AddUser(model);
        }

        public UserModel Update(UserModel model)
        {
            return _role.UpdateUser(model);
        }
        public UserModel LoginUser(LoginModel model)
        {
            return _role.Login(model);
        }
        public ForgetPasswordModel ForgetUser(ForgetPasswordModel model)
        {
            return _role.FindEmail(model);
        }
    }
}
