//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YakuzaUlsa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Precio
    {
        public int idPrecio { get; set; }
        public int idPlatillo { get; set; }
        public string descripcionPrecio { get; set; }
        public decimal cantidadPrecio { get; set; }
    
        public virtual Platillo Platillo { get; set; }
    }
}
