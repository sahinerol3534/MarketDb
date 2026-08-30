using MarketDB.Core.Entities;
using MarketDB.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MarketDB.UI
{
    public partial class frmMarketIslemleriForm : Form
    {
        private readonly IDbContextFactory<MarketDbContext> _contextFactory;

        public frmMarketIslemleriForm(IDbContextFactory<MarketDbContext> contextFactory)
        {
            InitializeComponent();
            _contextFactory = contextFactory;
        }

        private void btnMarketSave_Click(object sender, EventArgs e)
        {
            btnMarketSave.Enabled = false;
            bool marketAdiGirisKontrol = string.IsNullOrWhiteSpace(txtMarketAdi.Text);
            CultureInfo trCulture = new CultureInfo("tr-TR");
            if (marketAdiGirisKontrol)
            {
                MessageBox.Show("Market Adı Girin!!");
                return;
            }

            Marketler market = new Marketler()

            {
                MarketAdi = txtMarketAdi.Text.ToUpper(trCulture),
            };

            using var context = _contextFactory.CreateDbContext();
            context.Markets.Add(market);
            context.SaveChanges();
        }

    

        private void txtMarketAdi_TextChanged(object sender, EventArgs e)
        {
            btnMarketSave.Enabled = true;
        }
    }
}
