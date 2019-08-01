using SDWard.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Repository.BaseRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public readonly DataContext _dbContext;
        public DbSet<TEntity> _object;
        public GenericRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
            _object = _dbContext.Set<TEntity>();
        }
        public TEntity Add(TEntity entity)
        {
            return _object.Add(entity);
        }

        public TEntity Delete(TEntity entity)
        {
           return  _object.Remove(entity);
        }

        public TEntity GetById(int id)
        {
            return _object.Find(id);
        }

        public IEnumerable<TEntity> GetList()
        {
            return _object.ToList();
        }

        //public void save()
        //{
        //    _dbContext.SaveChanges();
        //}

        public void Update(TEntity entity)
        {
            _object.AddOrUpdate(entity);
        }
    }
}
