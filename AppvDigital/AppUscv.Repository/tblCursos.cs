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
    
    public partial class tblCursos
    {
        public int id { get; set; }
        public Nullable<int> fkCurso { get; set; }
        public Nullable<int> fkInstitucion { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaTermino { get; set; }
        public Nullable<int> fkPersonal { get; set; }
        public Nullable<int> Evidencia { get; set; }
    
        public virtual catCurso catCurso { get; set; }
        public virtual catDocumentos catDocumentos { get; set; }
        public virtual catInstitucionSuperior catInstitucionSuperior { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}
