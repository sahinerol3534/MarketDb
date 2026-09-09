using MarketDB.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketDB.DataAccess.Context
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options) { }
        public DbSet<Banka> Banks { get; set; }
        public DbSet<Fatura> Invoices { get; set; }
        public DbSet<Il> Cities { get; set; }
        public DbSet<Ilce> Towns { get; set; }
        public DbSet<Kart> Cards { get; set; }
        public DbSet<Kategori> Categories { get; set; }
        public DbSet<Mahalle> Districts { get; set; }
        public DbSet<Marketler> Markets { get; set; }
        public DbSet<OdemeSekli> KindofPayments { get; set; }
        public DbSet<OdemeTuru> TypeOfPayments { get; set; }
        public DbSet<Satis> Sales { get; set; }
        public DbSet<SatisKalemi> SaleLineItems { get; set; }
        public DbSet<Sube> Branches { get; set; }
        public DbSet<Tuketici> Customers { get; set; }
        public DbSet<Urun> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // BANKALAR
            modelBuilder.Entity<Banka>(entity =>
            {
                entity.ToTable("BANKALAR");
                entity.Property(u => u.BankaAdi).HasColumnName("BANKAADI");
                entity.Property(u => u.Id).HasColumnName("BANKAID");
            });

            //FATURA
            modelBuilder.Entity<Fatura>(entity =>
            {
                entity.ToTable("FATURA");
                entity.Property(u => u.Id).HasColumnName("FATURAID");
                entity.Property(u => u.FaturaNo).HasColumnName("FATURANO");
                entity.Property(u => u.TuketiciId).HasColumnName("TUKETICIID");
                entity.Property(u => u.SatisId).HasColumnName("SATISID");
                entity.Property(u => u.FaturaTarihi).HasColumnName("FATURA_TARIHI");
            });

            // İL			
            modelBuilder.Entity<Il>(entity =>
            {
                entity.ToTable("IL");
                entity.Property(u => u.IlAdi).HasColumnName("ILADI");
                entity.Property(u => u.Id).HasColumnName("ILID");
                entity.Property(u => u.IlKodu).HasColumnName("ILKODU");
            });

            //İLÇE
            modelBuilder.Entity<Ilce>(entity =>
            {
                entity.ToTable("ILCE");
                entity.Property(u => u.IlceAdi).HasColumnName("ILCEADI");
                entity.Property(u => u.Id).HasColumnName("ILCEID");
                entity.Property(u => u.IlId).HasColumnName("ILID");
            });

            //KARTLAR
            modelBuilder.Entity<Kart>(entity =>
            {
                entity.ToTable("KARTLAR");
                entity.Property(u => u.Id).HasColumnName("KARTID");
                entity.Property(u => u.KartAdi).HasColumnName("KARTADI");
                entity.Property(u => u.BankaId).HasColumnName("BANKAID");

            });

            // KATEGORİ
            modelBuilder.Entity<Kategori>(entity =>
                {
                    entity.ToTable("KATEGORI");
                    entity.Property(u => u.Id).HasColumnName("KATEGORIID");
                    entity.Property(u => u.KategoriAdi).HasColumnName("KATEGORIADI");
                    entity.Property(u => u.UstKategoriId).HasColumnName("USTKATEGORIID");
                });

            // MAHALLE
            modelBuilder.Entity<Mahalle>(entity =>
            {
                entity.ToTable("MAHALLE");
                entity.Property(u => u.Id).HasColumnName("MAHALLEID");
                entity.Property(u => u.MahalleAdi).HasColumnName("MAHALLEADI");
                entity.Property(u => u.MahalleTuru).HasColumnName("MAHALLETURU");
                entity.Property(u => u.IlceId).HasColumnName("ILCEID");
            });

            //  MARKETLER
            modelBuilder.Entity<Marketler>(entity =>
            {
                entity.ToTable("MARKETLER");
                entity.Property(u => u.Id).HasColumnName("MARKETID");
                entity.Property(u => u.MarketAdi).HasColumnName("MARKETADI");
            });

            //SUBE
            modelBuilder.Entity<Sube>(entity =>
            {
                entity.ToTable("SUBE");
                entity.Property(u=>u.Id).HasColumnName("SUBEID");
                entity.Property(u=>u.SubeAdi).HasColumnName("SUBEADI");
                entity.Property(u=>u.MarketId).HasColumnName("MARKETID");
                entity.Property(u=>u.MahalleId).HasColumnName("MAHALLEID");

            });
                
            //  ÖDEME ŞEKLİ
            modelBuilder.Entity<OdemeSekli>(entity =>
            {
                entity.ToTable("ODEME_SEKLI");
                entity.Property(u => u.Id).HasColumnName("ODEMEID");
                entity.Property(u => u.OdemeAdi).HasColumnName("ODEMEADI");
            });

            //  ÖDEME TÜRÜ
            modelBuilder.Entity<OdemeTuru>(entity =>
            {
                entity.ToTable("ODEME_TURU");
                entity.Property(u => u.Id).HasColumnName("TURID");
                entity.Property(u => u.TurAdi).HasColumnName("TUR_ADI");
            });

            //  SATIŞ
            modelBuilder.Entity<Satis>(entity =>
            {
                entity.ToTable("SATISLAR");
                entity.Property(u => u.Id).HasColumnName("SATISID");
                entity.Property(u => u.TuketiciId).HasColumnName("TUKETICIID");
                entity.Property(u => u.SubeId).HasColumnName("SUBEID");
                entity.Property(u => u.SatisTarihi).HasColumnName("SATIS_TARIHI");
                entity.Property(u => u.SatisToplami).HasColumnName("SATIS_TOPLAMI");
                entity.Property(u => u.IndirimToplami).HasColumnName("INDIRIM_TOPLAMI");
                entity.Property(u => u.KdvToplami).HasColumnName("KDV_TOPLAMI");
                entity.Property(u => u.FisNo).HasColumnName("FIS_NO");
                entity.Property(u => u.OdemeTuruId).HasColumnName("TURID");
                entity.Property(u => u.OdemeSekliId).HasColumnName("ODEMEID");
                entity.Property(u => u.KartId).HasColumnName("KARTID");



            });


            // SATIŞ KALEMİ 
            modelBuilder.Entity<SatisKalemi>(entity =>
            {
                entity.ToTable("SATIS_KALEMI");
                entity.Property(u => u.Id).HasColumnName("KALEMID");
                entity.Property(u => u.SatisId).HasColumnName("SATISID");
                entity.Property(u => u.UrunId).HasColumnName("URUNID");
                entity.Property(u => u.Miktar).HasColumnName("MIKTAR");
                entity.Property(u => u.BirimFiyat).HasColumnName("BIRIM_FIYAT");
                entity.Property(u => u.KalemToplami).HasColumnName("KALEM_TOPLAMI");
                entity.Property(u => u.IndirimTutari).HasColumnName("INDIRIM_TUTARI");
                entity.Property(u => u.KdvTutari).HasColumnName("KDV_TUTARI");
                entity.Property(u => u.TaksitSayisi).HasColumnName("TAKSIT_SAYISI");
                entity.Property(u => u.TaksitTutari).HasColumnName("TAKSIT_TUTARI");
            });

            //  ŞUBE
            modelBuilder.Entity<Sube>(entity =>
            {
                entity.ToTable("SUBE");
                entity.Property(u => u.Id).HasColumnName("SUBEID");
                entity.Property(u => u.SubeAdi).HasColumnName("SUBEADI");
                entity.Property(u => u.MarketId).HasColumnName("MARKETID");
                entity.Property(u => u.MahalleId).HasColumnName("MAHALLEID");
            });

            // TÜKETİCİ
            modelBuilder.Entity<Tuketici>(entity =>
            {
                entity.ToTable("TUKETICI");
                entity.Property(u => u.Id).HasColumnName("TUKETICIID");
                entity.Property(u => u.TuketiciAdi).HasColumnName("ADI");
                entity.Property(u => u.TuketiciSoyadi).HasColumnName("SOYADI");
                entity.Property(u => u.TuketiciTelNo).HasColumnName("TELNO");
                entity.Property(u => u.TuketiciEmail).HasColumnName("EPOSTA");
                entity.Property(u => u.IlId).HasColumnName("ILID");
                entity.Property(u => u.IlceId).HasColumnName("ILCEID");
                entity.Property(u => u.MahalleId).HasColumnName("MAHALLEID");
            });

            // ÜRÜN 
            modelBuilder.Entity<Urun>(entity =>
            {
                entity.ToTable("URUN");
                entity.Property(u => u.UrunAdi).HasColumnName("URUNADI");
                entity.Property(u => u.Id).HasColumnName("URUNID");
                entity.Property(u => u.UrunMarkasi).HasColumnName("MARKA");
                entity.Property(u => u.UrunCinsi).HasColumnName("CINS");
                entity.Property(u => u.UrunFiyati).HasColumnName("FIYAT");
                entity.Property(u => u.KategoriId).HasColumnName("KATEGORIID");
            });

        }
    }
}
         

				
