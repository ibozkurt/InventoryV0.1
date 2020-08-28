using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.ComplexType;

namespace Business.Abstract
{
    public interface IWorkerDetailService
    { 
        List<WorkerDetail> GetAllWorkerDetail();
        List<WorkerDetail> GetByLocationDetails(int locationId);
        List<WorkerDetail> GetWorkerByFirstNameDetail(string firstName);
    }
}
