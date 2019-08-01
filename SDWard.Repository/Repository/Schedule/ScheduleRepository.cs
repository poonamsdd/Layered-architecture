using SDWard.Entity.Entities;
using SDWard.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDWard.Data.Infrastructure;
using ViewModels;
using SDWard.Repository.UnitOfWork;
using AutoMapper;
using SDWard.Repository.Repository.User;

namespace SDWard.Repository.Repository.Schedule
{
    public class ScheduleRepository : GenericRepository<Poonam_Patientschedule>, IScheduleRepository
    {
        private readonly IUOW _uow;
        private readonly IUserRepository _user;
        public ScheduleRepository(IUOW uow, IUserRepository user) : base(uow.DbContext())
        {
            _uow = uow;
            _user = user;
        }

        public PatientScheduleModel AddSchedule(PatientScheduleModel schedue)
        {
            base.Add(Mapper.Map<PatientScheduleModel, Poonam_Patientschedule>(schedue));            
            _uow.SaveChanges();
            _uow.Dispose();
            return schedue;
        }

        public PatientScheduleModel DeleteSchedule(int Id)
        {
            var a = _object.Where(x => x.PatientId == Id).FirstOrDefault();
            if (a==null)
            {
                return null;
            }
            base.Delete(a);
            _uow.SaveChanges();
            _uow.Dispose();
           return Mapper.Map<Poonam_Patientschedule, PatientScheduleModel>(a);
        }

        public PatientScheduleModel GetScheduleById(int Id)
        {
            //var dhinchak = from x in base.GetList() join y in _user.GetPatient() on x.PatientId equals y.Id select new { PatientId = x.PatientId, PatientName = y.FName + " " + y.LName };
            //var pooja= from x in base.GetList() join y in _user.GetStaff() on x.StaffId equals y.Id select new { StaffId = x.StaffId, StaffName = y.FName + " " + y.LName };
            var obj = (from x in base.GetList() join
                        y in _user.GetPatient() on x.PatientId equals y.Id
                       join
                        z in _user.GetStaff() on x.StaffId equals z.Id
                       select new PatientScheduleModel()
                       {
                           AppointmentId = x.AppointmentId,
                           PatientId = x.PatientId,
                           PatientName = y.FName + " " + y.LName,
                           DoctorName = z.FName + " " + z.LName,
                           StaffId = x.StaffId,
                           AppointmentEndTime = x.AppointmentEndTime,
                           AppointmentStartTime = x.AppointmentStartTime
                       }).ToList();
            var obj1 = obj.Where(q => q.AppointmentId == Id).FirstOrDefault();
            return obj1;
        }

        public List<PatientScheduleModel> GetScheduleList()
        {
            var obj = (from x in base.GetList() join
                   y in _user.GetPatient() on x.PatientId equals y.Id join
                   z in _user.GetStaff() on x.StaffId equals z.Id select
                        new PatientScheduleModel()
                        {
                        AppointmentId=x.AppointmentId,
                        PatientId=x.PatientId,
                         PatientName=y.FName+" "+y.LName,
                          DoctorName=z.FName+" "+z.LName,
                          StaffId=x.StaffId,
                          AppointmentEndTime=x.AppointmentEndTime,
                           AppointmentStartTime=x.AppointmentStartTime
                        }).ToList();
            return obj;
        }

        public PatientScheduleModel UpdateSchedule(PatientScheduleModel schedule)
        {
            var a = Mapper.Map<PatientScheduleModel, Poonam_Patientschedule>(schedule);
            base.Update(a);
            _uow.SaveChanges();
            _uow.Dispose();
            return schedule;

        }
    }
}
