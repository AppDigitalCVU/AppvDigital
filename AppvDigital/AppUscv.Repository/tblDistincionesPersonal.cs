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
    
    public partial class tblDistincionesPersonal
    {
        public int fkPersonal { get; set; }
        public int fkDistinciones { get; set; }
        public int fkInstitucion { get; set; }
    
        public virtual catInstitucionPremiosDistincio catInstitucionPremiosDistincio { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}
