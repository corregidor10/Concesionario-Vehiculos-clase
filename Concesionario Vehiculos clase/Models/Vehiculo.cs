//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Concesionario_Vehiculos_clase.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int IdTipo { get; set; }
    
        public virtual Tipo Tipo { get; set; }
    }
}
