using Ninject.Modules;
using SDWard.Repository.IRepository;
using SDWard.Repository.Repository;
using SDWard.Repository.Repository.Department;
using SDWard.Repository.Repository.HealthNotes;
using SDWard.Repository.Repository.Record;
using SDWard.Repository.Repository.Schedule;
using SDWard.Repository.Repository.User;
using SDWard.Repository.Repository.UserRole;
using SDWard.Repository.Repository.Verification;
using SDWard.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Service
{
    public class NinjectServiceInit : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IDepartmentRepository>().To<DepartmentRepository>();
            Bind<IUserRoleRepository>().To<UserRoleRepository>();
            Bind<IRecordRepository>().To<RecordRepository>();
            Bind<IBilling_Repository>().To <BillingRepository>();
            Bind<IVerificationRepository>().To<VerificationRepository>();
            Bind<IScheduleRepository>().To<ScheduleRepository>();
            Bind<IHeathRepository>().To<HealthRepository>();      
            // new Repository.NinjectRepoInit();
            Kernel.Load(new[] { new SDWard.Repository.NinjectRepoInit() });

        }
    }
}
