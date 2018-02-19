using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Auto.Entidades;

namespace Test.Auto.Repositorio
{
    public class BuscadorRepositorio
    {
        private readonly DbContext _dbContext;

        public BuscadorRepositorio(DbContext context)
        {
            _dbContext = context;
        }          

      

    }
}
