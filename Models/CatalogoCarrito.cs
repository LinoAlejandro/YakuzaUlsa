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
    
    public partial class CatalogoCarrito
    {
        public int idCatalogo { get; set; }
        public int cantidadCatalogo { get; set; }
        public decimal subTotalCatalogo { get; set; }
        public int idPlatillo { get; set; }
        public int idCarrito { get; set; }
    
        public virtual Carrito Carrito { get; set; }
        public virtual Platillo Platillo { get; set; }
    }
}