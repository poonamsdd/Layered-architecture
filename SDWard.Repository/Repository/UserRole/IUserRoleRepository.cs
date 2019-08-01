using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.Repository.UserRole
{
   public interface IUserRoleRepository
    {
        UserRoleModel AddUserRole(UserRoleModel model);
        UserRoleModel UpdateUserRole(UserRoleModel se);
        UserRoleModel DeleteUserRole(int id);
        List<UserRoleModel> GetUserRoleList();
        UserRoleModel GetRoleById(int id);
    }
}
