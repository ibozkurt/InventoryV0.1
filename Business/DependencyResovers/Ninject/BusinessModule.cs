using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependencyResovers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITenantService>().To<TenantManager>().InSingletonScope();
            Bind<ITenantDal>().To<EfTenantDal>().InSingletonScope();

            Bind<ITenantDetailService>().To<TenantDetailManager>().InSingletonScope();
            Bind<ITenantDetailsDal>().To<EfTenantDetailsDal>().InSingletonScope();

            Bind<IDepartmentService>().To<DepartmentManager>().InSingletonScope();
            Bind<IDepartmentDal>().To<EfDepartmentDal>().InSingletonScope();

            Bind<IWorkerService>().To<WorkerManager>().InSingletonScope();
            Bind<IWorkerDal>().To<EfWorkerDal>().InSingletonScope();

            Bind<IWorkerDetailService>().To<WorkerDetailManager>().InSingletonScope();
            Bind<IWorkerDetailsDal>().To<EfWorkerDetailsDal>().InSingletonScope();

            Bind<ILocationService>().To<LocationManager>().InSingletonScope();
            Bind<ILocationDal>().To<EfLocationDal>().InSingletonScope();

            Bind<ICompanyService>().To<CompanyManager>().InSingletonScope();
            Bind<ICompanyDal>().To<EfCompanyDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();


        }
    }
}
