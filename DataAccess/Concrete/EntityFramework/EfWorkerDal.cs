using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWorkerDal : EfEntityRepositoryBase<Worker,PHONESContext>,IWorkerDal
    {
 
    }
}


