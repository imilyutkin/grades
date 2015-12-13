using System;
using System.Collections.Generic;
using GradePointAverage.BaseRepository.Entity.Contracts;

namespace GradePointAverage.BaseRepository.Repository.Contracts
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        ICollection<TEntity> GetAll();

        TEntity InsertOrUpdate(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        ICollection<TEntity> GetBy(Func<TEntity, bool> predicate);
    }
}
