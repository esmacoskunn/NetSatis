﻿using FluentValidation;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Validations
{
    public class CariValidator : AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu alanı Boş Geçilemez.");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı alanı Boş Geçilemez.");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili kişi alanı Boş Geçilemez.");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura  alanı Boş Geçilemez.");
            RuleFor(p => p.EMail).EmailAddress().WithMessage("Girdiğiniz e-mail adresi geçersiz.");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto alanı 0'dan küçük olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk limiti 0'dan küçük olamaz.");

        }


    }

}
