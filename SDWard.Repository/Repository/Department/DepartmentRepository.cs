using AutoMapper;
using SDWard.Entity.Entities;
using SDWard.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using SDWard.Repository.UnitOfWork;
using SDWard.Data.Infrastructure;

namespace SDWard.Repository.Repository.Department
{
    public class DepartmentRepository : GenericRepository<Department_tbl_poonam>,IDepartmentRepository
    {
        private readonly IUOW _iuow;
        public DepartmentRepository(IUOW iuow) : base(iuow.DbContext())
        {
            this._iuow = iuow;
        }

        public DepartmentModel AddDept(DepartmentModel model)
        {
            base.Add(Mapper.Map<DepartmentModel, Department_tbl_poonam>(model));
            _iuow.SaveChanges();
            _iuow.Dispose();
            return model;
        }

        public DepartmentModel DeleteDept(int id)
        {
            var DeleteDept = base.GetById(id);
           // var DeleteDept = _object.Where(x => x.DeptId == id).FirstOrDefault();
            if (DeleteDept == null)
            {
                return null;
            }
            base.Delete(DeleteDept);
            _iuow.SaveChanges();
            _iuow.Dispose();
            return Mapper.Map<Department_tbl_poonam, DepartmentModel>(DeleteDept);
        }

        public DepartmentModel GetDeptById(int id)
        {

            return Mapper.Map<Department_tbl_poonam, DepartmentModel>(base.GetById(id));
        }

        public List<DepartmentModel> GetDeptList()
        {
            return AutoMapper.Mapper.Map<IEnumerable<Department_tbl_poonam>, IEnumerable<DepartmentModel>>(GetList()).ToList();
        }

        public DepartmentModel UpdateDept(DepartmentModel se)
        {
            var obj = AutoMapper.Mapper.Map<DepartmentModel, Department_tbl_poonam>(se);
            base.Update(obj);
            _iuow.SaveChanges();
            _iuow.Dispose();
            return se;
        }
    }
}
