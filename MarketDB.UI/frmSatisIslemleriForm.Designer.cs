namespace MarketDB.UI
{
    partial class frmSatisIslemleriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbSatisKalemleri = new GroupBox();
            btnOdemeyeGec = new Button();
            cmbAltKategori = new ComboBox();
            cmbKategori = new ComboBox();
            lblKategori = new Label();
            lblAltKategori = new Label();
            rdTaksit = new RadioButton();
            rdPesin = new RadioButton();
            cmbTaksitSayisi = new ComboBox();
            txtKdvTutari = new TextBox();
            txtIndirimTutari = new TextBox();
            lblIndirim = new Label();
            lblKdv = new Label();
            dgvSatisKalemleriGosterimi = new DataGridView();
            lblTaksitSayisi = new Label();
            btnSatisKalemiEkle = new Button();
            txtBirimFiyat = new TextBox();
            txtMiktar = new TextBox();
            cmbUrun = new ComboBox();
            lblMiktar = new Label();
            lblBirimFiyat = new Label();
            lblUrun = new Label();
            lblOdemeSekli = new Label();
            grbSatis = new GroupBox();
            lblTuketiciAdiSoyadi = new Label();
            rbUyeOlmadanDevamEt = new RadioButton();
            rbUyeOl = new RadioButton();
            rbUye = new RadioButton();
            lblTuketiciTelNo = new Label();
            txtTuketiciTelNo = new TextBox();
            btnOnay = new Button();
            txtFisNo = new TextBox();
            lblFisNo = new Label();
            dtpSatisTarihi = new DateTimePicker();
            lblSatisTarihi = new Label();
            lblMarket = new Label();
            cmbMarket = new ComboBox();
            lblSube = new Label();
            cmbSube = new ComboBox();
            lblTuketici = new Label();
            lblOdemeToplami = new Label();
            lblKartOdemesi = new Label();
            lblKrediKartlari = new Label();
            lblKartTutar = new Label();
            lblToplam = new Label();
            lblNakitTutar = new Label();
            txtNakitTutar = new TextBox();
            cmbKrediKartlari = new ComboBox();
            chkKrediKarti = new CheckBox();
            chkNakit = new CheckBox();
            lblOdemeTurleri = new Label();
            btnKalemleriKaydet = new Button();
            grbOdemeTuruSecimi = new GroupBox();
            grbSatisKalemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSatisKalemleriGosterimi).BeginInit();
            grbSatis.SuspendLayout();
            grbOdemeTuruSecimi.SuspendLayout();
            SuspendLayout();
            // 
            // grbSatisKalemleri
            // 
            grbSatisKalemleri.BackColor = SystemColors.Window;
            grbSatisKalemleri.Controls.Add(btnOdemeyeGec);
            grbSatisKalemleri.Controls.Add(cmbAltKategori);
            grbSatisKalemleri.Controls.Add(cmbKategori);
            grbSatisKalemleri.Controls.Add(lblKategori);
            grbSatisKalemleri.Controls.Add(lblAltKategori);
            grbSatisKalemleri.Controls.Add(rdTaksit);
            grbSatisKalemleri.Controls.Add(rdPesin);
            grbSatisKalemleri.Controls.Add(cmbTaksitSayisi);
            grbSatisKalemleri.Controls.Add(txtKdvTutari);
            grbSatisKalemleri.Controls.Add(txtIndirimTutari);
            grbSatisKalemleri.Controls.Add(lblIndirim);
            grbSatisKalemleri.Controls.Add(lblKdv);
            grbSatisKalemleri.Controls.Add(dgvSatisKalemleriGosterimi);
            grbSatisKalemleri.Controls.Add(lblTaksitSayisi);
            grbSatisKalemleri.Controls.Add(btnSatisKalemiEkle);
            grbSatisKalemleri.Controls.Add(txtBirimFiyat);
            grbSatisKalemleri.Controls.Add(txtMiktar);
            grbSatisKalemleri.Controls.Add(cmbUrun);
            grbSatisKalemleri.Controls.Add(lblMiktar);
            grbSatisKalemleri.Controls.Add(lblBirimFiyat);
            grbSatisKalemleri.Controls.Add(lblUrun);
            grbSatisKalemleri.Controls.Add(lblOdemeSekli);
            grbSatisKalemleri.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbSatisKalemleri.Location = new Point(32, 236);
            grbSatisKalemleri.Name = "grbSatisKalemleri";
            grbSatisKalemleri.Size = new Size(1792, 395);
            grbSatisKalemleri.TabIndex = 1;
            grbSatisKalemleri.TabStop = false;
            grbSatisKalemleri.Text = "Satış Kalemleri";
            // 
            // btnOdemeyeGec
            // 
            btnOdemeyeGec.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOdemeyeGec.Location = new Point(425, 344);
            btnOdemeyeGec.Name = "btnOdemeyeGec";
            btnOdemeyeGec.Size = new Size(233, 37);
            btnOdemeyeGec.TabIndex = 44;
            btnOdemeyeGec.Text = " Ödeme Bilgilerine Geç";
            btnOdemeyeGec.UseVisualStyleBackColor = true;
            btnOdemeyeGec.Click += btnOdemeyeGec_Click;
            // 
            // cmbAltKategori
            // 
            cmbAltKategori.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAltKategori.FormattingEnabled = true;
            cmbAltKategori.Location = new Point(137, 89);
            cmbAltKategori.Name = "cmbAltKategori";
            cmbAltKategori.Size = new Size(309, 28);
            cmbAltKategori.TabIndex = 43;
            cmbAltKategori.SelectedIndexChanged += cmbAltKategori_SelectedIndexChanged;
            // 
            // cmbKategori
            // 
            cmbKategori.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(137, 51);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(309, 28);
            cmbKategori.TabIndex = 42;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(27, 53);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 41;
            lblKategori.Text = "Kategori";
            // 
            // lblAltKategori
            // 
            lblAltKategori.AutoSize = true;
            lblAltKategori.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltKategori.Location = new Point(27, 97);
            lblAltKategori.Name = "lblAltKategori";
            lblAltKategori.Size = new Size(89, 20);
            lblAltKategori.TabIndex = 40;
            lblAltKategori.Text = "Alt Kategori";
            // 
            // rdTaksit
            // 
            rdTaksit.AutoSize = true;
            rdTaksit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdTaksit.Location = new Point(242, 265);
            rdTaksit.Name = "rdTaksit";
            rdTaksit.Size = new Size(66, 24);
            rdTaksit.TabIndex = 39;
            rdTaksit.Text = "Taksit";
            rdTaksit.UseVisualStyleBackColor = true;
            rdTaksit.CheckedChanged += rdTaksit_CheckedChanged;
            // 
            // rdPesin
            // 
            rdPesin.AutoSize = true;
            rdPesin.Checked = true;
            rdPesin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdPesin.Location = new Point(138, 267);
            rdPesin.Name = "rdPesin";
            rdPesin.Size = new Size(63, 24);
            rdPesin.TabIndex = 38;
            rdPesin.TabStop = true;
            rdPesin.Text = "Pesin";
            rdPesin.UseVisualStyleBackColor = true;
            rdPesin.CheckedChanged += rdPesin_CheckedChanged;
            // 
            // cmbTaksitSayisi
            // 
            cmbTaksitSayisi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTaksitSayisi.FormattingEnabled = true;
            cmbTaksitSayisi.Location = new Point(138, 297);
            cmbTaksitSayisi.Name = "cmbTaksitSayisi";
            cmbTaksitSayisi.Size = new Size(107, 28);
            cmbTaksitSayisi.TabIndex = 37;
            // 
            // txtKdvTutari
            // 
            txtKdvTutari.Font = new Font("Segoe UI", 9F);
            txtKdvTutari.Location = new Point(363, 212);
            txtKdvTutari.Name = "txtKdvTutari";
            txtKdvTutari.Size = new Size(122, 27);
            txtKdvTutari.TabIndex = 36;
            // 
            // txtIndirimTutari
            // 
            txtIndirimTutari.Font = new Font("Segoe UI", 9F);
            txtIndirimTutari.Location = new Point(137, 212);
            txtIndirimTutari.Name = "txtIndirimTutari";
            txtIndirimTutari.Size = new Size(133, 27);
            txtIndirimTutari.TabIndex = 35;
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.Font = new Font("Segoe UI", 9F);
            lblIndirim.Location = new Point(26, 219);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new Size(98, 20);
            lblIndirim.TabIndex = 34;
            lblIndirim.Text = "İndirim Tutarı";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Font = new Font("Segoe UI", 9F);
            lblKdv.Location = new Point(282, 215);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(80, 20);
            lblKdv.TabIndex = 33;
            lblKdv.Text = "KDV Turarı";
            // 
            // dgvSatisKalemleriGosterimi
            // 
            dgvSatisKalemleriGosterimi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatisKalemleriGosterimi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvSatisKalemleriGosterimi.Location = new Point(491, 51);
            dgvSatisKalemleriGosterimi.Name = "dgvSatisKalemleriGosterimi";
            dgvSatisKalemleriGosterimi.RowHeadersWidth = 51;
            dgvSatisKalemleriGosterimi.Size = new Size(1241, 188);
            dgvSatisKalemleriGosterimi.TabIndex = 7;
            // 
            // lblTaksitSayisi
            // 
            lblTaksitSayisi.AutoSize = true;
            lblTaksitSayisi.Font = new Font("Segoe UI", 9F);
            lblTaksitSayisi.Location = new Point(27, 304);
            lblTaksitSayisi.Name = "lblTaksitSayisi";
            lblTaksitSayisi.Size = new Size(86, 20);
            lblTaksitSayisi.TabIndex = 27;
            lblTaksitSayisi.Text = "Taksit Sayisi";
            // 
            // btnSatisKalemiEkle
            // 
            btnSatisKalemiEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSatisKalemiEkle.Location = new Point(185, 344);
            btnSatisKalemiEkle.Name = "btnSatisKalemiEkle";
            btnSatisKalemiEkle.Size = new Size(170, 37);
            btnSatisKalemiEkle.TabIndex = 6;
            btnSatisKalemiEkle.Text = " Satış Kalemi Ekle";
            btnSatisKalemiEkle.UseVisualStyleBackColor = true;
            btnSatisKalemiEkle.Click += btnSatisKalemiEkle_Click;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirimFiyat.Location = new Point(137, 173);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(107, 27);
            txtBirimFiyat.TabIndex = 5;
            // 
            // txtMiktar
            // 
            txtMiktar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiktar.Location = new Point(363, 173);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(82, 27);
            txtMiktar.TabIndex = 4;
            // 
            // cmbUrun
            // 
            cmbUrun.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(137, 128);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(309, 28);
            cmbUrun.TabIndex = 3;
            cmbUrun.SelectedIndexChanged += cmbUrun_SelectedIndexChanged;
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiktar.Location = new Point(307, 173);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(51, 20);
            lblMiktar.TabIndex = 2;
            lblMiktar.Text = "Miktar";
            // 
            // lblBirimFiyat
            // 
            lblBirimFiyat.AutoSize = true;
            lblBirimFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirimFiyat.Location = new Point(26, 177);
            lblBirimFiyat.Name = "lblBirimFiyat";
            lblBirimFiyat.Size = new Size(79, 20);
            lblBirimFiyat.TabIndex = 1;
            lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // lblUrun
            // 
            lblUrun.AutoSize = true;
            lblUrun.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUrun.Location = new Point(26, 136);
            lblUrun.Name = "lblUrun";
            lblUrun.Size = new Size(40, 20);
            lblUrun.TabIndex = 0;
            lblUrun.Text = "Ürün";
            // 
            // lblOdemeSekli
            // 
            lblOdemeSekli.AutoSize = true;
            lblOdemeSekli.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOdemeSekli.Location = new Point(27, 267);
            lblOdemeSekli.Name = "lblOdemeSekli";
            lblOdemeSekli.Size = new Size(93, 20);
            lblOdemeSekli.TabIndex = 10;
            lblOdemeSekli.Text = "Ödeme Şekli";
            // 
            // grbSatis
            // 
            grbSatis.BackColor = Color.Snow;
            grbSatis.Controls.Add(lblTuketiciAdiSoyadi);
            grbSatis.Controls.Add(rbUyeOlmadanDevamEt);
            grbSatis.Controls.Add(rbUyeOl);
            grbSatis.Controls.Add(rbUye);
            grbSatis.Controls.Add(lblTuketiciTelNo);
            grbSatis.Controls.Add(txtTuketiciTelNo);
            grbSatis.Controls.Add(btnOnay);
            grbSatis.Controls.Add(txtFisNo);
            grbSatis.Controls.Add(lblFisNo);
            grbSatis.Controls.Add(dtpSatisTarihi);
            grbSatis.Controls.Add(lblSatisTarihi);
            grbSatis.Controls.Add(lblMarket);
            grbSatis.Controls.Add(cmbMarket);
            grbSatis.Controls.Add(lblSube);
            grbSatis.Controls.Add(cmbSube);
            grbSatis.Controls.Add(lblTuketici);
            grbSatis.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbSatis.Location = new Point(32, 25);
            grbSatis.Name = "grbSatis";
            grbSatis.Size = new Size(1792, 205);
            grbSatis.TabIndex = 0;
            grbSatis.TabStop = false;
            grbSatis.Text = "Satış Bilgileri";
            // 
            // lblTuketiciAdiSoyadi
            // 
            lblTuketiciAdiSoyadi.AutoSize = true;
            lblTuketiciAdiSoyadi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuketiciAdiSoyadi.Location = new Point(152, 107);
            lblTuketiciAdiSoyadi.Name = "lblTuketiciAdiSoyadi";
            lblTuketiciAdiSoyadi.Size = new Size(133, 20);
            lblTuketiciAdiSoyadi.TabIndex = 22;
            lblTuketiciAdiSoyadi.Text = " Tüketici Seçilmedi";
            // 
            // rbUyeOlmadanDevamEt
            // 
            rbUyeOlmadanDevamEt.AutoSize = true;
            rbUyeOlmadanDevamEt.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rbUyeOlmadanDevamEt.Location = new Point(323, 37);
            rbUyeOlmadanDevamEt.Name = "rbUyeOlmadanDevamEt";
            rbUyeOlmadanDevamEt.Size = new Size(199, 24);
            rbUyeOlmadanDevamEt.TabIndex = 21;
            rbUyeOlmadanDevamEt.Text = "Uye Olmadan Devam Et";
            rbUyeOlmadanDevamEt.UseVisualStyleBackColor = true;
            rbUyeOlmadanDevamEt.CheckedChanged += rbUye_CheckedChanged;
            // 
            // rbUyeOl
            // 
            rbUyeOl.AutoSize = true;
            rbUyeOl.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rbUyeOl.Location = new Point(226, 37);
            rbUyeOl.Name = "rbUyeOl";
            rbUyeOl.Size = new Size(77, 24);
            rbUyeOl.TabIndex = 20;
            rbUyeOl.Text = "Uye Ol";
            rbUyeOl.UseVisualStyleBackColor = true;
            rbUyeOl.CheckedChanged += rbUye_CheckedChanged;
            // 
            // rbUye
            // 
            rbUye.AutoSize = true;
            rbUye.Checked = true;
            rbUye.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rbUye.Location = new Point(152, 37);
            rbUye.Name = "rbUye";
            rbUye.Size = new Size(57, 24);
            rbUye.TabIndex = 19;
            rbUye.TabStop = true;
            rbUye.Text = "Uye";
            rbUye.UseVisualStyleBackColor = true;
            rbUye.CheckedChanged += rbUye_CheckedChanged;
            // 
            // lblTuketiciTelNo
            // 
            lblTuketiciTelNo.AutoSize = true;
            lblTuketiciTelNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuketiciTelNo.Location = new Point(22, 75);
            lblTuketiciTelNo.Name = "lblTuketiciTelNo";
            lblTuketiciTelNo.Size = new Size(107, 20);
            lblTuketiciTelNo.TabIndex = 18;
            lblTuketiciTelNo.Text = "Tüketici Tel No";
            // 
            // txtTuketiciTelNo
            // 
            txtTuketiciTelNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuketiciTelNo.Location = new Point(152, 68);
            txtTuketiciTelNo.Name = "txtTuketiciTelNo";
            txtTuketiciTelNo.Size = new Size(151, 27);
            txtTuketiciTelNo.TabIndex = 17;
            txtTuketiciTelNo.TextChanged += txtTuketiciTelNo_TextChanged;
            // 
            // btnOnay
            // 
            btnOnay.Location = new Point(986, 112);
            btnOnay.Name = "btnOnay";
            btnOnay.Size = new Size(299, 52);
            btnOnay.TabIndex = 16;
            btnOnay.Text = "Satış Bilgilerini Onayla";
            btnOnay.UseVisualStyleBackColor = true;
            btnOnay.Click += btnOnay_Click;
            // 
            // txtFisNo
            // 
            txtFisNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFisNo.Location = new Point(1054, 37);
            txtFisNo.Name = "txtFisNo";
            txtFisNo.Size = new Size(233, 27);
            txtFisNo.TabIndex = 15;
            txtFisNo.TextChanged += txtFisNo_TextChanged;
            // 
            // lblFisNo
            // 
            lblFisNo.AutoSize = true;
            lblFisNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFisNo.Location = new Point(986, 44);
            lblFisNo.Name = "lblFisNo";
            lblFisNo.Size = new Size(50, 20);
            lblFisNo.TabIndex = 14;
            lblFisNo.Text = "Fis No";
            // 
            // dtpSatisTarihi
            // 
            dtpSatisTarihi.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSatisTarihi.CustomFormat = "";
            dtpSatisTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSatisTarihi.Format = DateTimePickerFormat.Short;
            dtpSatisTarihi.Location = new Point(1054, 73);
            dtpSatisTarihi.Name = "dtpSatisTarihi";
            dtpSatisTarihi.Size = new Size(233, 27);
            dtpSatisTarihi.TabIndex = 8;
            dtpSatisTarihi.ValueChanged += dtpSatisTarihi_ValueChanged;
            // 
            // lblSatisTarihi
            // 
            lblSatisTarihi.AutoSize = true;
            lblSatisTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSatisTarihi.Location = new Point(986, 77);
            lblSatisTarihi.Name = "lblSatisTarihi";
            lblSatisTarihi.Size = new Size(40, 20);
            lblSatisTarihi.TabIndex = 6;
            lblSatisTarihi.Text = "Tarih";
            // 
            // lblMarket
            // 
            lblMarket.AutoSize = true;
            lblMarket.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarket.Location = new Point(22, 143);
            lblMarket.Name = "lblMarket";
            lblMarket.Size = new Size(55, 20);
            lblMarket.TabIndex = 5;
            lblMarket.Text = "Market";
            // 
            // cmbMarket
            // 
            cmbMarket.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMarket.FormattingEnabled = true;
            cmbMarket.Location = new Point(152, 135);
            cmbMarket.Name = "cmbMarket";
            cmbMarket.Size = new Size(151, 28);
            cmbMarket.TabIndex = 4;
            cmbMarket.SelectedIndexChanged += cmbMarket_SelectedIndexChanged;
            // 
            // lblSube
            // 
            lblSube.AutoSize = true;
            lblSube.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSube.Location = new Point(22, 177);
            lblSube.Name = "lblSube";
            lblSube.Size = new Size(42, 20);
            lblSube.TabIndex = 3;
            lblSube.Text = "Şube";
            // 
            // cmbSube
            // 
            cmbSube.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSube.FormattingEnabled = true;
            cmbSube.Location = new Point(149, 171);
            cmbSube.Name = "cmbSube";
            cmbSube.Size = new Size(334, 28);
            cmbSube.TabIndex = 2;
            // 
            // lblTuketici
            // 
            lblTuketici.AutoSize = true;
            lblTuketici.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuketici.Location = new Point(22, 107);
            lblTuketici.Name = "lblTuketici";
            lblTuketici.Size = new Size(60, 20);
            lblTuketici.TabIndex = 1;
            lblTuketici.Text = "Tüketici";
            // 
            // lblOdemeToplami
            // 
            lblOdemeToplami.AutoSize = true;
            lblOdemeToplami.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOdemeToplami.Location = new Point(848, 32);
            lblOdemeToplami.Name = "lblOdemeToplami";
            lblOdemeToplami.Size = new Size(50, 23);
            lblOdemeToplami.TabIndex = 36;
            lblOdemeToplami.Text = "*****";
            // 
            // lblKartOdemesi
            // 
            lblKartOdemesi.AutoSize = true;
            lblKartOdemesi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKartOdemesi.Location = new Point(687, 32);
            lblKartOdemesi.Name = "lblKartOdemesi";
            lblKartOdemesi.Size = new Size(39, 20);
            lblKartOdemesi.TabIndex = 35;
            lblKartOdemesi.Text = ".****.";
            // 
            // lblKrediKartlari
            // 
            lblKrediKartlari.AutoSize = true;
            lblKrediKartlari.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKrediKartlari.Location = new Point(935, 32);
            lblKrediKartlari.Name = "lblKrediKartlari";
            lblKrediKartlari.Size = new Size(79, 20);
            lblKrediKartlari.TabIndex = 23;
            lblKrediKartlari.Text = "Kredi Kartı";
            // 
            // lblKartTutar
            // 
            lblKartTutar.AutoSize = true;
            lblKartTutar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKartTutar.Location = new Point(579, 33);
            lblKartTutar.Name = "lblKartTutar";
            lblKartTutar.Size = new Size(113, 20);
            lblKartTutar.TabIndex = 51;
            lblKartTutar.Text = "Kart İle Ödeme ";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToplam.Location = new Point(783, 33);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(59, 20);
            lblToplam.TabIndex = 50;
            lblToplam.Text = "Toplam";
            // 
            // lblNakitTutar
            // 
            lblNakitTutar.AutoSize = true;
            lblNakitTutar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNakitTutar.Location = new Point(349, 35);
            lblNakitTutar.Name = "lblNakitTutar";
            lblNakitTutar.Size = new Size(97, 20);
            lblNakitTutar.TabIndex = 49;
            lblNakitTutar.Text = "Nakit Ödeme";
            // 
            // txtNakitTutar
            // 
            txtNakitTutar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNakitTutar.Location = new Point(454, 31);
            txtNakitTutar.Name = "txtNakitTutar";
            txtNakitTutar.Size = new Size(90, 27);
            txtNakitTutar.TabIndex = 48;
            txtNakitTutar.TextChanged += txtNakitTutar_TextChanged;
            // 
            // cmbKrediKartlari
            // 
            cmbKrediKartlari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKrediKartlari.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKrediKartlari.FormattingEnabled = true;
            cmbKrediKartlari.Location = new Point(1031, 29);
            cmbKrediKartlari.Name = "cmbKrediKartlari";
            cmbKrediKartlari.Size = new Size(332, 28);
            cmbKrediKartlari.TabIndex = 47;
            // 
            // chkKrediKarti
            // 
            chkKrediKarti.AutoSize = true;
            chkKrediKarti.Font = new Font("Segoe UI", 9F);
            chkKrediKarti.Location = new Point(215, 33);
            chkKrediKarti.Name = "chkKrediKarti";
            chkKrediKarti.Size = new Size(101, 24);
            chkKrediKarti.TabIndex = 46;
            chkKrediKarti.Text = "Kredi Kartı";
            chkKrediKarti.UseVisualStyleBackColor = true;
            chkKrediKarti.CheckedChanged += chkKrediKarti_CheckedChanged;
            // 
            // chkNakit
            // 
            chkNakit.AutoSize = true;
            chkNakit.Font = new Font("Segoe UI", 9F);
            chkNakit.Location = new Point(138, 33);
            chkNakit.Name = "chkNakit";
            chkNakit.Size = new Size(66, 24);
            chkNakit.TabIndex = 45;
            chkNakit.Text = "Nakit";
            chkNakit.UseVisualStyleBackColor = true;
            chkNakit.CheckedChanged += chkNakit_CheckedChanged;
            // 
            // lblOdemeTurleri
            // 
            lblOdemeTurleri.AutoSize = true;
            lblOdemeTurleri.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOdemeTurleri.Location = new Point(27, 33);
            lblOdemeTurleri.Name = "lblOdemeTurleri";
            lblOdemeTurleri.Size = new Size(91, 20);
            lblOdemeTurleri.TabIndex = 44;
            lblOdemeTurleri.Text = "Ödeme Türü";
            // 
            // btnKalemleriKaydet
            // 
            btnKalemleriKaydet.Location = new Point(1400, 57);
            btnKalemleriKaydet.Name = "btnKalemleriKaydet";
            btnKalemleriKaydet.Size = new Size(267, 37);
            btnKalemleriKaydet.TabIndex = 8;
            btnKalemleriKaydet.Text = "Satış Fişini Kaydet";
            btnKalemleriKaydet.UseVisualStyleBackColor = true;
            btnKalemleriKaydet.Click += btnKalemleriKaydet_Click;
            // 
            // grbOdemeTuruSecimi
            // 
            grbOdemeTuruSecimi.BackColor = Color.WhiteSmoke;
            grbOdemeTuruSecimi.Controls.Add(lblOdemeToplami);
            grbOdemeTuruSecimi.Controls.Add(lblKartTutar);
            grbOdemeTuruSecimi.Controls.Add(lblKartOdemesi);
            grbOdemeTuruSecimi.Controls.Add(lblOdemeTurleri);
            grbOdemeTuruSecimi.Controls.Add(lblToplam);
            grbOdemeTuruSecimi.Controls.Add(chkNakit);
            grbOdemeTuruSecimi.Controls.Add(lblKrediKartlari);
            grbOdemeTuruSecimi.Controls.Add(chkKrediKarti);
            grbOdemeTuruSecimi.Controls.Add(lblNakitTutar);
            grbOdemeTuruSecimi.Controls.Add(cmbKrediKartlari);
            grbOdemeTuruSecimi.Controls.Add(txtNakitTutar);
            grbOdemeTuruSecimi.Controls.Add(btnKalemleriKaydet);
            grbOdemeTuruSecimi.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbOdemeTuruSecimi.Location = new Point(32, 637);
            grbOdemeTuruSecimi.Margin = new Padding(3, 4, 3, 4);
            grbOdemeTuruSecimi.Name = "grbOdemeTuruSecimi";
            grbOdemeTuruSecimi.Padding = new Padding(3, 4, 3, 4);
            grbOdemeTuruSecimi.Size = new Size(1792, 139);
            grbOdemeTuruSecimi.TabIndex = 2;
            grbOdemeTuruSecimi.TabStop = false;
            grbOdemeTuruSecimi.Text = "Ödeme Bilgileri";
            // 
            // frmSatisIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1922, 792);
            Controls.Add(grbOdemeTuruSecimi);
            Controls.Add(grbSatisKalemleri);
            Controls.Add(grbSatis);
            Name = "frmSatisIslemleriForm";
            Text = "frmSatisIslemleriForm";
            Load += frmSatisIslemleriForm_Load;
            grbSatisKalemleri.ResumeLayout(false);
            grbSatisKalemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSatisKalemleriGosterimi).EndInit();
            grbSatis.ResumeLayout(false);
            grbSatis.PerformLayout();
            grbOdemeTuruSecimi.ResumeLayout(false);
            grbOdemeTuruSecimi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSatis;
        private Label lblTuketici;
        private Label lblSatisTarihi;
        private Label lblMarket;
        private ComboBox cmbMarket;
        private Label lblSube;
        private ComboBox cmbSube;
        private DateTimePicker dtpSatisTarihi;
        private Label lblOdemeSekli;
        private Label lblFisNo;
        private Button btnOnay;
        private TextBox txtFisNo;
        private GroupBox grbSatisKalemleri;
        private Label lblMiktar;
        private Label lblBirimFiyat;
        private Label lblUrun;
        private TextBox txtBirimFiyat;
        private TextBox txtMiktar;
        private ComboBox cmbUrun;
        private Button btnKalemleriKaydet;
        private DataGridView dgvSatisKalemleriGosterimi;
        private Button btnSatisKalemiEkle;
        private Label lblTuketiciTelNo;
        private TextBox txtTuketiciTelNo;
        private RadioButton rbUye;
        private RadioButton rbUyeOlmadanDevamEt;
        private RadioButton rbUyeOl;
        private Label lblTuketiciAdiSoyadi;
        private Label lblTaksitSayisi;
        private Label lblKdv;
        private TextBox txtKdvTutari;
        private TextBox txtIndirimTutari;
        private Label lblIndirim;
        private ComboBox cmbTaksitSayisi;
        private RadioButton rdPesin;
        private RadioButton rdTaksit;
        private Label lblKategori;
        private Label lblAltKategori;
        private ComboBox cmbAltKategori;
        private ComboBox cmbKategori;
        private Label lblKrediKartlari;
        private Label lblOdemeToplami;
        private Label lblKartOdemesi;
        private Label lblKartTutar;
        private Label lblToplam;
        private Label lblNakitTutar;
        private TextBox txtNakitTutar;
        private ComboBox cmbKrediKartlari;
        private CheckBox chkKrediKarti;
        private CheckBox chkNakit;
        private Label lblOdemeTurleri;
        private GroupBox grbOdemeTuruSecimi;
        private Button btnOdemeyeGec;
    }
}