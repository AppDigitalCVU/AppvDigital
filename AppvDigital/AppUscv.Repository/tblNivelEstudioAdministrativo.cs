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
    
    public partial class tblNivelEstudioAdministrativo
    {
        public int fkDatosLaboralesAdmin { get; set; }
        public int fkEstudio { get; set; }
        public Nullable<System.DateTime> fechaInicioEstudio { get; set; }
        public Nullable<System.DateTime> fechaObtencionGrado { get; set; }
        public string numeroCedula { get; set; }
        public Nullable<System.DateTime> fechaTerminoEstudio { get; set; }
        public Nullable<int> fkInstitucionSuperior { get; set; }
        public Nullable<int> titulo { get; set; }
        public Nullable<int> cedula { get; set; }
        public Nullable<int> certificado { get; set; }
        public Nullable<int> fkArea { get; set; }
        public Nullable<int> fkDisciplina { get; set; }
        public Nullable<int> fkStatusEstudio { get; set; }
    
        public virtual catDocumentos catDocumentos { get; set; }
        public virtual catDocumentos catDocumentos1 { get; set; }
        public virtual catDocumentos catDocumentos2 { get; set; }
        public virtual catInstitucionSuperior catInstitucionSuperior { get; set; }
        public virtual tblDatosLaboralesAdministrativos tblDatosLaboralesAdministrativos { get; set; }
        public virtual tblEstudio tblEstudio { get; set; }
    }
}
