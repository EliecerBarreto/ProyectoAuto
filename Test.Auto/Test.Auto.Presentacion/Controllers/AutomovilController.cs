using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Auto.Entidades;
using Test.Auto.Repositorio;

namespace Test.Auto.Presentacion.Controllers
{
    public class AutomovilController : Controller
    {
        public AutomovilController()
        {
        }
        private deautos_test_netEntities db = new deautos_test_netEntities();        

        private IAutomovilRepositorio _automovilRepositorio = new AutomovilRepositorio(new deautos_test_netEntities());
        public AutomovilController(IAutomovilRepositorio automovilRepositorio)
        {
            _automovilRepositorio = automovilRepositorio;           
        }
        //
        // GET: /Automovil/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAutomovilList(int? Marcas, int? Modelos, int? kmDesde, int? kmHasta, int? automovil, decimal? precioDesde, decimal? precioHasta)
        {
            return View(_automovilRepositorio.GetAutomoviles(Marcas, Modelos, kmDesde, kmHasta, automovil, precioDesde, precioHasta));
        }

       
        public ActionResult GetAutomovilVendedor(int id_Auto)
        {
            db.Configuration.ProxyCreationEnabled=false;
           var datos =_automovilRepositorio.GetAutomovilVendedor(id_Auto);
           var data = new Vendedor
           {
               apellido = datos.Vendedor.apellido,
               nombre = datos.Vendedor.nombre,
               e_mail = datos.Vendedor.e_mail,
               telefono = datos.Vendedor.telefono
           };
            return View("_getAutomovilVendedor", data);
        }

    }
}
