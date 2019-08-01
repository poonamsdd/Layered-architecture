using AutoMapper;
using SDWard.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.Mappers
{
   public static  class AutoMapper
    {
        public static  void AutoIni()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<User_tbl_Poonam, UserModel>();
                c.CreateMap<UsersRole_tbl_poonam, UserRoleModel>();
                c.CreateMap<UserModel, User_tbl_Poonam>();
                c.CreateMap<UserRoleModel, UsersRole_tbl_poonam>();
                c.CreateMap<DepartmentModel, Department_tbl_poonam>();
                c.CreateMap<Department_tbl_poonam, DepartmentModel>();
                c.CreateMap<RecordSet_tbl_Poonam, RecordModel>();
                c.CreateMap<RecordModel, RecordSet_tbl_Poonam>();
                c.CreateMap<BillingModel, Billing_table_Poonam>();
                c.CreateMap<Billing_table_Poonam, BillingModel>();
                c.CreateMap<Verification_poonam, VerifyModel>();
                c.CreateMap<VerifyModel, Verification_poonam>();
                c.CreateMap<Poonam_Patientschedule, PatientScheduleModel>();
                c.CreateMap<PatientScheduleModel, Poonam_Patientschedule>();
                c.CreateMap<HealthNotesModel, HealthNotes_Poonam>();
                c.CreateMap<HealthNotes_Poonam, HealthNotesModel>();
            });
        }
    }
}
