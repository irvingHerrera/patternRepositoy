using SchoolRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SchoolRepository.Repository.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal DbContext context;
        internal DbSet<TEntity> dbset;

        public Repository(DbContext context)
        {
            this.context = context;
            this.dbset = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            dbset.Add(entity);
        }

        public TEntity Get(int id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = dbset;
            return query.ToList();
        }

        public void Remove(TEntity entity)
        {
            dbset.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            dbset.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
