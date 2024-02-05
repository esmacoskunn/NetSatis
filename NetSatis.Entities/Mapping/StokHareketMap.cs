using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Mapping
{
    public class StokHareketMap : EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //sql tarafında bir birer artması için var burası 
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.Hareket).HasMaxLength(10);
            this.Property(p => p.StokKodu).HasMaxLength(12);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.BarkodTuru).HasMaxLength(15);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.Birim).HasMaxLength(15);
            this.Property(p => p.Miktar).HasPrecision(12, 3);
            this.Property(p => p.BirimFiyat).HasPrecision(12, 2);
            this.Property(p => p.IndirimOrani).HasPrecision(5, 2);
            this.Property(p => p.IndirimTutar).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.DepoKodu).HasMaxLength(12);
            this.Property(p => p.DepoAdi).HasMaxLength(30);
            this.Property(p => p.SeriNo).HasMaxLength(15);
            this.Property(p => p.Acıklama).HasMaxLength(200);

            this.ToTable("StokHareketleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.Birim).HasColumnName("Birim");
            this.Property(p => p.Miktar).HasColumnName("Miktar");
            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.BirimFiyat).HasColumnName("BirimFiyat");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.IndirimTutar).HasColumnName("IndirimTutar");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            this.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            this.Property(p => p.SeriNo).HasColumnName("SeriNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Acıklama).HasColumnName("Acıklama");
        }
    }
}
