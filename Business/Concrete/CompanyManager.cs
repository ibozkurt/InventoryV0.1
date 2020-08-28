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
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public List<Company> GetAllCompany()
        {

            return _companyDal.GetAllCompanies();
        }

        public List<Company> GetByCompanyName(string companyName)
        {
            return _companyDal.GetAllCompanies(p => p.CompanyName.ToLower().Contains(companyName.ToLower()));
        }

        public void Add(Company company)
        {
            ValidationTool.Validate(new CompanyValidator(), company);

            _companyDal.Add(company);
        }

        public void Update(Company company)
        {
            ValidationTool.Validate(new CompanyValidator(), company);
            
            _companyDal.Update(company);
        }

        public void Delete(Company company)
        {
            try
            {
                _companyDal.Delete(company);
            }
            catch
            {
                throw new Exception("Silme İşlemi Sırasında Hata Oluştu!!!");
            }
        }
    }
}
