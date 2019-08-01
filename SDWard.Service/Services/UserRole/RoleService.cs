using SDWard.Repository.Repository.UserRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.UserRole
{
  public  class RoleService: IRoleService
    {
        private readonly IUserRoleRepository _Istaffobj;
        public RoleService(IUserRoleRepository staffobj)
        {
            this._Istaffobj = staffobj;
        }
        public UserRoleModel Delete(int id)
        {
            return _Istaffobj.DeleteUserRole(id);
        }

        public IEnumerable<UserRoleModel> GetList()
        {
            return _Istaffobj.GetUserRoleList();
        }

        public UserRoleModel GetRoleId(int id)
        {
            return _Istaffobj.GetRoleById(id);

        }

        public UserRoleModel InsertRole(UserRoleModel model)
        {
            return _Istaffobj.AddUserRole(model);
        }

        public UserRoleModel Update(UserRoleModel model)
        {
            return _Istaffobj.UpdateUserRole(model);
        }
    }
}
