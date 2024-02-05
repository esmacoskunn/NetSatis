using FluentValidation;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Validations
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {

            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu alanı Boş Geçilemez.");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı alanı Boş Geçilemez.").Length(5, 50).WithMessage("Stok alanı adı 5 ile 50 karekter arasında olabilir");
            RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod  alanı Boş Geçilemez.");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı - 1 alanı 0'dan küçük olamaz");
            RuleFor(p => p.AlisFiyatı2).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı - 2 alanı  0'dan küçük olamaz");
            RuleFor(p => p.AlisFiyatı3).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı - 3 alanı  0'dan küçük olamaz");
            RuleFor(p => p.SatisFiyatı1).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı - 1 alanı  0'dan küçük olamaz");
            RuleFor(p => p.SatisFiyatı2).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı - 2 alanı  0'dan küçük olamaz");
            RuleFor(p => p.SatisFiyatı3).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı - 3 alanı  0'dan küçük olamaz");


        }
    }
}
