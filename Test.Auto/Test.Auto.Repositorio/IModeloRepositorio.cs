using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Auto.Entidades;

namespace Test.Auto.Repositorio
{
    public interface IModeloRepositorio: IRepositorio<Modelo>
    {
        IEnumerable<Modelo> GetModelos(int cod_marca);
    }
}
