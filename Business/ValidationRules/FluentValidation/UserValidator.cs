using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Olmamaz!");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre Boş Olamaz!");
        }
    }
}
