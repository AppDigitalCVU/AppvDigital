using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cargamos las clases de la entidad
using AppUscv.Domain;
namespace AppUscv.Business.Interface
{
    public interface IPersonalBusiness
    {
        bool AddUpdatePersonal(PersonalDomainModel personal);
        List<PersonalDomainModel> GetAllPersonal();
    }
}
