using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUscv.Domain
{
    public class PersonalDomainModel
    {
        public int id { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string nombre { get; set; }
        public string RFC { get; set; }
        public string homoclave { get; set; }
        public string curp { get; set; }
        public byte[] curpimagen { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string calleYNumero { get; set; }
        public string sexo { get; set; }
        public Nullable<int> fkLocalidad { get; set; }
        public Nullable<int> fkEstadoCivil { get; set; }
        public byte[] foto { get; set; }
        public Nullable<int> dependientesEconomicos { get; set; }
        public byte[] solicitudEmpleo { get; set; }
        public byte[] comprobanteDomicilio { get; set; }
        public Nullable<int> fkTipoSangre { get; set; }
        public string pasatiempo { get; set; }
        public string tipoRegimenPension { get; set; }
        public string emailPersonal2 { get; set; }
        public string emailPersonal1 { get; set; }
        public string telefonoCel { get; set; }
        public string telefonoCasa { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public Nullable<int> horasLaborales { get; set; }
        public byte[] horarioActual { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasenia { get; set; }
        public string status { get; set; }
        public string privilegio { get; set; }
        public byte[] rfcimagen { get; set; }
        public string objetivosGral { get; set; }
        public string telefonoRecados { get; set; }
        public Nullable<int> noInterno { get; set; }
        public Nullable<int> noExterno { get; set; }
    }
}
