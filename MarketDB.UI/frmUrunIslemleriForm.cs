using MarketDB.Core.Entities;
using MarketDB.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MarketDB.UI
{
    public partial class frmUrunIslemleriForm : Form
    {
        private readonly IDbContextFactory<MarketDbContext> _contextFactory;
        public frmUrunIslemleriForm(IDbContextFactory<MarketDbContext> contextFactory)
        {
            InitializeComponent();
            _contextFactory = contextFactory;

        }

        private void frmUrunIslemleriForm_Load(object sender, EventArgs e)
        {

            using var context = _contextFactory.CreateDbContext();
            var kategoriler = context.Categories.ToList();
            cmbUrunKategorisi.DataSource = kategoriler;
            cmbUrunKategorisi.DisplayMember = "KategoriAdi";
            cmbUrunKategorisi.ValueMember = "Id";

        }

        private void btnUrunSave_Click(object sender, EventArgs e)
        {
            btnUrunSave.Enabled = false;
            bool fiyatGirisKontrol = decimal.TryParse(txtUrunFiyati.Text.Replace(",", "."), NumberStyles.Float,
                CultureInfo.InvariantCulture, out decimal fiyat);
            if (!fiyatGirisKontrol)
            {
                MessageBox.Show("Geçerli bir fiyat Girin!!!!");
                return;
            }
            bool urunAdiGirisKontrol = string.IsNullOrWhiteSpace(txtUrunAdi.Text);
            CultureInfo trCulture = new CultureInfo("tr-TR");
            if (urunAdiGirisKontrol)
            {
                MessageBox.Show("Ürün Adı  Girin!!!!");
                return;
            }
            Urun urun = new Urun()
            {
                UrunAdi = txtUrunAdi.Text.ToUpper(trCulture),
                UrunMarkasi = txtUrunMarkasi.Text.ToUpper(trCulture),
                UrunFiyati = fiyat,
                UrunCinsi = txtUrunCinsi.Text.ToUpper(trCulture),
                KategoriId = Convert.ToInt32(cmbUrunKategorisi.SelectedValue)
            };

            using var context = _contextFactory.CreateDbContext();
            context.Products.Add(urun);
            context.SaveChanges();

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnUrunSave.Enabled = true;
        }
    }
}
