using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete
{
    public class WorkerManager : IWorkerService
    {
        private IWorkerDal _workerDal;

        public WorkerManager(IWorkerDal workerDal)
        {
            _workerDal = workerDal;
        }

        public List<Worker> GetAllWorkers()
        {
            return _workerDal.GetAllWorkers();
        }

        public List<Worker> GetWorkersByLocaiton(int locationId)
        {
            return _workerDal.GetAllWorkers(p => p.LocationId == locationId);
        }

        public List<Worker> GetWorkerByFirstName(string firstName)
        {
            return _workerDal.GetAllWorkers(p => p.FirstName.ToLower().Contains(firstName.ToLower()));
        }

        public void Add(Worker worker)
        {
            ValidationTool.Validate(new WorkerValidator(), worker);

            _workerDal.Add(worker);
        }

        public void Update(Worker worker)
        {
            ValidationTool.Validate(new WorkerValidator(), worker);
            _workerDal.Update(worker);
        }

        public void Delete(Worker worker)
        {
            try
            {
                _workerDal.Delete(worker);
            }
            catch
            {
                throw new Exception("Silme İşlemi Gerçekleşmedi!!!");
            }
        }
    }
}
