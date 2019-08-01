using SDWard.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using SDWard.Data.Infrastructure;
using SDWard.Entity.Entities;
using SDWard.Repository.UnitOfWork;
using AutoMapper;

namespace SDWard.Repository.Repository.UserRole
{
    public class UserRoleRepository : GenericRepository<UsersRole_tbl_poonam>, IUserRoleRepository
    {
        private readonly IUOW _iuow;
        public UserRoleRepository(IUOW iuow) : base(iuow.DbContext())
        {
            this._iuow = iuow;
        }

        public UserRoleModel AddUserRole(UserRoleModel model)
        {
            base.Add(Mapper.Map<UserRoleModel, UsersRole_tbl_poonam>(model));
            _iuow.SaveChanges();
            _iuow.Dispose();
            return model;
        }

        public UserRoleModel DeleteUserRole(int id)
        {
            var deleteuser = base.GetById(id);
            if (deleteuser == null)
            {
                return null;
            }
            base.Delete(deleteuser);
            _iuow.SaveChanges();
            _iuow.Dispose();
            return Mapper.Map<UsersRole_tbl_poonam, UserRoleModel>(deleteuser);

        }

        public UserRoleModel GetRoleById(int id)
        {
            return Mapper.Map<UsersRole_tbl_poonam, UserRoleModel>(base.GetById(id));
        }

        public List<UserRoleModel> GetUserRoleList()
        {
            return AutoMapper.Mapper.Map<IEnumerable<UsersRole_tbl_poonam>, IEnumerable<UserRoleModel>>(GetList()).ToList();
           
        }

        public UserRoleModel UpdateUserRole(UserRoleModel se)
        {
            var obj = AutoMapper.Mapper.Map<UserRoleModel, UsersRole_tbl_poonam>(se);
            base.Update(obj);
            _iuow.SaveChanges();
            _iuow.Dispose();
            return se;

        }
    }
}
