using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.NHibernate
{
    public class NhWorkerDal:IWorkerDal
    {
        
        public List<Worker> GetAllWorkers(Expression<Func<Worker, bool>> filter = null)
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker{WorkerId = 01,
                    DepartmentId = 01,
                    Title = "Aslan Oğlum",
                    FirstName = "Mustafa Taha",
                    LastName = "BOZKURT",
                    GsmNumber = "+905353220043",
                    PhoneNumber = "02744767165",
                    InternalPhoneNumber = "4343"}
            };
            return workers;
        }

        public List<Worker> GetAllWorkerDetail(Expression<Func<Worker, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAllLocations(Expression<Func<Worker, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAllDepartments(Expression<Func<Worker, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAllTenants(Expression<Func<Worker, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAllCompanies(Expression<Func<Worker, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAllTenantDetails(Expression<Func<Worker, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Worker GetWorker(Expression<Func<Worker, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Worker worker)
        {
            throw new NotImplementedException();
        }

        public void Update(Worker worker)
        {
            throw new NotImplementedException();
        }

        public void Delete(Worker worker)
        {
            throw new NotImplementedException();
        }
    }
}
