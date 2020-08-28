using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.ComplexType;

namespace Business.Concrete
{
    public class WorkerDetailManager : IWorkerDetailService
    {
        private IWorkerDetailsDal _workerDetailsDal;

        public WorkerDetailManager(IWorkerDetailsDal workerDetailsDal)
        {
            _workerDetailsDal = workerDetailsDal;
        }

        public List<WorkerDetail> GetAllWorkerDetail()
        {
            using (PHONESContext context = new PHONESContext())
            {
                var result = from w in context.Workers
                             join l in context.Locations on w.LocationId equals l.LocationId
                             join d in context.Departments on w.DepartmentId equals d.DepartmentId

                             select new WorkerDetail()
                             {
                                 WorkerId = w.WorkerId,
                                 LocationId = l.LocationId,
                                 DepartmentId = d.DepartmentId,
                                 DepartmentName = d.DepartmentName,
                                 LocationName = l.LocationName,
                                 FirstName = w.FirstName,
                                 LastName = w.LastName,
                                 Title = w.Title,
                                 GsmNumber = w.GsmNumber,
                                 PhoneNumber = w.PhoneNumber,
                                 InternalPhoneNumber = w.InternalPhoneNumber
                             };
                return result.ToList();
            }
        }

        public List<WorkerDetail> GetByLocationDetails(int locationId)
        {

            return _workerDetailsDal.GetAllWorkerDetail(p => p.LocationId == locationId);
        }

        public List<WorkerDetail> GetWorkerByFirstNameDetail(string firstName)
        {

            return _workerDetailsDal.GetAllWorkerDetail(p => p.FirstName.ToLower().Contains(firstName.ToLower()));
        }

        public List<WorkerDetail> GetByWorkerDetails(int workerId)
        {
            throw new NotImplementedException();
        }
    }
}
