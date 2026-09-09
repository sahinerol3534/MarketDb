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
            grbSatis = new GroupBox();
            chkKrediKarti = new CheckBox();
            chkKrediKartTaksit = new CheckBox();
            chkKrediKartPesin = new CheckBox();
            chcNakit = new CheckBox();
            lblTuketiciAdiSoyadi = new Label();
            rbUyeOlmadanDevamEt = new RadioButton();
            rbUyeOl = new RadioButton();
            rbUye = new RadioButton();
            lblTuketiciTelNo = new Label();
            txtTuketiciTelNo = new TextBox();
            btnSatisKaydet = new Button();
            txtFisNo = new TextBox();
            lblFisNo = new Label();
            cmbKart = new ComboBox();
            lblKart = new Label();
            lblOdemeTuru = new Label();
            dtpSatisTarihi = new DateTimePicker();
            lblOdemeSekli = new Label();
            lblSatisTarihi = new Label();
            lblMarket = new Label();
            cmbMarket = new ComboBox();
            lblSube = new Label();
            cmbSube = new ComboBox();
            lblTuketici = new Label();
            grbSatisKalemleri = new GroupBox();
            btnKalemleriKaydet = new Button();
            dataGridView1 = new DataGridView();
            btnSatisKalemiEkle = new Button();
            txtBirimFiyat = new TextBox();
            txtMiktar = new TextBox();
            cmbUrun = new ComboBox();
            lblMiktar = new Label();
            lblBirimFiyat = new Label();
            lblUrun = new Label();
            grbSatis.SuspendLayout();
            grbSatisKalemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grbSatis
            // 
            grbSatis.Controls.Add(chkKrediKarti);
            grbSatis.Controls.Add(chkKrediKartTaksit);
            grbSatis.Controls.Add(chkKrediKartPesin);
            grbSatis.Controls.Add(chcNakit);
            grbSatis.Controls.Add(lblTuketiciAdiSoyadi);
            grbSatis.Controls.Add(rbUyeOlmadanDevamEt);
            grbSatis.Controls.Add(rbUyeOl);
            grbSatis.Controls.Add(rbUye);
            grbSatis.Controls.Add(lblTuketiciTelNo);
            grbSatis.Controls.Add(txtTuketiciTelNo);
            grbSatis.Controls.Add(btnSatisKaydet);
            grbSatis.Controls.Add(txtFisNo);
            grbSatis.Controls.Add(lblFisNo);
            grbSatis.Controls.Add(cmbKart);
            grbSatis.Controls.Add(lblKart);
            grbSatis.Controls.Add(lblOdemeTuru);
            grbSatis.Controls.Add(dtpSatisTarihi);
            grbSatis.Controls.Add(lblOdemeSekli);
            grbSatis.Controls.Add(lblSatisTarihi);
            grbSatis.Controls.Add(lblMarket);
            grbSatis.Controls.Add(cmbMarket);
            grbSatis.Controls.Add(lblSube);
            grbSatis.Controls.Add(cmbSube);
            grbSatis.Controls.Add(lblTuketici);
            grbSatis.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbSatis.Location = new Point(32, 25);
            grbSatis.Name = "grbSatis";
            grbSatis.Size = new Size(1153, 205);
            grbSatis.TabIndex = 0;
            grbSatis.TabStop = false;
            grbSatis.Text = "Satış Bilgileri";
            // 
            // chkKrediKarti
            // 
            chkKrediKarti.AutoSize = true;
            chkKrediKarti.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkKrediKarti.Location = new Point(645, 73);
            chkKrediKarti.Name = "chkKrediKarti";
            chkKrediKarti.Size = new Size(101, 24);
            chkKrediKarti.TabIndex = 26;
            chkKrediKarti.Text = "Kredi Kartı";
            chkKrediKarti.UseVisualStyleBackColor = true;
            // 
            // chkKrediKartTaksit
            // 
            chkKrediKartTaksit.AutoSize = true;
            chkKrediKartTaksit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkKrediKartTaksit.Location = new Point(645, 103);
            chkKrediKartTaksit.Name = "chkKrediKartTaksit";
            chkKrediKartTaksit.Size = new Size(147, 24);
            chkKrediKartTaksit.TabIndex = 25;
            chkKrediKartTaksit.Text = "Kredi Kart TAKSİT";
            chkKrediKartTaksit.UseVisualStyleBackColor = true;
            // 
            // chkKrediKartPesin
            // 
            chkKrediKartPesin.AutoSize = true;
            chkKrediKartPesin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkKrediKartPesin.Location = new Point(483, 105);
            chkKrediKartPesin.Name = "chkKrediKartPesin";
            chkKrediKartPesin.Size = new Size(140, 24);
            chkKrediKartPesin.TabIndex = 24;
            chkKrediKartPesin.Text = "Kredi Kart PEŞİN";
            chkKrediKartPesin.UseVisualStyleBackColor = true;
            // 
            // chcNakit
            // 
            chcNakit.AutoSize = true;
            chcNakit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chcNakit.Location = new Point(479, 73);
            chcNakit.Name = "chcNakit";
            chcNakit.Size = new Size(66, 24);
            chcNakit.TabIndex = 23;
            chcNakit.Text = "Nakit";
            chcNakit.UseVisualStyleBackColor = true;
            // 
            // lblTuketiciAdiSoyadi
            // 
            lblTuketiciAdiSoyadi.AutoSize = true;
            lblTuketiciAdiSoyadi.BorderStyle = BorderStyle.FixedSingle;
            lblTuketiciAdiSoyadi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuketiciAdiSoyadi.Location = new Point(152, 106);
            lblTuketiciAdiSoyadi.Name = "lblTuketiciAdiSoyadi";
            lblTuketiciAdiSoyadi.Size = new Size(135, 22);
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
            // btnSatisKaydet
            // 
            btnSatisKaydet.Location = new Point(915, 138);
            btnSatisKaydet.Name = "btnSatisKaydet";
            btnSatisKaydet.Size = new Size(232, 52);
            btnSatisKaydet.TabIndex = 16;
            btnSatisKaydet.Text = "Satış Bilgileri Kaydet";
            btnSatisKaydet.UseVisualStyleBackColor = true;
            // 
            // txtFisNo
            // 
            txtFisNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFisNo.Location = new Point(915, 63);
            txtFisNo.Name = "txtFisNo";
            txtFisNo.Size = new Size(232, 27);
            txtFisNo.TabIndex = 15;
            // 
            // lblFisNo
            // 
            lblFisNo.AutoSize = true;
            lblFisNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFisNo.Location = new Point(847, 70);
            lblFisNo.Name = "lblFisNo";
            lblFisNo.Size = new Size(50, 20);
            lblFisNo.TabIndex = 14;
            lblFisNo.Text = "Fis No";
            // 
            // cmbKart
            // 
            cmbKart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKart.FormattingEnabled = true;
            cmbKart.Location = new Point(476, 135);
            cmbKart.Name = "cmbKart";
            cmbKart.Size = new Size(151, 28);
            cmbKart.TabIndex = 13;
            // 
            // lblKart
            // 
            lblKart.AutoSize = true;
            lblKart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKart.Location = new Point(371, 138);
            lblKart.Name = "lblKart";
            lblKart.Size = new Size(79, 20);
            lblKart.TabIndex = 12;
            lblKart.Text = "Kredi Kartı";
            // 
            // lblOdemeTuru
            // 
            lblOdemeTuru.AutoSize = true;
            lblOdemeTuru.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOdemeTuru.Location = new Point(371, 104);
            lblOdemeTuru.Name = "lblOdemeTuru";
            lblOdemeTuru.Size = new Size(93, 20);
            lblOdemeTuru.TabIndex = 10;
            lblOdemeTuru.Text = "Ödeme Şekli";
            // 
            // dtpSatisTarihi
            // 
            dtpSatisTarihi.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSatisTarihi.CustomFormat = "";
            dtpSatisTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSatisTarihi.Format = DateTimePickerFormat.Short;
            dtpSatisTarihi.Location = new Point(915, 99);
            dtpSatisTarihi.Name = "dtpSatisTarihi";
            dtpSatisTarihi.Size = new Size(232, 27);
            dtpSatisTarihi.TabIndex = 8;
            // 
            // lblOdemeSekli
            // 
            lblOdemeSekli.AutoSize = true;
            lblOdemeSekli.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOdemeSekli.Location = new Point(371, 70);
            lblOdemeSekli.Name = "lblOdemeSekli";
            lblOdemeSekli.Size = new Size(91, 20);
            lblOdemeSekli.TabIndex = 7;
            lblOdemeSekli.Text = "Ödeme Türü";
            // 
            // lblSatisTarihi
            // 
            lblSatisTarihi.AutoSize = true;
            lblSatisTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSatisTarihi.Location = new Point(847, 104);
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
            cmbSube.Location = new Point(152, 169);
            cmbSube.Name = "cmbSube";
            cmbSube.Size = new Size(475, 28);
            cmbSube.TabIndex = 2;
            // 
            // lblTuketici
            // 
            lblTuketici.AutoSize = true;
            lblTuketici.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuketici.Location = new Point(22, 106);
            lblTuketici.Name = "lblTuketici";
            lblTuketici.Size = new Size(60, 20);
            lblTuketici.TabIndex = 1;
            lblTuketici.Text = "Tüketici";
            // 
            // grbSatisKalemleri
            // 
            grbSatisKalemleri.BackColor = SystemColors.Window;
            grbSatisKalemleri.Controls.Add(btnKalemleriKaydet);
            grbSatisKalemleri.Controls.Add(dataGridView1);
            grbSatisKalemleri.Controls.Add(btnSatisKalemiEkle);
            grbSatisKalemleri.Controls.Add(txtBirimFiyat);
            grbSatisKalemleri.Controls.Add(txtMiktar);
            grbSatisKalemleri.Controls.Add(cmbUrun);
            grbSatisKalemleri.Controls.Add(lblMiktar);
            grbSatisKalemleri.Controls.Add(lblBirimFiyat);
            grbSatisKalemleri.Controls.Add(lblUrun);
            grbSatisKalemleri.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbSatisKalemleri.Location = new Point(32, 236);
            grbSatisKalemleri.Name = "grbSatisKalemleri";
            grbSatisKalemleri.Size = new Size(1153, 336);
            grbSatisKalemleri.TabIndex = 1;
            grbSatisKalemleri.TabStop = false;
            grbSatisKalemleri.Text = "Satış Kalemleri";
            // 
            // btnKalemleriKaydet
            // 
            btnKalemleriKaydet.Location = new Point(597, 280);
            btnKalemleriKaydet.Name = "btnKalemleriKaydet";
            btnKalemleriKaydet.Size = new Size(268, 38);
            btnKalemleriKaydet.TabIndex = 8;
            btnKalemleriKaydet.Text = "Satış Fişini Kaydet";
            btnKalemleriKaydet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 188);
            dataGridView1.TabIndex = 7;
            // 
            // btnSatisKalemiEkle
            // 
            btnSatisKalemiEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSatisKalemiEkle.Location = new Point(133, 201);
            btnSatisKalemiEkle.Name = "btnSatisKalemiEkle";
            btnSatisKalemiEkle.Size = new Size(170, 37);
            btnSatisKalemiEkle.TabIndex = 6;
            btnSatisKalemiEkle.Text = "Yeni Satış Kalemi";
            btnSatisKalemiEkle.UseVisualStyleBackColor = true;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirimFiyat.Location = new Point(133, 117);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(170, 27);
            txtBirimFiyat.TabIndex = 5;
            // 
            // txtMiktar
            // 
            txtMiktar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiktar.Location = new Point(133, 84);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(170, 27);
            txtMiktar.TabIndex = 4;
            // 
            // cmbUrun
            // 
            cmbUrun.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(133, 50);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(170, 28);
            cmbUrun.TabIndex = 3;
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiktar.Location = new Point(22, 84);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(51, 20);
            lblMiktar.TabIndex = 2;
            lblMiktar.Text = "Miktar";
            // 
            // lblBirimFiyat
            // 
            lblBirimFiyat.AutoSize = true;
            lblBirimFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirimFiyat.Location = new Point(22, 115);
            lblBirimFiyat.Name = "lblBirimFiyat";
            lblBirimFiyat.Size = new Size(79, 20);
            lblBirimFiyat.TabIndex = 1;
            lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // lblUrun
            // 
            lblUrun.AutoSize = true;
            lblUrun.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUrun.Location = new Point(22, 58);
            lblUrun.Name = "lblUrun";
            lblUrun.Size = new Size(40, 20);
            lblUrun.TabIndex = 0;
            lblUrun.Text = "Ürün";
            // 
            // frmSatisIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 584);
            Controls.Add(grbSatisKalemleri);
            Controls.Add(grbSatis);
            Name = "frmSatisIslemleriForm";
            Text = "frmSatisIslemleriForm";
            Load += frmSatisIslemleriForm_Load;
            grbSatis.ResumeLayout(false);
            grbSatis.PerformLayout();
            grbSatisKalemleri.ResumeLayout(false);
            grbSatisKalemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSatis;
        private Label lblTuketici;
        private Label lblOdemeSekli;
        private Label lblSatisTarihi;
        private Label lblMarket;
        private ComboBox cmbMarket;
        private Label lblSube;
        private ComboBox cmbSube;
        private DateTimePicker dtpSatisTarihi;
        private ComboBox cmbKart;
        private Label lblKart;
        private Label lblOdemeTuru;
        private Label lblFisNo;
        private Button btnSatisKaydet;
        private TextBox txtFisNo;
        private GroupBox grbSatisKalemleri;
        private Label lblMiktar;
        private Label lblBirimFiyat;
        private Label lblUrun;
        private TextBox txtBirimFiyat;
        private TextBox txtMiktar;
        private ComboBox cmbUrun;
        private Button btnKalemleriKaydet;
        private DataGridView dataGridView1;
        private Button btnSatisKalemiEkle;
        private Label lblTuketiciTelNo;
        private TextBox txtTuketiciTelNo;
        private RadioButton rbUye;
        private RadioButton rbUyeOlmadanDevamEt;
        private RadioButton rbUyeOl;
        private Label lblTuketiciAdiSoyadi;
        private CheckBox chcNakit;
        private CheckBox chkKrediKartTaksit;
        private CheckBox chkKrediKartPesin;
        private CheckBox chkKrediKarti;
    }
}