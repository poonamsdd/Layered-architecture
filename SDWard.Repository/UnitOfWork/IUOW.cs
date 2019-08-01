using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDWard.Data.Infrastructure;

namespace SDWard.Repository.UnitOfWork
{
    public interface IUOW
    {
        void SaveChanges();
        void Dispose();
        DataContext DbContext();

    }
}
