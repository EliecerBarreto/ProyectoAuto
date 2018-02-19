using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Test.Auto.Entidades;

namespace Test.Auto.Presentacion.Models
{
    public class ViewModelPortal
    {
        [Display(Name = "Marcas")]
        public List<Marca> Marcas { get; set; }

        [Display(Name = "Modelos")]
        public List<Modelo> Modelos { get; set; }

        [Display(Name = "Años")]
        public List<Automovil> automovil { get; set; }

    }
}