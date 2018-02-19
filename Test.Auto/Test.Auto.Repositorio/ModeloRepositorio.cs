using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Auto.Entidades;

namespace Test.Auto.Repositorio
{
    public class ModeloRepositorio : Repositorio<Modelo>, IModeloRepositorio
    {

          public ModeloRepositorio()
          {

          }           

       private readonly DbContext _dbContext;

       public ModeloRepositorio(DbContext context)
        {
            _dbContext = context;
        }


       public IEnumerable<Modelo> GetModelos(int cod_marca)
       {
           return _dbContext.Set<Modelo>().Where(m => m.cod_marca == cod_marca).ToList();
       }
    }
}
