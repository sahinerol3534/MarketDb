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
            iller.Insert(0, new Il() { Id = 0, IlAdi = "IL Seçilmedi" });
            cmbIl.DataSource = iller;
            cmbIl.DisplayMember= "IlAdi";
            cmbIl.ValueMember="Id";
        }
        public static void ComboBoxIlceGetir
            (int ilId, ComboBox cmbIlce, IDbContextFactory<MarketDbContext> contextFactory)
        {
            using var context = contextFactory.CreateDbContext();
            var ilceler = context.Towns.Where(x => x.IlId == ilId).ToList();
            ilceler.Insert(0, new Ilce() { Id = 0, IlceAdi = "İlçe Seçilmedi", Il=null! });
            cmbIlce.DataSource = ilceler;
            cmbIlce.DisplayMember = "IlceAdi";
            cmbIlce.ValueMember = "Id";
        }

        public static void ComboBoxMahalleGetir
            (int ilceId, ComboBox cmbMahalle, IDbContextFactory<MarketDbContext> contextFactory)
        {
            using var context= contextFactory.CreateDbContext();
            var mahalleler=context.Districts.Where(m=>m.IlceId==ilceId).ToList();
            mahalleler.Insert(0, new Mahalle() { Id=0, MahalleAdi="Mahalle Seçilmedi", Ilce=null! });
            cmbMahalle.DataSource = mahalleler;
            cmbMahalle.DisplayMember = "MahalleAdi";
            cmbMahalle.ValueMember = "Id";
        }

    }
}
    