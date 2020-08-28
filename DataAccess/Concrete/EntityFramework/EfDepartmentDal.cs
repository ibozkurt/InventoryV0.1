using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : EfEntityRepositoryBase<Department, PHONESContext>, IDepartmentDal
    {
    }
}
