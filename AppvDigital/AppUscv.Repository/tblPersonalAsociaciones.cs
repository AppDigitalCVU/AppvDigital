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
    
    public partial class tblPersonalAsociaciones
    {
        public int id { get; set; }
        public int fkPersonal { get; set; }
        public int fkAsociacion { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string tipoParticipacion { get; set; }
    
        public virtual catAsociaciones catAsociaciones { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}
