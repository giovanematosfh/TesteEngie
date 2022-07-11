using EstudoFullStack.Domain.Entity.Base;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace EstudoFullStack.Domain.Interface
{
    public interface IRepositoryBase<TEntity, TId>
         where TEntity : EntityBase
         where TId : struct
    {
        IQueryable<TEntity> GetAll();
        TEntity GetBy(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includeProperties);
        bool Exist(Func<TEntity, bool> where);
        TEntity GetById(TId id);
        TEntity Add(TEntity entity);
        TEntity Edit(TEntity entity);
        void Remove(TEntity entity);
    }
}

