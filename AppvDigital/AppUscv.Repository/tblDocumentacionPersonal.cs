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
    
    public partial class tblDocumentacionPersonal
    {
        public int id { get; set; }
        public int fkCatDocumento { get; set; }
        public int fkPersonal { get; set; }
        public string numeroDocumento { get; set; }
        public Nullable<System.DateTime> vigenciaDocumento { get; set; }
        public string identificador { get; set; }
    
        public virtual catDocumentos catDocumentos { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}
