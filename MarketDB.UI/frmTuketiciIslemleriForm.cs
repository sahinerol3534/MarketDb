using MarketDB.Core.Entities;
using MarketDB.DataAccess.Context;
using MarketDB.UI.UIHelper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MarketDB.UI
{
    public partial class frmTuketiciIslemleriForm : Form
    {
        private readonly IDbContextFactory<MarketDbContext> _contextFactory;

        public frmTuketiciIslemleriForm(IDbContextFactory<MarketDbContext> contextFactory)
        {
            InitializeComponent();
            _contextFactory = contextFactory;
        }

        private void frmTuketiciIslemleriForm_Load(object sender, EventArgs e)
        {
            ComboBoxHelper.ComboBoxIlGetir(cmbTuketiciIl, _contextFactory);
        }


        private void btnTuketiciSave_Click(object sender, EventArgs e)
        {

            CultureInfo trCulture = new CultureInfo("tr-TR");
            CultureInfo usCulture = new CultureInfo("en-US");
            bool tuketiciAdiGirisKontrol = string.IsNullOrWhiteSpace(txtTuketiciAdi.Text);
            if (tuketiciAdiGirisKontrol)
            {
                MessageBox.Show("Tüketici Adı girin!!");
                return;
            }

            bool tuketiciSoyadiGirisKontrol = string.IsNullOrWhiteSpace(txtTuketiciSoyadi.Text);
            if (tuketiciSoyadiGirisKontrol)
            {
                MessageBox.Show("Tüketici Soyadı Girin!!");
                return;
            }

            bool tuketiciTelNoGirisKontrol = string.IsNullOrWhiteSpace(txtTuketiciTelNo.Text);
            if (tuketiciTelNoGirisKontrol)
            {
                MessageBox.Show("Tüketici Telefon Numarası Girin!!");
                return;
            }

            int? ilId = ComboBoxHelper.NullableIntOku(cmbTuketiciIl);
            int? ilceId = ComboBoxHelper.NullableIntOku(cmbTuketiciIlce);
            int? mahalleId = ComboBoxHelper.NullableIntOku(cmbTuketiciMahalle);
            bool emailFormatDogrumu = TextBoxHelper.EmailFormatKontrol(txtTuketiciEmail.Text);
            if (!emailFormatDogrumu)
            {
                MessageBox.Show("e-mail Formatınız Geçerli Değil!!");
                return;
            }


            Tuketici tuketici = new Tuketici()
            {
                TuketiciAdi = txtTuketiciAdi.Text.ToUpper(trCulture),
                TuketiciSoyadi = txtTuketiciSoyadi.Text.ToUpper(trCulture),
                TuketiciTelNo = txtTuketiciTelNo.Text.Replace(" ", ""),
                TuketiciEmail = txtTuketiciEmail.Text.ToLower(usCulture),
                IlId = ilId,
                IlceId = ilceId,
                MahalleId = mahalleId
            };

            using var context = _contextFactory.CreateDbContext();
            try
            {
                context.Customers.Add(tuketici);
                context.SaveChanges();
                TuketiciFormunuTemizle();
                btnTuketiciSave.Enabled = false;
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx)
                {
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                    {
                        MessageBox.Show("Girmiş Olduğunuz Telefon Numarası Kayıtlı. Başka bir Telefon Numarası Girin!!");
                    }
                    else
                    {
                        MessageBox.Show("Veri Tabanı Hatası; Girmiş Olduğunuz Bilgileri Kontrol Ediniz!!");
                    }
                }
                else
                {
                    MessageBox.Show("Beklenmedik bir Hata oluştu Girdiğiniz Bilgileri Kontrol edin!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girmiş Olduğunuz Bilgileri Kontrol Ediniz!!" + ex.Message);
            }

        }

        private bool tuketiciTelNoFormatlamaDevamEdiyor = false;
        private void txtTuketiciTelNo_TextChanged(object sender, EventArgs e)
        {
            btnTuketiciSave.Enabled = true;
            if (tuketiciTelNoFormatlamaDevamEdiyor)
            {
                return;
            }
            tuketiciTelNoFormatlamaDevamEdiyor = true;
            string formatliTelNo = TextBoxHelper.TelNoFormatKontrol(txtTuketiciTelNo.Text);
            txtTuketiciTelNo.Text = formatliTelNo;
            txtTuketiciTelNo.SelectionStart = formatliTelNo.Length;
            tuketiciTelNoFormatlamaDevamEdiyor = false;
        }

        private void TuketiciSave_TextChanged(object sender, EventArgs e)
        {
            btnTuketiciSave.Enabled = true;
        }

        private void cmbTuketiciIl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTuketiciIl.SelectedValue is int seciliIlId)
            {
                ComboBoxHelper.ComboBoxIlceGetir(seciliIlId, cmbTuketiciIlce, _contextFactory);
            }
        }

        private void cmbTuketiciIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTuketiciIlce.SelectedValue is int seciliIlceId)
            {
                ComboBoxHelper.ComboBoxMahalleGetir(seciliIlceId, cmbTuketiciMahalle, _contextFactory);
            }
        }

        private void TuketiciFormunuTemizle()
        {
            cmbTuketiciIl.SelectedIndex = -1;
            cmbTuketiciIlce.DataSource = null;
            cmbTuketiciMahalle.DataSource = null;
            txtTuketiciAdi.Text = "";
            txtTuketiciSoyadi.Text = "";
            txtTuketiciTelNo.Text = "";
            txtTuketiciEmail.Text = "";
        }

        private void txtTuketiciEmail_Leave(object sender, EventArgs e)
        {
            bool emailFormatDogrumu = TextBoxHelper.EmailFormatKontrol(txtTuketiciEmail.Text);
            if (!emailFormatDogrumu)
            {
                MessageBox.Show("e-mail Formatınız Geçerli Değil!!");
                return;
            }
        }

        private void btnTuketiciKayitCancel_Click(object sender, EventArgs e)
        {
            var sonuc = MessageBox.Show
                ("Tuketici Islemleri Formu Kapanacak Emin misin?", "Form Kapanıyor",MessageBoxButtons.OKCancel);
           
            if (sonuc==DialogResult.OK)
            {
                Close();
            }
         }
    }
}





