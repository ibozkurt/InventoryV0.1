using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.ComplexType;

namespace Business.Abstract
{
    public interface ITenantDetailService
    {
        List<TenantDetail> GetAllTenantDetails();
        List<TenantDetail> GetByLocationTenantDetails(int locationId);
        List<TenantDetail> GetByCompanyNameTenantDetails(string companyName);

    }
}
