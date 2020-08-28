using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        //RuleFor(p => p.FirstName).NotEmpty().WithMessage("Çalışan Adı boş olamaz.");

        public CompanyValidator()
        {
            RuleFor(p => p.CompanyName).NotEmpty().WithMessage("Firma İsmi Boş Olamaz.");
            
        }
       
    }
}
