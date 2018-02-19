using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Auto.Entidades;

namespace Test.Auto.Repositorio
{
   public class MarcaRepositorio: Repositorio<Marca>, IMarcaRepositorio
    {
          public MarcaRepositorio()
          {

          }
          private readonly DbContext _dbContext;
          public MarcaRepositorio(DbContext context)
        {
            _dbContext = context;
        }        

          public IEnumerable<Marca> GetMarcas()
          {
              //IQueryable<Marca> marcasSet = _dbContext.Set<Marca>();
              //var result = (from m in marcasSet
              //              select new ViewModelPortal
              //              {

              //              }).ToList();

              return _dbContext.Set<Marca>().ToList();
          }

    }
}
