using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.ComplexType;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTenantDetailsDal : EfEntityRepositoryBase<TenantDetail, PHONESContext>, ITenantDetailsDal
    {
    }
}
