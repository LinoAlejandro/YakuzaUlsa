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
    
    public partial class Comentario
    {
        public int idComentario { get; set; }
        public int idCalificacion { get; set; }
        public string descripcionComentario { get; set; }
    
        public virtual Calificacion Calificacion { get; set; }
    }
}