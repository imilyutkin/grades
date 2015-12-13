using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GradePointAverage.BaseRepository.Entity.Contracts;
using GradePointAverage.BaseRepository.Repository.Contracts;

namespace GradePointAverage.BaseRepository.Repository.Impl
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected DbContext Context
        {
            get
            {
//                return Context.Current;
                return null;
            }
        }
        public ICollection<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity InsertOrUpdate(TEntity entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                //                Context.Entry(entity).State = EntityState.Added;
                entity = Context.Set<TEntity>().Add(entity);
            }
            else
            {
                Context.Entry(entity).State = EntityState.Modified;
            }
            Context.SaveChanges();
            return entity;
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void RemoveById(int id)
        {
            TEntity entity = Context.Set<TEntity>().Find(id);
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public ICollection<TEntity> GetBy(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }
    }
}
