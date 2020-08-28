using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TenantValidator : AbstractValidator<Tenant>
    {
        public TenantValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("Ad Kısmı Boş Olamaz.");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Soyad Kısmı Boş Olamaz");
            RuleFor(p => p.GsmNumber).NotEmpty().WithMessage("GSM Numarası Boş Olamaz");
            RuleFor(p=>p.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası Boş Olamaz");
            RuleFor(p => p.Title).NotEmpty().WithMessage("Ünvan Boş Olmaz");
        }
    }
}
