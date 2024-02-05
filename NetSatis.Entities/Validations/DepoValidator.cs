using FluentValidation;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Validations
{
    public class DepoValidator : AbstractValidator<Depo>
    {

        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu alanı Boş Geçilemez.");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo adi  alanı Boş Geçilemez.");
        }
    }
}
