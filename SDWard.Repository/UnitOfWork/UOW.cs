using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDWard.Data.Infrastructure;

namespace SDWard.Repository.UnitOfWork
{
    public class UOW : IUOW, IDisposable
    {
        private readonly DataContext _Db;
        public UOW(DataContext Db)
        {
            this._Db = Db;
        }
        public DataContext DbContext()
        {
            return _Db;           
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _Db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            _Db.Dispose();
            GC.SuppressFinalize(true);
        }

        public void SaveChanges()
        {
            _Db.SaveChanges();
        }
    }
}
