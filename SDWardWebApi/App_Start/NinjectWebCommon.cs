[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SDWardWebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SDWardWebApi.App_Start.NinjectWebCommon), "Stop")]
namespace SDWardWebApi.App_Start
{
 using Microsoft.Web.Infrastructure.DynamicModuleHelper;
 using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using SDWard.Service.Services.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
    using SDWard.Service.Services.Record;
    using SDWard.Service.Services.Bill;
    using SDWard.Service.Services.User;
    using SDWard.Service.Services.UserRole;
    using SDWard.Service.Services.Veification;
    using SDWard.Service.Services.Schedule;
    using SDWard.Service.Services.HealthCare;

    public class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                var modules = new List<INinjectModule>
                {
                    new SDWard.Service.NinjectServiceInit()
                };
                kernel.Load(modules);
                // Install our Ninject-based IDependencyResolver into the Web API config
                GlobalConfiguration.Configuration.DependencyResolver = new Ninject.Web.WebApi.NinjectDependencyResolver(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IDeptService>().To<DeptService>();
            kernel.Bind<IRoleService>().To<RoleService>();
            kernel.Bind<IRecordService>().To<RecordService>();
            kernel.Bind<IBillService>().To<BillService>();
            kernel.Bind<IVerifyService>().To<VerifyService>();
            //kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IScheduleService>().To<ScheduleService>();
            kernel.Bind<IHealthService>().To<HealthService>();

        }
    }

    
}
