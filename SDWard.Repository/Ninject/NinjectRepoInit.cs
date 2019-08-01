using Ninject.Modules;
using SDWard.Data.Infrastructure;
using SDWard.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Repository
{
    public class NinjectRepoInit : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataContext>().To<DataContext>();
            Bind<IUOW>().To<UOW>();
        }
    }
}
