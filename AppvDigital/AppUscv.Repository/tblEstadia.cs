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
    
    public partial class tblEstadia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEstadia()
        {
            this.catDocumentos = new HashSet<catDocumentos>();
        }
    
        public int id { get; set; }
        public string nombreEstadia { get; set; }
        public Nullable<int> fkProgramaEducativo { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaTermino { get; set; }
        public string NoAlumnos { get; set; }
        public string NoHoras { get; set; }
        public string NombreEmpresaoInstitucion { get; set; }
        public string PuntosaResolver { get; set; }
        public string estatus { get; set; }
        public string ConsiderarCurriculum { get; set; }
        public Nullable<int> fkPersona { get; set; }
        public Nullable<int> fkidProduccion { get; set; }
        public string Objetivo { get; set; }
        public string ResumenProyecto { get; set; }
        public string BeneficiosObtenidos { get; set; }
    
        public virtual CatProduccion CatProduccion { get; set; }
        public virtual catProgramaEducativo catProgramaEducativo { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<catDocumentos> catDocumentos { get; set; }
    }
}
