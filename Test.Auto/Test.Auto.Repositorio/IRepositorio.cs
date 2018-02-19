using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Test.Auto.Repositorio
{
    public interface IRepositorio<T> where T :  class
    {
        IQueryable<T> AsQuearyable();
        IEnumerable<T> GetAll();
        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado);
        T GetById(int Id);
    }
}
