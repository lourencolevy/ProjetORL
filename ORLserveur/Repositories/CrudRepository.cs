using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.repositories
{
    // <summary>
    /// classe abstraite permettant d'avoir un Crud de base
    /// </summary>
    /// <typeparam name = "C" > Entité du contexte</typeparam>
    //   / <typeparam name = "T" > contexte configuré</typeparam>
    public abstract class CrudRepository<C, T>
    where T : EntityBase where C : DbContext, new()
    {

        private C _context = new C();
        public C Context
        {

            get { return _context; }
            set { _context = value; }
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }

        public virtual IQueryable<T> FindById(int id)
        {
            var table = _context.Set<T>();
            var entity = table.Where(c => c.Id == id);
            return entity;
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _context.Update(entity);
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }
    }
}
