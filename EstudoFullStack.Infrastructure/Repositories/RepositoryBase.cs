using EstudoFullStack.Domain.Entity.Base;
using EstudoFullStack.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFullStack.Infrastructure.Repositories
{
    public class RepositoryBase<TEntidade, TId> : IRepositoryBase<TEntidade, TId>
    
         where TEntidade : EntityBase
        where TId : struct
    {
        protected readonly MyContext _context;
        public RepositoryBase(MyContext context)
        {
            _context = context;
        }

        public IQueryable<TEntidade> GetAll()
        {
            return _context.Set<TEntidade>();
        }

        public TEntidade GetBy(Func<TEntidade, bool> where, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            return GetAll().FirstOrDefault(where);
        }

        public bool Exist(Func<TEntidade, bool> where)
        {
            return _context.Set<TEntidade>().Any(where);
        }

        public TEntidade Add(TEntidade entity)
        {
            var _entity = _context.Add<TEntidade>(entity);
            return _entity.Entity;
        }

        public TEntidade Edit(TEntidade entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        public void Remove(TEntidade entity)
        {
            _context.Set<TEntidade>().Remove(entity);
        }

        public TEntidade GetById(TId id)
        {
            return _context.Set<TEntidade>().Find(id);
        }
    }
}
