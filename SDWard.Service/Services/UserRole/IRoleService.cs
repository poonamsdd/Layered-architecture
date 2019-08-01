using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.UserRole
{
  public  interface IRoleService
    {
        UserRoleModel InsertRole(UserRoleModel model);
        UserRoleModel Update(UserRoleModel model);
        UserRoleModel Delete(int id);
        UserRoleModel GetRoleId(int id);
        IEnumerable<UserRoleModel> GetList();
    }
}
