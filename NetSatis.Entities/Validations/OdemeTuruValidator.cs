using FluentValidation;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Validations
{
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Kasa kodu alanı Boş Geçilemez.");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Kasa adi  alanı Boş Geçilemez.");

        }
    }
}
