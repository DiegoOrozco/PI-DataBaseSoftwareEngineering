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
    
    public partial class Activa_por
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activa_por()
        {
            this.Periodo_activa_por = new HashSet<Periodo_activa_por>();
        }
    
        public string FCodigo { get; set; }
        public string CSigla { get; set; }
        public byte GNumero { get; set; }
        public int GAnno { get; set; }
        public byte GSemestre { get; set; }
    
        public virtual Formulario Formulario { get; set; }
        public virtual Grupo Grupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Periodo_activa_por> Periodo_activa_por { get; set; }
    }
}
