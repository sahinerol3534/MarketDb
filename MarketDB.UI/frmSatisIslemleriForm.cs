using MarketDB.Business;
using MarketDB.Core.Entities;
using MarketDB.DataAccess.Context;
using MarketDB.UI.UIHelper;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Globalization;

namespace MarketDB.UI
{
    public partial class frmSatisIslemleriForm : Form
    {
        private readonly IDbContextFactory<MarketDbContext> _dbContextFactory;
        private readonly OdemeTuruHesabi _odemeTuruHesabi;
        private bool tuketiciTelNoFormatlamaDevamEdiyor = false;
        private Satis? satis;
        private int? tuketiciId;
        private BindingList<SatisKalemi> SatisKalemleriGeciciListe = new BindingList<SatisKalemi>();

        public frmSatisIslemleriForm(IDbContextFactory<MarketDbContext> dbContextFactory)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory;
            _odemeTuruHesabi = new OdemeTuruHesabi();
        }



        private void frmSatisIslemleriForm_Load(object sender, EventArgs e)
        {
            ComboBoxHelper.ComboBoxKrediKartiGetir(cmbKrediKartlari, _dbContextFactory);
            cmbMarket.Enabled = false;
            cmbSube.Enabled = false;
            chkKrediKarti.Enabled = false;
            chkNakit.Enabled = false;
            cmbKategori.Enabled = false;
            cmbTaksitSayisi.Enabled = false;
            dgvSatisKalemleriGosterimi.AutoGenerateColumns = false;
            btnKalemleriKaydet.Enabled = false;

            DgvKolonEkle(nameof(SatisKalemi.UrunAdi), "Ürün Adı");
            DgvKolonEkle(nameof(SatisKalemi.Miktar), "Miktar");
            DgvKolonEkle(nameof(SatisKalemi.BirimFiyat), "Birim Fiyat");
            DgvKolonEkle(nameof(SatisKalemi.KalemToplami), "Satır Toplamı");
            DgvKolonEkle(nameof(SatisKalemi.IndirimTutari), "İndirim");
            DgvKolonEkle(nameof(SatisKalemi.KdvTutari), "KDV");
            DgvKolonEkle(nameof(SatisKalemi.OdemeAdi), "Ödeme Şekli");
            DgvKolonEkle(nameof(SatisKalemi.TaksitSayisi), "Taksit Sayısı");
            DgvKolonEkle(nameof(SatisKalemi.TaksitTutari), "Taksit Tutarı");

            List<Marketler> marketler;
            {
                using var context = _dbContextFactory.CreateDbContext();
                marketler = context.Markets.ToList();
            }

            marketler.Insert(0, new Marketler() { Id = 0, MarketAdi = "Bir Market Seçin." });
            cmbMarket.DisplayMember = nameof(Marketler.MarketAdi);
            cmbMarket.ValueMember = nameof(Marketler.Id);
            cmbMarket.DataSource = marketler;
            ComboBoxHelper.ComboBoxKategoriGetir(cmbKategori, _dbContextFactory);
            dgvSatisKalemleriGosterimi.DataSource = SatisKalemleriGeciciListe;

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

                lblTuketiciAdiSoyadi.Text = "Bir Tüketici Seçin.";
                using var context = (_dbContextFactory.CreateDbContext());
                var tuketici = context.Customers.FirstOrDefault(c => c.TuketiciTelNo == txtTuketiciTelNo.Text.Replace(" ", ""));
                if (tuketici == null)
                {
                    MessageBox.Show("Bu Telefon Numarasında Kayıtlı Tüketici Yok. Bilgilerinizi Kontrol Edip Tekrar Giriniz.");
                    return;
                }
                lblTuketiciAdiSoyadi.Text = tuketici.AdSoyad;
                tuketiciId = tuketici.Id;
                cmbMarket.Enabled = true;
                cmbSube.Enabled = true;
            }
            finally
            {
                tuketiciTelNoFormatlamaDevamEdiyor = false;
            }

        }

        private void rbUye_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton secilenRb = (RadioButton)sender;
            if (!secilenRb.Checked) { return; }
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

                cmbMarket.Enabled = true;
                cmbSube.Enabled = true;
                tuketiciId = null;
                txtTuketiciTelNo.Enabled = false;
                txtTuketiciTelNo.Text = "";
                lblTuketiciAdiSoyadi.Text = null;
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
            subeler.Insert(0, new Sube()
            {
                Id = 0,
                SubeAdi = "Bir Şube Seçin."
                ,
                Mahalle = new Mahalle() { Id = 0, MahalleAdi = "", Ilce = new Ilce() { Id = 0, IlceAdi = "", Il = new Il() { Id = 0, IlAdi = "" } } }
                ,
                Market = null!
            });

            cmbSube.DataSource = subeler;
            cmbSube.DisplayMember = "SubeIlIlceMahalle";
            cmbSube.ValueMember = "Id";
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {

            if (cmbMarket.SelectedValue is not int secilenMarketId || secilenMarketId == 0)
            {

                MessageBox.Show("Bir Market Seçiniz!");
                return;
            }

            if (cmbSube.SelectedValue is not int secilenSubeId || secilenSubeId == 0)
            {
                MessageBox.Show("Bir Şube Seçiniz!");
                return;
            }

            satis = new Satis
            {
                SubeId = secilenSubeId
                ,
                SatisTarihi = dtpSatisTarihi.Value
                ,
                FisNo = txtFisNo.Text
                ,
                TuketiciId = tuketiciId
            };
            using var context = _dbContextFactory.CreateDbContext();
            context.Sales.Add(satis);
            context.SaveChanges();
            btnOnay.Enabled = false;
            MessageBox.Show("Satış Bilgileri Tamam. Satış Kalemlerine Geçiniz!");
            cmbKategori.Enabled = true;
        }

        private void txtFisNo_TextChanged(object sender, EventArgs e)
        {
            string fisNo = txtFisNo.Text;
        }

        private void dtpSatisTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrun.SelectedValue is int seciliUrunId && seciliUrunId != 0)
            {

                btnSatisKalemiEkle.Enabled = true;
            }
            else
            {
                btnSatisKalemiEkle.Enabled = false;
            }
        }

        private void btnSatisKalemiEkle_Click(object sender, EventArgs e)
        {
            
            if (cmbUrun.SelectedItem is not Urun seciliUrun)
            {
                MessageBox.Show("Bir Ürün Girin!");
                return;
            }

            bool urunMiktari = decimal.TryParse(txtMiktar.Text.Replace(",", "."), CultureInfo.InvariantCulture, out decimal miktar);
            if (!urunMiktari || miktar <= 0)
            {
                MessageBox.Show("Ürün Miktarı Girin!");
                return;
            }
            bool urunFiyati = decimal.TryParse(txtBirimFiyat.Text.Replace(",", "."), CultureInfo.InvariantCulture, out decimal urunBirimFiyati);
            if (!urunFiyati || urunBirimFiyati <= 0)
            {
                MessageBox.Show("Ürün Fiyatı Girin!");
                return;
            }
            decimal.TryParse(txtIndirimTutari.Text.Replace(",", "."), CultureInfo.InvariantCulture, out decimal indirim);
            decimal.TryParse(txtKdvTutari.Text.Replace(",", "."), CultureInfo.InvariantCulture, out decimal kdv);

            int? taksitSayisi = null;
            decimal? taksitTutari = null;
            string kalemOdemeStatu = "";

            if (rdPesin.Checked)
            {
                kalemOdemeStatu = "Peşin";
            }
            else
            {
                kalemOdemeStatu = "Taksit";
            }
            using var context = _dbContextFactory.CreateDbContext();
            CultureInfo trCulture = new CultureInfo("tr-TR");
            var odemeSekilleri = context.PaymentStatuses.FirstOrDefault(s => s.OdemeAdi == kalemOdemeStatu.ToUpper(trCulture));
            if (odemeSekilleri == null)
            {
                MessageBox.Show
                    (
                    "Ödeme şekli bulunamadı. Sistem sorumlusuna haber verin!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                return;
            }
            int odemeSekli = odemeSekilleri.Id;
            decimal kalemToplami = SatisKalemiHesabi.KalemToplamiHesapla(urunBirimFiyati, miktar, indirim);

            if (rdTaksit.Checked)
            {
                if (cmbTaksitSayisi.SelectedItem is not int seciliTaksit || seciliTaksit == 0)
                {
                    MessageBox.Show("Taksit Sayısı Seçin!");
                    return;
                }
                taksitSayisi = seciliTaksit;
                taksitTutari = SatisKalemiHesabi.TaksitTutariHesapla
                    (urunBirimFiyati, miktar, seciliTaksit, indirim);

            }
            var satisKalemi = new SatisKalemi
            {
                UrunId = seciliUrun.Id,
                Urun = seciliUrun,
                Miktar = miktar,
                BirimFiyat = urunBirimFiyati,
                KalemToplami = kalemToplami,
                IndirimTutari = indirim,
                KdvTutari = kdv,
                TaksitSayisi = taksitSayisi,
                TaksitTutari = taksitTutari,
                OdemeSekliId = odemeSekli,
                OdemeSekli = odemeSekilleri
            };
            SatisKalemleriGeciciListe.Add(satisKalemi);
            decimal satisKalemToplamTutari = SatisKalemleriGeciciListe.Sum(t => t.KalemToplami);
            lblOdemeToplami.Text = satisKalemToplamTutari.ToString();
            btnSatisKalemiEkle.Enabled = false;
            KalemFormunuTemizle();
            btnOdemeyeGec.Enabled = true;


        }



        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNakitTutar.ReadOnly = true;
            txtNakitTutar.Enabled = false;
            chkNakit.Checked = false;
            btnKalemleriKaydet.Enabled = false;
            btnOdemeyeGec.Enabled = false;
            if (cmbKategori.SelectedValue is not int secKategoriId || secKategoriId == 0)
            {
                cmbAltKategori.DataSource = null;
                cmbUrun.DataSource = null;
                return;
            }
            using var context = _dbContextFactory.CreateDbContext();
            var altKategoriler = context.Categories.Where(c => c.UstKategoriId == secKategoriId).ToList();
            altKategoriler.Insert(0, new Kategori()
            {
                Id = 0,
                KategoriAdi = "Alt Kategori Seçin."
            });


            cmbAltKategori.DataSource = altKategoriler;
            cmbAltKategori.DisplayMember = nameof(Kategori.KategoriAdi);
            cmbAltKategori.ValueMember = nameof(Kategori.Id);

        }


        private void cmbAltKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbAltKategori.SelectedValue is not int seciliAltKategoriId || seciliAltKategoriId == 0)
            {
                cmbUrun.DataSource = null;
                return;
            }

            using var context = _dbContextFactory.CreateDbContext();
            var urunler = context.Products.Where(p => p.KategoriId == seciliAltKategoriId).ToList();
            urunler.Insert(0, new Urun()
            {
                Id = 0,
                UrunAdi = "Ürün Seçin.",
                UrunCinsi = "",
            });

            cmbUrun.DataSource = urunler;
            cmbUrun.DisplayMember = nameof(Urun.UrunAdi);
            cmbUrun.ValueMember = nameof(Urun.Id);

        }


        private void rdTaksit_CheckedChanged(object sender, EventArgs e)
        {
            List<int> taksitSayisiListesi = new List<int>() { 0, 2, 3, 4, 5, 6 };
            cmbTaksitSayisi.DataSource = taksitSayisiListesi;
            cmbTaksitSayisi.Enabled = rdTaksit.Checked;

        }

        private void rdPesin_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void KalemFormunuTemizle()
        {
            cmbKategori.SelectedIndex = -1;
            cmbAltKategori.DataSource = null;
            cmbUrun.DataSource = null;
            txtMiktar.Text = "";
            txtBirimFiyat.Text = "";
            txtIndirimTutari.Text = "";
            txtKdvTutari.Text = "";
            rdPesin.Checked = true;
        }

        private void DgvKolonEkle(string propertyAdi, string baslik)
        {
            var kolon = new DataGridViewTextBoxColumn();
            kolon.DataPropertyName = propertyAdi;
            kolon.HeaderText = baslik;
            kolon.Name = "col" + propertyAdi;
            dgvSatisKalemleriGosterimi.Columns.Add(kolon);
        }

        private void btnKalemleriKaydet_Click(object sender, EventArgs e)
        {
            if (!chkNakit.Checked && !chkKrediKarti.Checked)
            {
                btnKalemleriKaydet.Enabled = false;
                MessageBox.Show("Bir Ödeme Türü Seçin!");
                return;
            }

            if (satis == null)
            {
                MessageBox.Show("Satış Bilgileri Bölümünü Tamamlayınız!");
                return;
            }
            if (SatisKalemleriGeciciListe.Count == 0)
            {
                MessageBox.Show("Satış Kalemi Ekleyin!");
                return;
            }
            decimal kalemlerToplami = SatisKalemleriGeciciListe.Sum(t => t.KalemToplami);
            decimal.TryParse(txtNakitTutar.Text.Replace(",", "."), CultureInfo.InvariantCulture, out decimal nakitTutar);
            if (nakitTutar > kalemlerToplami)
            {
                MessageBox.Show("Girilen Nakit Tutar, Toplam Tutardan Fazla Olamaz!\nThe cash amount must not exceed the total!");
                return;
            }
            int? kartId = null;
            decimal kartTutar = _odemeTuruHesabi.OdemeTuruneGoreTutarHesapla(kalemlerToplami, nakitTutar);
            if (cmbKrediKartlari.SelectedValue is int seciliKartId && seciliKartId != 0 &&  kartTutar > 0) {kartId = seciliKartId; }
            if (kartTutar > 0 && kartId == null)
            {
                MessageBox.Show("Please select a card!\nBir Kart Seçin!");
                return;
            }
            var odemeDetay = new OdemeDetay
            {
                SatisId = satis.Id,
                KartId = kartId,
                NakitTutar = nakitTutar,
                KartTutar = kartTutar
            };
            
            using var context = _dbContextFactory.CreateDbContext();

            foreach (SatisKalemi satisKalemi in SatisKalemleriGeciciListe)
            {
                var dbSatisKalemi = new SatisKalemi
                {
                    SatisId = satis.Id,
                    UrunId = satisKalemi.UrunId,
                    Miktar = satisKalemi.Miktar,
                    BirimFiyat = satisKalemi.BirimFiyat,
                    KalemToplami = satisKalemi.KalemToplami,
                    IndirimTutari = satisKalemi.IndirimTutari,
                    KdvTutari = satisKalemi.KdvTutari,
                    TaksitSayisi = satisKalemi.TaksitSayisi,
                    TaksitTutari = satisKalemi.TaksitTutari,
                    OdemeSekliId = satisKalemi.OdemeSekliId,
                };
                context.SaleLineItems.Add(dbSatisKalemi);
            }

            context.SaveChanges();
            MessageBox.Show("Fiş Kaydedildi!");
            btnKalemleriKaydet.Enabled = false;
            cmbKategori.Enabled = false;
            SatisKalemleriGeciciListe.Clear();

        }



        private void chkNakit_CheckedChanged(object sender, EventArgs e)
        {
            cmbKrediKartlari.SelectedIndex = 0;
            txtNakitTutar.Text = 0.ToString();
            OdemeEtiketleriniGuncelle();
        }

        private void chkKrediKarti_CheckedChanged(object sender, EventArgs e)
        {
            cmbKrediKartlari.SelectedIndex = 0;
            txtNakitTutar.Text = 0.ToString();
            OdemeEtiketleriniGuncelle();
        }
        private void txtNakitTutar_TextChanged(object sender, EventArgs e)
        {        
            OdemeEtiketleriniGuncelle();
        }

        private void btnOdemeyeGec_Click(object sender, EventArgs e)
        {
            btnSatisKalemiEkle.Enabled = false;
            chkKrediKarti.Enabled = true;
            chkNakit.Enabled = true;
            OdemeEtiketleriniGuncelle();
            if (!chkNakit.Checked && !chkKrediKarti.Checked)
            {
                 MessageBox.Show("Ödeme Türü Seçiniz");
            }
        }
        private void OdemeEtiketleriniGuncelle()
        {
            btnKalemleriKaydet.Enabled = true;
            decimal kalemlerToplami = SatisKalemleriGeciciListe.Sum(t => t.KalemToplami);
            if (chkNakit.Checked && !chkKrediKarti.Checked)
            {
               
                txtNakitTutar.ReadOnly = true;
                txtNakitTutar.Enabled = false;
                txtNakitTutar.Text = kalemlerToplami.ToString();
                lblKartOdemesi.Text = "";
                lblOdemeToplami.Text = kalemlerToplami.ToString(); 
                cmbKrediKartlari.Enabled = false;
            }
            else if (!chkNakit.Checked && chkKrediKarti.Checked)
            {
                txtNakitTutar.Enabled = false;
                cmbKrediKartlari.Enabled = true;
                txtNakitTutar.ReadOnly = true;
                txtNakitTutar.Text = 0.ToString();
                lblKartOdemesi.Text = kalemlerToplami.ToString();
                lblOdemeToplami.Text = kalemlerToplami.ToString();
            }
            else if (chkNakit.Checked && chkKrediKarti.Checked)
            {
                
                cmbKrediKartlari.Enabled = true;
                txtNakitTutar.Enabled = true;
                txtNakitTutar.ReadOnly = false;
                decimal.TryParse(txtNakitTutar.Text.Replace(",", "."), CultureInfo.InvariantCulture, out decimal nakitTutarKismi);
                decimal kartOdemesi = _odemeTuruHesabi.OdemeTuruneGoreTutarHesapla(kalemlerToplami, nakitTutarKismi);
                txtNakitTutar.Text = nakitTutarKismi.ToString();
                lblKartOdemesi.Text = kartOdemesi.ToString();
                lblOdemeToplami.Text = kalemlerToplami.ToString();
            }
            else
            {
                txtNakitTutar.Enabled = false;
                txtNakitTutar.ReadOnly = true;
                lblOdemeToplami.Text = kalemlerToplami.ToString();
                lblKartOdemesi.Text = "";
                txtNakitTutar.Text = 0.ToString();
                cmbKrediKartlari.Text = "";
                cmbKrediKartlari.Enabled = false;
            }
        }

     
    }
}


