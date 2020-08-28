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
    public class TenantDetailManager : ITenantDetailService
    {
        private ITenantDetailsDal _tenantDetailsDal;
        private EfTenantDetailsDal efTenantDetailsDal;

        public TenantDetailManager(ITenantDetailsDal tenantDetailsDal)
        {
            _tenantDetailsDal = tenantDetailsDal;
        }

        public TenantDetailManager(EfTenantDetailsDal efTenantDetailsDal)
        {
            this.efTenantDetailsDal = efTenantDetailsDal;
        }

        public List<TenantDetail> GetAllTenantDetails()
        {
            using (PHONESContext context = new PHONESContext())
            {
                var result = from t in context.Tenants
                             join l in context.Locations on t.LocationId equals l.LocationId
                             join c in context.Companies on t.CompanyId equals c.CompanyId

                             select new TenantDetail()
                             {
                                 TenantId = t.TenantId,
                                 LocationId = l.LocationId,
                                 CompanyId = c.CompanyId,
                                 CompanyName = c.CompanyName,
                                 LocationName = l.LocationName,
                                 FirstName = t.FirstName,
                                 LastName = t.LastName,
                                 Title = t.Title,
                                 GsmNumber = t.GsmNumber,
                                 PhoneNumber = t.PhoneNumber,
                                 InternalPhoneNumber = t.InternalPhoneNumber,
                                 Email = t.Email
                             };
                return result.ToList();
            }
        }

        public List<TenantDetail> GetByLocationTenantDetails(int locationId)
        {
            return _tenantDetailsDal.GetAllTenantDetails(p => p.LocationId == locationId);
        }

        public List<TenantDetail> GetByCompanyNameTenantDetails(string companyName)
        {
            return _tenantDetailsDal.GetAllTenantDetails(p => p.CompanyName.ToLower().Contains(companyName.ToLower()));
        }
    }
}
