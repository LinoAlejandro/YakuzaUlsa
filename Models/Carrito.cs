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
    
    public partial class Carrito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carrito()
        {
            this.CatalogoCarrito = new HashSet<CatalogoCarrito>();
        }
    
        public int idCarrito { get; set; }
        public int idUsuario { get; set; }
        public decimal totalCarrito { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatalogoCarrito> CatalogoCarrito { get; set; }
    }
}
