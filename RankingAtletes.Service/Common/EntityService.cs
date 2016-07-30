using RankingAtletes.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RankingAtletes.Service
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        protected IContext _context;
        protected IDbSet<T> _dbset;

        public EntityService(IContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }


        public virtual void Create(T entity)
        {
            IfIsNullArgumentNullException(entity);

            _dbset.Add(entity);
            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            IfIsNullArgumentNullException(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            IfIsNullArgumentNullException(entity);
            _dbset.Remove(entity);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable();
        }

        private void IfIsNullArgumentNullException(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
        }

    }
}
