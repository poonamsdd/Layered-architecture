using SDWard.Repository.IRepository;
using SDWard.Repository.Repository.Department;
using SDWard.Service.Services.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Department
{
    public class DeptService : IDeptService
    {
        private readonly IDepartmentRepository _dept;
        public DeptService(IDepartmentRepository dept)
        {
            this._dept = dept;
        }
        public DepartmentModel Delete(int id)
        {
            return _dept.DeleteDept(id);
        }

        public DepartmentModel GetDeptId(int id)
        {
            return _dept.GetDeptById(id);
        }

        public IEnumerable<DepartmentModel> GetList()
        {
            return _dept.GetDeptList();
        }

        public DepartmentModel InsertDept(DepartmentModel model)
        {
           return  _dept.AddDept(model);
        }

        public DepartmentModel Update(DepartmentModel model)
        {
           return _dept.UpdateDept(model);
        }
    }
}
