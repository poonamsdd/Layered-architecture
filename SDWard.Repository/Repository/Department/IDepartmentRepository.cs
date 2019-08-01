using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.Repository.Department
{
   public  interface IDepartmentRepository
    {
        DepartmentModel AddDept(DepartmentModel model);
        DepartmentModel UpdateDept(DepartmentModel se);
        DepartmentModel DeleteDept(int id);
        List<DepartmentModel> GetDeptList();
        DepartmentModel GetDeptById(int id);
    }
}
