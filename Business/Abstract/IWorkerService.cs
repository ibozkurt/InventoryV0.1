using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IWorkerService
    {
        List<Worker> GetAllWorkers();
        List<Worker> GetWorkersByLocaiton(int locationId);
        List<Worker> GetWorkerByFirstName(string firstName);
        void Add(Worker worker);
        void Update(Worker worker);
        void Delete(Worker worker);
    }
}
