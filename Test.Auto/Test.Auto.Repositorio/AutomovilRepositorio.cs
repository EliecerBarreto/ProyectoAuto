using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Auto.Entidades;

namespace Test.Auto.Repositorio
{
    public class AutomovilRepositorio : Repositorio<Automovil>, IAutomovilRepositorio
    {
        private readonly DbContext _dbContext;

        public AutomovilRepositorio(DbContext context)
        {
            _dbContext = context;
        }

        public List<Automovil> GetFechasList(int cod_modelo)
        {
            return _dbContext.Set<Automovil>().Where(x => x.id_modelo == cod_modelo).ToList();
        }

        public IEnumerable<Automovil> GetAutomoviles(int? marca, int? modelo, int? kmDesde, int? kmHasta, int? anio, decimal? precioDesde, decimal? precioHasta)
        {
            return _dbContext.Set<Automovil>().Where(a =>
                    (marca == null || a.Modelo.cod_marca == marca)
                    && (modelo == 0 || modelo == null || a.id_modelo == modelo)
                    && (kmDesde == null || kmHasta == null || (a.km >= kmDesde && a.km <= kmHasta))
                    && (anio == 0 || anio == null || a.anio == anio)
                    && ((precioDesde == null || precioHasta == null || (a.precio >= precioDesde && a.precio <= precioHasta)))
                    ).ToList();
        }

        public Automovil GetAutomovilVendedor(int id_Auto)
        {       
            return _dbContext.Set<Automovil>().Where(a => a.Id_auto == id_Auto).FirstOrDefault();
        }
    }
}
