//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Auto.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Modelo
    {
        public Modelo()
        {
            this.Automovil = new HashSet<Automovil>();
        }
    
        public int id { get; set; }
        public int cod_marca { get; set; }
        public string nombre_modelo { get; set; }
    
        public virtual ICollection<Automovil> Automovil { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
