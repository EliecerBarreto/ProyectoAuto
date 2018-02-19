using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Auto.Entidades;
using Test.Auto.Presentacion.Models;
using Test.Auto.Repositorio;
//using Repository = Test.Auto.Repositorio;

namespace Test.Auto.Presentacion.Controllers
{
    public class PortalController : Controller
    {
        public PortalController()
        {

        }
        private deautos_test_netEntities db=new deautos_test_netEntities();        
        private IMarcaRepositorio _marcaRepositorio = new MarcaRepositorio(new deautos_test_netEntities());
        private IModeloRepositorio _modeloRepositorio = new ModeloRepositorio(new deautos_test_netEntities());
        private IVendedorRepositorio _vendedorRepositorio = new VendedorRepositorio(new deautos_test_netEntities());
        private IAutomovilRepositorio _automovilRepositorio = new AutomovilRepositorio(new deautos_test_netEntities());
        //
        // GET: /Home/       

        public PortalController(IAutomovilRepositorio automovilRepositorio,
         IMarcaRepositorio marcaRepositorio,
        IVendedorRepositorio vendedorRepositorio, IModeloRepositorio modeloRepositorio)
        {
            _automovilRepositorio = automovilRepositorio;
            _marcaRepositorio = marcaRepositorio;
            _vendedorRepositorio = vendedorRepositorio;
            _modeloRepositorio = modeloRepositorio;
        }

        public ActionResult Index()
        {
            ViewModelPortal vm = new ViewModelPortal();
            var marcas = new List<Marca>();
            marcas = _marcaRepositorio.GetMarcas().ToList();
            vm.Marcas = marcas;

            //var modelos = new List<Modelo>();
            //modelos = _modeloRepositorio.GetModelos(1).ToList();
            //vm.Modelos = null;

            //var anios = new List<Automovil>();
            //anios = _automovilRepositorio.GetFechasList(1).ToList();
            //vm.automovil = anios;


            return View("index", vm);
        }

        [HttpGet]
        public JsonResult comboModelo(int cod_marca)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var modelos = new List<Modelo>();
            modelos = _modeloRepositorio.GetModelos(cod_marca).ToList();
            var data = modelos.Select(d => new
                {
                    id = d.id,
                    nombre_modelo = d.nombre_modelo,
                });
            return Json(data, JsonRequestBehavior.AllowGet);
        }

         [HttpGet]
        public JsonResult comboModeloAnios(int cod_modelo)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var anios = new List<Automovil>();
            anios = _automovilRepositorio.GetFechasList(cod_modelo).ToList();
            var data = anios.Select(d => new
                {
                   anios=d.anio
                });
            return Json(data, JsonRequestBehavior.AllowGet);
        }        

        public IEnumerable<Marca> GetMarcas()
        {
            return null;
        }       

    }
}
