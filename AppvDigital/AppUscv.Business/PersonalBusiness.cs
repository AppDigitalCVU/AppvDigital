using AppUscv.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cargamos las clases del dominio correspondiente
using AppUscv.Domain;
//cargamos las clases del repositorio
using AppUscv.Repository;
using AppUscv.Repository.Infrastructure.Contract;


using System.Linq.Expressions;


namespace AppUscv.Business
{
    public class PersonalBusiness:IPersonalBusiness
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly PersonalRepository personaRepository;

        public PersonalBusiness(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            personaRepository = new PersonalRepository(unitOfWork);
        }


        /// <summary>
        /// este metodo se encarga de obtener todos los datos de la tabla personal
        /// </summary>
        /// <returns>regresa una lista de la tablapersonal con todos los datos de la tabla</returns>
        public List<PersonalDomainModel> GetAllPersonal()
        {
            List<PersonalDomainModel> personal =  personaRepository.GetAll().Select(p => new PersonalDomainModel { }).ToList();
            return personal;
        }


        /// <summary>
        /// este metodo se encarga de actualizar o insertar los datos de tblPersonal
        /// </summary>
        /// <param name="personal">un objeto del tipo tblpersonal vinculado a personalDomainModel</param>
        /// <returns>retorna un valor true o false en caso de realziarse la operación adecuada.</returns>
        public bool AddUpdatePersonal(PersonalDomainModel personal)
        {
            bool respuesta = false;

            if (personal.id > 0)
            {
                tblPersonal tblPersonal = personaRepository.SingleOrDefault(p => p.id == personal.id);
                if (tblPersonal != null)
                {
                    tblPersonal.nombre = personal.nombre;
                    tblPersonal.apellidoPaterno = personal.apellidoPaterno;
                    tblPersonal.apellidoMaterno = personal.apellidoMaterno;
                    personaRepository.Update(tblPersonal);
                    respuesta = true;
                }
            }
            else
            {
                tblPersonal tblPersonal = new tblPersonal();
                tblPersonal.nombre = personal.nombre;
                tblPersonal.apellidoPaterno = personal.apellidoPaterno;
                tblPersonal.apellidoMaterno = personal.apellidoMaterno;
                personaRepository.Insert(tblPersonal);
                respuesta = true;
            }
            return respuesta;
        }


    }
}
