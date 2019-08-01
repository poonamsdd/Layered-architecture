using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Schedule
{
   public interface IScheduleService
    {
        PatientScheduleModel Insert(PatientScheduleModel model);
        PatientScheduleModel Update(PatientScheduleModel model);
        PatientScheduleModel Delete(int id);
        PatientScheduleModel GetById(int id);
        IEnumerable<PatientScheduleModel> GetList();
    }
}
