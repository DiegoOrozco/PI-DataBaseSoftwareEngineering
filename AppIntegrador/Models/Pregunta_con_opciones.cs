//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppIntegrador.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pregunta_con_opciones
    {
        public string Codigo { get; set; }
        public string TituloCampoObservacion { get; set; }
    
        public virtual Escalar Escalar { get; set; }
        public virtual Pregunta Pregunta { get; set; }
        public virtual Pregunta_con_opciones_de_seleccion Pregunta_con_opciones_de_seleccion { get; set; }
        public virtual Si_no_nr Si_no_nr { get; set; }
    }
}