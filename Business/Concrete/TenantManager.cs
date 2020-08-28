using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TenantManager : ITenantService
    {
        private ITenantDal _tenantDal;

        public TenantManager(ITenantDal tenantDal)
        {
            _tenantDal = tenantDal;
        }

        public List<Tenant> GetAllTenants()
        {
            return _tenantDal.GetAllTenants();
        }

        public List<Tenant> GetTenantsByLocaiton(int locationId)
        {
            return _tenantDal.GetAllTenants(p => p.LocationId == locationId);
        }

        public List<Tenant> GetTenantByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public void Add(Tenant tenant)
        {
            ValidationTool.Validate(new TenantValidator(), tenant);

            _tenantDal.Add(tenant);
        }

        public void Update(Tenant tenant)
        {
            ValidationTool.Validate(new TenantValidator(), tenant);

            _tenantDal.Update(tenant);
        }

        public void Delete(Tenant tenant)
        {

            try
            {
                _tenantDal.Delete(tenant);
            }
            catch
            {
                throw new Exception("Silme İşlemi Gerçekleşmedi!!!");
            }
        }
    }
}
