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
    
    public partial class catInstitucionPremiosDistincio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public catInstitucionPremiosDistincio()
        {
            this.tblDistincionesPersonal = new HashSet<tblDistincionesPersonal>();
        }
    
        public int id { get; set; }
        public string institucion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDistincionesPersonal> tblDistincionesPersonal { get; set; }
    }
}
