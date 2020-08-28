using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAllWorkers(Expression<Func<T, bool>> filter = null);//Kullanıcı Filtre Verirse Verdiği Filtreye Göre Getir Filtre Vermezse Tamamını Getir.
        List<T> GetAllWorkerDetail(Expression<Func<T, bool>> filter = null);

        List<T> GetAllLocations(Expression<Func<T, bool>> filter = null);
        List<T> GetAllDepartments(Expression<Func<T, bool>> filter = null);
        List<T> GetAllCompanies(Expression<Func<T, bool>> filter = null);

        List<T> GetAllTenantDetails(Expression<Func<T, bool>> filter = null);
        List<T> GetAllTenants(Expression<Func<T, bool>> filter = null);


        T GetWorker(Expression<Func<T, bool>> filter);// Mutlaka Filtreli Getirecek
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
