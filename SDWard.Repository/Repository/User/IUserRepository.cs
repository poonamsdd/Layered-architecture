using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.Repository.User
{
  public  interface IUserRepository
    {
        UserModel AddUser(UserModel model);
        UserModel UpdateUser(UserModel se);
        UserModel DeleteUser(int id);
        List<UserModel> GetUserList();
        UserModel GetUserById(int id);
        UserModel Login(LoginModel model);
        UserModel Verify(string str);
        UserModel GetStaffById(int id);
        UserModel GetPatientById(int id);
        ForgetPasswordModel FindEmail(ForgetPasswordModel model);
        string ResetPassword(ResetModel model);
        IEnumerable<UserModel> GetStaff();
        IEnumerable<UserModel> GetPatient();


    }
}
