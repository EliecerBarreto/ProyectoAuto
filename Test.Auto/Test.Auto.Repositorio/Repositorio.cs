using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Auto.Repositorio
{
   public class Repositorio<T> : IRepositorio<T> where T : class
    {

        private readonly DbContext _dbContext;
        public Repositorio()
        {
            
        }
        public Repositorio(DbContext context)
        {
            _dbContext = context;        
        }

        public IQueryable<T> AsQuearyable()
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        public IEnumerable<T> GetAll()
        {
          return  _dbContext.Set<T>();
        }

        public IEnumerable<T> Buscar(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
            return _dbContext.Set<T>().Where(predicado);
        }

        public T GetById(int Id)
        {
          return  _dbContext.Set<T>().Find(Id);
        }
    }
}
