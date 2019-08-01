using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.Repository.Schedule
{
    public interface IScheduleRepository
    {
        PatientScheduleModel AddSchedule(PatientScheduleModel schedue);
        PatientScheduleModel GetScheduleById(int Id);
        PatientScheduleModel UpdateSchedule(PatientScheduleModel schedule);
        PatientScheduleModel DeleteSchedule(int Id);
        List<PatientScheduleModel> GetScheduleList();

    }
}
