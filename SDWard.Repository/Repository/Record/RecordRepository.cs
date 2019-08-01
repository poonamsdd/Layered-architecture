using SDWard.Repository.BaseRepository;
using SDWard.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using AutoMapper;
using SDWard.Repository.UnitOfWork;
using SDWard.Repository.Repository.Department;

namespace SDWard.Repository.Repository.Record
{
    public class RecordRepository : GenericRepository<RecordSet_tbl_Poonam>, IRecordRepository
    {
        private readonly IUOW _iuow;
       
        private readonly IDepartmentRepository _dept;
        public RecordRepository(IUOW iuow, IDepartmentRepository dept) : base(iuow.DbContext())
        {
            this._iuow = iuow;
            
            _dept = dept;
        }
        public RecordModel AddRecord(RecordModel model)
        {
           base.Add(Mapper.Map<RecordModel, RecordSet_tbl_Poonam>(model));
            _iuow.SaveChanges();
            _iuow.Dispose();
            return model;
        }

        public RecordModel GetRecordByID(int id)
        {
            //var obj = from x in _staff.GetStaffList() join y in _dept.GetDeptList() on x.DeptId equals y.DeptId select x;
            //return (from x in base.GetList().Where(w => ((w.RecordId == id) && (w.IsDeleted == false)))
            //        join y in _patient.GetPatientList() on x.RecordId equals y.PatientId
            //        join z in obj on x.DoctorId equals z.StaffId
            //        select new RecordModel()
            //        {
            //            RecordId = x.RecordId,
            //            PatientId = x.PatientId,
            //            DoctorId = x.DoctorId,
            //            DiseaseName = x.DiseaseName,                        
            //            Medicines=x.Medicines,
            //            RoomNo=x.RoomNo,
            //            AdmitDate = x.AdmitDate,
            //            DischargeDate = x.DischargeDate                       
            //        }).FirstOrDefault();

            return Mapper.Map<RecordSet_tbl_Poonam, RecordModel>(base.GetById(id));
        }

        public List<RecordModel> GetRecordList()
        {
            return Mapper.Map<IEnumerable<RecordSet_tbl_Poonam>,IEnumerable <RecordModel>>(base.GetList()).ToList();
        }

        
        public RecordModel UpdateRecord(RecordModel model)
        {
            base.Update(Mapper.Map<RecordModel, RecordSet_tbl_Poonam>(model));
            _iuow.SaveChanges();
            _iuow.Dispose();
            return model;
        }
    }
}
