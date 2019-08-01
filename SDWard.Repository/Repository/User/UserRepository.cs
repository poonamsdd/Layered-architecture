using SDWard.Entity.Entities;
using SDWard.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDWard.Data.Infrastructure;
using SDWard.Repository.UnitOfWork;
using AutoMapper;
using ViewModels;

namespace SDWard.Repository.Repository.User
{
    public class UserRepository : GenericRepository<User_tbl_Poonam>, IUserRepository
    {
        private readonly IUOW _iuow;
        public UserRepository(IUOW iuow) : base(iuow.DbContext())
        {
            this._iuow = iuow;
        }
        public UserModel AddUser(UserModel model)
        {
            base.Add(Mapper.Map<UserModel, User_tbl_Poonam>(model));
            _iuow.SaveChanges();
            _iuow.Dispose();
            return model;
        }

        public UserModel DeleteUser(int id)
        {
            var del = _object.Where(x => x.UserRole == id).FirstOrDefault();
            if (del == null)
            {
                return null;
            }
            base.Delete(del);
            _iuow.SaveChanges();
            _iuow.Dispose();
            return Mapper.Map<User_tbl_Poonam, UserModel>(del);
        }

        public UserModel GetUserById(int id)
        {
            return Mapper.Map<User_tbl_Poonam, UserModel>(base.GetById(id));
        }

        public List<UserModel> GetUserList()
        {
            return Mapper.Map<IEnumerable<User_tbl_Poonam>, IEnumerable<UserModel>>(base.GetList()).ToList();

        }

        public UserModel Login(LoginModel model)
        {
            var obj = base.GetList().Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();
            return Mapper.Map< User_tbl_Poonam, UserModel>(obj);
        }

        public UserModel UpdateUser(UserModel pm)
        {
            var obj = Mapper.Map<UserModel, User_tbl_Poonam>(pm);
            base.Update(obj);
            _iuow.SaveChanges();
            _iuow.Dispose();
            return pm;
        }

        public UserModel Verify(string Email)
        {
            var obj = base.GetList().Where(x => x.Email == Email).FirstOrDefault();
            obj.VarifyBit = true;
            base.Update(obj);
            _iuow.SaveChanges();
            _iuow.Dispose();
            return Mapper.Map<User_tbl_Poonam, UserModel>(obj);
        }
        public ForgetPasswordModel FindEmail(ForgetPasswordModel model)
        {
            var obj = base.GetList().Where(x => x.Email == model.Email).FirstOrDefault();
            return new ForgetPasswordModel() { Email = obj.Email };
        }
        public string ResetPassword(ResetModel model)
        {
            var obj = base.GetList().Where(x => x.Email == model.Email).FirstOrDefault();
            if (obj!=null)
            {
                obj.Password = model.NewPassword;
                base.Update(obj);
                _iuow.SaveChanges();
                _iuow.Dispose();
            }
            return null;
        }

        public UserModel GetStaffById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetPatientById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetStaff()
        {
            return Mapper.Map<IEnumerable<User_tbl_Poonam>, IEnumerable<UserModel>>(base.GetList().Where(x => ((x.IsDeleted == false) && (x.UserRole == 4))));
        }

        public IEnumerable<UserModel> GetPatient()
        {
            return Mapper.Map<IEnumerable<User_tbl_Poonam>, IEnumerable<UserModel>>(base.GetList().Where(x => ((x.IsDeleted == false) && (x.UserRole ==5 ))));
        }
    }
}
