using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Repository.BaseRepository
{
    public interface IGenericRepository<TEntity> where TEntity :class
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        TEntity Delete(TEntity entity);
       // IQueryable<TEntity> Query();
        IEnumerable<TEntity> GetList();
        TEntity GetById(int id);
       // void save();

    }
}
