using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Department
{
   public interface IDeptService
    {
        DepartmentModel InsertDept(DepartmentModel model);
        DepartmentModel Update(DepartmentModel model);
        DepartmentModel Delete(int id);
        DepartmentModel GetDeptId(int id);
        IEnumerable<DepartmentModel> GetList();
    }
}
