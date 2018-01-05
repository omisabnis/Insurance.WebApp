using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Data.Common
{
    public class GenericRepository<T> : IRepository<T> where T: class
    {
        protected readonly IDbSet<T> _DbSet;
        protected InsuranceDbContext _context;

        public GenericRepository(InsuranceDbContext context)
        {
            _context = context;
            _DbSet = _context.Set<T>();

        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
