using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adi soyadi bos kecilmez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("mail adresi bos kecilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos kecilemez");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]").WithMessage("En az birt buyuk karakter olmalidir");
            RuleFor(x => x.WriterPassword).Matches(@"[a-z]").WithMessage("En az bir kucuk karkter olmalidir");
            RuleFor(x => x.WriterPassword).Matches(@"[0-9]").WithMessage("en az bir rakam grilmeli");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("lutfen en az 2 karakter giriniz ");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("lutfen maximum 50 karkater giriniz");

        }
    }
}