using SDWard.Repository.Repository.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Schedule
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _sch;
        public ScheduleService(IScheduleRepository sch)
        {
            _sch = sch;
        }
        public PatientScheduleModel Delete(int id)
        {
            return _sch.DeleteSchedule(id);
        }

        public PatientScheduleModel GetById(int id)
        {
            return _sch.GetScheduleById(id);
        }

        public IEnumerable<PatientScheduleModel> GetList()
        {
            return _sch.GetScheduleList();
        }

        public PatientScheduleModel Insert(PatientScheduleModel model)
        {
            model.AppointmentStartTime = DateTime.Now;
            model.AppointmentEndTime = DateTime.Now;
            return _sch.AddSchedule(model);
        }

        public PatientScheduleModel Update(PatientScheduleModel model)
        {
            return _sch.UpdateSchedule(model);
        }
    }
}
