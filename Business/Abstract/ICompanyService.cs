using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAllCompany();
        List<Company> GetByCompanyName(string companyName);
        void Add(Company company);
        void Update(Company company);
        void Delete(Company company);
    }
}
