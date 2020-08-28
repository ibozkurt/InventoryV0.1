using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class WorkerValidator : AbstractValidator<Worker>
    {
        public WorkerValidator()
        {
            
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("Çalışan Adı boş olamaz.");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Çalışan Soyadı boş olamaz.");
            RuleFor(p => p.GsmNumber).NotEmpty().WithMessage("Çalışanın GSM Numarası Girilmesi Zorunlundur.");
            RuleFor(p => p.InternalPhoneNumber).NotEmpty().WithMessage("Çalışanın Dahili Numarası Girilmesi Zorunlundur.");
            RuleFor(p => p.Title).NotEmpty().WithMessage("Çalışanın Title Girilmesi Zorunlundur.");
        }
    }
}
