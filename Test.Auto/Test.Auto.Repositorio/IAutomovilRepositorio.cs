using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Auto.Entidades;

namespace Test.Auto.Repositorio
{
    public interface IAutomovilRepositorio : IRepositorio<Automovil>
    {
        List<Automovil> GetFechasList(int cod_modelo);
        IEnumerable<Automovil> GetAutomoviles(int? marca, int? modelo, int? kmDesde, int? kmHasta, int? anio, decimal? precioDesde, decimal? precioHasta);
        Automovil GetAutomovilVendedor(int id_Auto);
    }
}
