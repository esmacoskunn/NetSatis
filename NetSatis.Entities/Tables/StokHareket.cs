﻿using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class StokHareket: IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string BarkodTuru { get; set; }
        public string Barkod { get; set; }
        public string Birim { get; set; }
        public decimal Miktar { get; set; }
        public int Kdv { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal IndirimOrani { get; set; }
        public decimal IndirimTutar { get; set; }
        public decimal ToplamTutar { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string SeriNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Acıklama { get; set; }



    }
}
