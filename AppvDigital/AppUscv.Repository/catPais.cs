//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUscv.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class catPais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public catPais()
        {
            this.catEstado = new HashSet<catEstado>();
            this.tblSuperacionProfecional = new HashSet<tblSuperacionProfecional>();
            this.tblProduccionAcademica = new HashSet<tblProduccionAcademica>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<catEstado> catEstado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSuperacionProfecional> tblSuperacionProfecional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduccionAcademica> tblProduccionAcademica { get; set; }
    }
}
