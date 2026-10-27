using MarketDB.Core.Entities;
using MarketDB.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace MarketDB.UI.UIHelper
{
    public static class ComboBoxHelper
    {

        public static void ComboBoxIlGetir
            (ComboBox cmbIl, IDbContextFactory<MarketDbContext> contextFactory)
        {
            using var context = contextFactory.CreateDbContext();
            var iller = context.Cities.ToList();
            iller.Insert(0, new Il() { Id = 0, IlAdi = "IL Seçin." });
            cmbIl.DataSource = iller;
            cmbIl.DisplayMember= "IlAdi";
            cmbIl.ValueMember="Id";
        }
        public static void ComboBoxIlceGetir
            (int ilId, ComboBox cmbIlce, IDbContextFactory<MarketDbContext> contextFactory)
        {
            using var context = contextFactory.CreateDbContext();
            var ilceler = context.Towns.Where(x => x.IlId == ilId).ToList();
            ilceler.Insert(0, new Ilce() { Id = 0, IlceAdi = "İlçe Seçin.", Il=null! });
            cmbIlce.DataSource = ilceler;
            cmbIlce.DisplayMember = "IlceAdi";
            cmbIlce.ValueMember = "Id";
        }

        public static void ComboBoxMahalleGetir
            (int ilceId, ComboBox cmbMahalle, IDbContextFactory<MarketDbContext> contextFactory)
        {
            using var context= contextFactory.CreateDbContext();
            var mahalleler=context.Districts.Where(m=>m.IlceId==ilceId).ToList();
            mahalleler.Insert(0, new Mahalle() { Id=0, MahalleAdi="Mahalle Seçin.", Ilce=null! });
            cmbMahalle.DataSource = mahalleler;
            cmbMahalle.DisplayMember = "MahalleAdi";
            cmbMahalle.ValueMember = "Id";
        }

        public static void ComboBoxKategoriGetir
            (ComboBox cmbKategori, IDbContextFactory<MarketDbContext>contextFactory)
        {
            using var context = contextFactory.CreateDbContext();
            var kategoriler = context.Categories.Where(c=>c.UstKategoriId == null ).ToList();
            kategoriler.Insert(0, new Kategori() { Id = 0, KategoriAdi = "Kategori Seçin." });        
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = nameof(Kategori.KategoriAdi);
            cmbKategori.ValueMember =nameof(Kategori.Id);
        }

        public static int? NullableIntOku(ComboBox comboBox)
        {
            if (comboBox.SelectedValue is int seciliDeger)
            {
                return seciliDeger;
            }
            return null;
        }

        public static void ComboBoxKrediKartiGetir (ComboBox cmbKrediKarti, IDbContextFactory<MarketDbContext> contextFactory)
        {
          bool krediKartiListesiGeldiMi = !string.IsNullOrEmpty(cmbKrediKarti.ValueMember);
            if (krediKartiListesiGeldiMi) { return; }
            using var context = contextFactory.CreateDbContext();
            var krediKartlari = context.Cards.Include(k=>k.Banka).ToList();
            krediKartlari.Insert(0, new Kart() 
            { Id = 0, KartAdi = "Bir Kart Seçin.",Banka = new Banka() { Id=0, BankaAdi =""} });
            cmbKrediKarti.DataSource = krediKartlari;
            cmbKrediKarti.DisplayMember =nameof(Kart.BankaKartlari);
            cmbKrediKarti.ValueMember = nameof(Kart.Id);
        }

        
    }
}
