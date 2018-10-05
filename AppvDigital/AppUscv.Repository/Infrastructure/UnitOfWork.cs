using AppUscv.Repository.Infrastructure.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUscv.Repository.Infrastructure
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly bdGestionDocentesEntities _dbContext;

        public UnitOfWork()
        {
            _dbContext = new bdGestionDocentesEntities();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}
