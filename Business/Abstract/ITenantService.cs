using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITenantService
    {
        List<Tenant> GetAllTenants();
        List<Tenant> GetTenantsByLocaiton(int locationId);
        List<Tenant> GetTenantByFirstName(string firstName);
        void Add(Tenant tenant);
        void Update(Tenant tenant);
        void Delete(Tenant tenant);
    }
}
