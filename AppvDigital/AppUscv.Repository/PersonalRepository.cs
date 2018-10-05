using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppUscv.Repository.Infrastructure;
using AppUscv.Repository.Infrastructure.Contract;
namespace AppUscv.Repository
{
    public class PersonalRepository: BaseRepository<tblPersonal>
    {

        public PersonalRepository(IUnitOfWork unitOfWork) : base(unitOfWork) 
        {

        }
    }
}
