using MarketDB.Core.Entities;
using MarketDB.DataAccess.Context;
using MarketDB.UI.UIHelper;
using Microsoft.EntityFrameworkCore;

namespace MarketDB.UI
{
    public partial class frmSatisIslemleriForm : Form
    {
        private readonly IDbContextFactory<MarketDbContext> _dbContextFactory;
        private bool tuketiciTelNoFormatlamaDevamEdiyor = false;

        public frmSatisIslemleriForm(IDbContextFactory<MarketDbContext> dbContextFactory)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory;
        }

        private void frmSatisIslemleriForm_Load(object sender, EventArgs e)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var marketler = context.Markets.ToList();
            marketler.Insert(0, new Marketler() { Id = 0, MarketAdi = "Market Seçilmedi" });

            cmbMarket.DisplayMember = nameof(Marketler.MarketAdi);
            cmbMarket.ValueMember = nameof(Marketler.Id);
            cmbMarket.DataSource = marketler;

        }

        private void txtTuketiciTelNo_TextChanged(object sender, EventArgs e)
        {
            if (tuketiciTelNoFormatlamaDevamEdiyor) { return; }
            tuketiciTelNoFormatlamaDevamEdiyor = true;
            try
            {
                if (txtTuketiciTelNo.Text.Length < 10) return;
                string formatliTelNo = TextBoxHelper.TelNoFormatKontrol(txtTuketiciTelNo.Text);
                txtTuketiciTelNo.Text = formatliTelNo;

                lblTuketiciAdiSoyadi.Text = "Tüketici Seçilmedi";
                using var context = (_dbContextFactory.CreateDbContext());
                var tuketici = context.Customers.FirstOrDefault(c => c.TuketiciTelNo == txtTuketiciTelNo.Text.Replace(" ", ""));
                if (tuketici == null)
                {
                    MessageBox.Show("Bu Telefon Numarasında Kayıtlı Tüketici Yok. Bilgilerinizi Kontrol Edip Tekrar Giriniz.");
                    return;
                }
                lblTuketiciAdiSoyadi.Text = tuketici.AdSoyad;
            }
            finally
            {
                tuketiciTelNoFormatlamaDevamEdiyor = false;
            }

        }

        private void rbUye_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton secilenRb = (RadioButton)sender;
            if (!secilenRb.Checked) return;
            if (secilenRb == rbUye)
            {

                txtTuketiciTelNo.Enabled = true;

            }
            else if (secilenRb == rbUyeOl)
            {
                var frm = new frmTuketiciIslemleriForm(_dbContextFactory);
                frm.ShowDialog();
                rbUye.Checked = true;
            }
            else if (secilenRb == rbUyeOlmadanDevamEt)
            {
                txtTuketiciTelNo.Enabled = false;
                txtTuketiciTelNo.Text = "";
                lblTuketiciAdiSoyadi.Text = "Tüketici Seçilmedi";

            }
        }

        private void cmbMarket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarket.SelectedValue == null) { return; }
            using var context = _dbContextFactory.CreateDbContext();
            int seciliMarketId = (int)cmbMarket.SelectedValue;
            var subeler = context.Branches
                .Where(s => s.MarketId == seciliMarketId)
                .Include(s => s.Mahalle)
                    .ThenInclude(s => s.Ilce)
                        .ThenInclude(s => s.Il)
                .ToList();
            subeler.Insert(0, new Sube(){
                Id = 0, SubeAdi = "Şube Seçilmedi"
                ,Mahalle = new Mahalle() { Id = 0, MahalleAdi = "", Ilce = new Ilce() { Id = 0, IlceAdi = "", Il = new Il() { Id = 0, IlAdi = "" } } }
                ,Market = null! });
          
            cmbSube.DataSource = subeler;
            cmbSube.DisplayMember = "SubeIlIlceMahalle";
            cmbSube.ValueMember = "Id";
        }

       
    }
}
