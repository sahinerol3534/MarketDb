using MarketDB.Core.Entities;
using MarketDB.DataAccess.Context;
using Microsoft.Data.SqlClient;
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
           
            bool marketAdiGirisKontrol = string.IsNullOrWhiteSpace(txtMarketAdi.Text);
            CultureInfo trCulture = new CultureInfo("tr-TR");
            if (marketAdiGirisKontrol)
            {
                MessageBox.Show("Market Adı Girin!!");
                return;
            }
            string marketAdi = txtMarketAdi.Text.ToUpper(trCulture);
            Marketler market = new Marketler()
            {
                
                MarketAdi = marketAdi
            };
            try
            {
                using var context = _contextFactory.CreateDbContext();
                if (context.Markets.Any(m => m.MarketAdi == marketAdi))
                {
                    MessageBox.Show("Market Adı Kayıtlı!");
                    txtMarketAdi.Text = "";
                    btnMarketSave.Enabled = false;
                    return;
                }

                context.Markets.Add(market);
                context.SaveChanges();
                MessageBox.Show("Market Kaydı Yapıldı!");          
                txtMarketAdi.Text = "";
                btnMarketSave.Enabled = false;
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && sqlEx.Number == 2627) 
                { 
                    MessageBox.Show($"{marketAdi}  Mevcut! \n Market Adını Kontrol Edip Tekrar Giriniz! ");
                }
                else
                {
                    MessageBox.Show("Veri Tabanı Hatası! Sistem Sorumlusuna Danışın!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik hata: " + ex.Message);
            }

        }

        private void txtMarketAdi_TextChanged(object sender, EventArgs e)
        {
            btnMarketSave.Enabled = true;
        }
       
       
    }
}
