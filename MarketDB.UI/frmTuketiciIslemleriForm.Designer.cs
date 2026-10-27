namespace MarketDB.UI
{
    partial class frmTuketiciIslemleriForm
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
            lblTüketiciIslemleriBaslik = new Label();
            lblTuketiciAdi = new Label();
            lblTuketiciSoyadi = new Label();
            lblTuketiciTelNo = new Label();
            lblTuketiciEmail = new Label();
            lblTuketiciIl = new Label();
            lblTuketiciIslemleriTuketici = new Label();
            lblTuketiciMahalle = new Label();
            lblTuketiciIlce = new Label();
            txtTuketiciAdi = new TextBox();
            txtTuketiciSoyadi = new TextBox();
            txtTuketiciTelNo = new TextBox();
            txtTuketiciEmail = new TextBox();
            btnTuketiciSave = new Button();
            cmbTuketiciIl = new ComboBox();
            cmbTuketiciIlce = new ComboBox();
            cmbTuketiciMahalle = new ComboBox();
            btnTuketiciKayitCancel = new Button();
            SuspendLayout();
            // 
            // lblTüketiciIslemleriBaslik
            // 
            lblTüketiciIslemleriBaslik.AutoSize = true;
            lblTüketiciIslemleriBaslik.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTüketiciIslemleriBaslik.Location = new Point(27, 17);
            lblTüketiciIslemleriBaslik.Name = "lblTüketiciIslemleriBaslik";
            lblTüketiciIslemleriBaslik.Size = new Size(246, 38);
            lblTüketiciIslemleriBaslik.TabIndex = 0;
            lblTüketiciIslemleriBaslik.Text = "Tüketici İşlemleri";
            // 
            // lblTuketiciAdi
            // 
            lblTuketiciAdi.AutoSize = true;
            lblTuketiciAdi.Location = new Point(27, 123);
            lblTuketiciAdi.Name = "lblTuketiciAdi";
            lblTuketiciAdi.Size = new Size(32, 20);
            lblTuketiciAdi.TabIndex = 1;
            lblTuketiciAdi.Text = "Adı";
            // 
            // lblTuketiciSoyadi
            // 
            lblTuketiciSoyadi.AutoSize = true;
            lblTuketiciSoyadi.Location = new Point(27, 161);
            lblTuketiciSoyadi.Name = "lblTuketiciSoyadi";
            lblTuketiciSoyadi.Size = new Size(54, 20);
            lblTuketiciSoyadi.TabIndex = 2;
            lblTuketiciSoyadi.Text = "Soyadı";
            // 
            // lblTuketiciTelNo
            // 
            lblTuketiciTelNo.AutoSize = true;
            lblTuketiciTelNo.Location = new Point(27, 204);
            lblTuketiciTelNo.Name = "lblTuketiciTelNo";
            lblTuketiciTelNo.Size = new Size(125, 20);
            lblTuketiciTelNo.TabIndex = 3;
            lblTuketiciTelNo.Text = "Telefon Numarası";
            // 
            // lblTuketiciEmail
            // 
            lblTuketiciEmail.AutoSize = true;
            lblTuketiciEmail.Location = new Point(27, 252);
            lblTuketiciEmail.Name = "lblTuketiciEmail";
            lblTuketiciEmail.Size = new Size(50, 20);
            lblTuketiciEmail.TabIndex = 4;
            lblTuketiciEmail.Text = "E Mail";
            // 
            // lblTuketiciIl
            // 
            lblTuketiciIl.AutoSize = true;
            lblTuketiciIl.Location = new Point(27, 293);
            lblTuketiciIl.Name = "lblTuketiciIl";
            lblTuketiciIl.Size = new Size(42, 20);
            lblTuketiciIl.TabIndex = 5;
            lblTuketiciIl.Text = "Şehir";
            // 
            // lblTuketiciIslemleriTuketici
            // 
            lblTuketiciIslemleriTuketici.AutoSize = true;
            lblTuketiciIslemleriTuketici.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTuketiciIslemleriTuketici.Location = new Point(27, 88);
            lblTuketiciIslemleriTuketici.Name = "lblTuketiciIslemleriTuketici";
            lblTuketiciIslemleriTuketici.Size = new Size(121, 28);
            lblTuketiciIslemleriTuketici.TabIndex = 6;
            lblTuketiciIslemleriTuketici.Text = "Tuketicinin:";
            // 
            // lblTuketiciMahalle
            // 
            lblTuketiciMahalle.AutoSize = true;
            lblTuketiciMahalle.Location = new Point(27, 379);
            lblTuketiciMahalle.Name = "lblTuketiciMahalle";
            lblTuketiciMahalle.Size = new Size(93, 20);
            lblTuketiciMahalle.TabIndex = 7;
            lblTuketiciMahalle.Text = "Mahalle/Köy";
            // 
            // lblTuketiciIlce
            // 
            lblTuketiciIlce.AutoSize = true;
            lblTuketiciIlce.Location = new Point(27, 336);
            lblTuketiciIlce.Name = "lblTuketiciIlce";
            lblTuketiciIlce.Size = new Size(32, 20);
            lblTuketiciIlce.TabIndex = 8;
            lblTuketiciIlce.Text = "İlçe";
            // 
            // txtTuketiciAdi
            // 
            txtTuketiciAdi.Location = new Point(291, 120);
            txtTuketiciAdi.Name = "txtTuketiciAdi";
            txtTuketiciAdi.Size = new Size(329, 27);
            txtTuketiciAdi.TabIndex = 9;
            txtTuketiciAdi.TextChanged += TuketiciSave_TextChanged;
            // 
            // txtTuketiciSoyadi
            // 
            txtTuketiciSoyadi.Location = new Point(291, 161);
            txtTuketiciSoyadi.Name = "txtTuketiciSoyadi";
            txtTuketiciSoyadi.Size = new Size(329, 27);
            txtTuketiciSoyadi.TabIndex = 10;
            txtTuketiciSoyadi.TextChanged += TuketiciSave_TextChanged;
            // 
            // txtTuketiciTelNo
            // 
            txtTuketiciTelNo.Location = new Point(291, 204);
            txtTuketiciTelNo.Name = "txtTuketiciTelNo";
            txtTuketiciTelNo.Size = new Size(329, 27);
            txtTuketiciTelNo.TabIndex = 11;
            txtTuketiciTelNo.TextChanged += txtTuketiciTelNo_TextChanged;
            // 
            // txtTuketiciEmail
            // 
            txtTuketiciEmail.Location = new Point(291, 245);
            txtTuketiciEmail.Name = "txtTuketiciEmail";
            txtTuketiciEmail.Size = new Size(329, 27);
            txtTuketiciEmail.TabIndex = 12;
            txtTuketiciEmail.TextChanged += TuketiciSave_TextChanged;
            txtTuketiciEmail.Leave += txtTuketiciEmail_Leave;
            // 
            // btnTuketiciSave
            // 
            btnTuketiciSave.Location = new Point(291, 486);
            btnTuketiciSave.Name = "btnTuketiciSave";
            btnTuketiciSave.Size = new Size(208, 29);
            btnTuketiciSave.TabIndex = 16;
            btnTuketiciSave.Text = "Kaydet";
            btnTuketiciSave.UseVisualStyleBackColor = true;
            btnTuketiciSave.TextChanged += TuketiciSave_TextChanged;
            btnTuketiciSave.Click += btnTuketiciSave_Click;
            // 
            // cmbTuketiciIl
            // 
            cmbTuketiciIl.FormattingEnabled = true;
            cmbTuketiciIl.Location = new Point(291, 293);
            cmbTuketiciIl.Name = "cmbTuketiciIl";
            cmbTuketiciIl.Size = new Size(329, 28);
            cmbTuketiciIl.TabIndex = 17;
            cmbTuketiciIl.SelectedIndexChanged += cmbTuketiciIl_SelectedIndexChanged;
            // 
            // cmbTuketiciIlce
            // 
            cmbTuketiciIlce.FormattingEnabled = true;
            cmbTuketiciIlce.Location = new Point(291, 336);
            cmbTuketiciIlce.Name = "cmbTuketiciIlce";
            cmbTuketiciIlce.Size = new Size(329, 28);
            cmbTuketiciIlce.TabIndex = 18;
            cmbTuketiciIlce.SelectedIndexChanged += cmbTuketiciIlce_SelectedIndexChanged;
            // 
            // cmbTuketiciMahalle
            // 
            cmbTuketiciMahalle.FormattingEnabled = true;
            cmbTuketiciMahalle.Location = new Point(291, 379);
            cmbTuketiciMahalle.Name = "cmbTuketiciMahalle";
            cmbTuketiciMahalle.Size = new Size(329, 28);
            cmbTuketiciMahalle.TabIndex = 19;
            // 
            // btnTuketiciKayitCancel
            // 
            btnTuketiciKayitCancel.Location = new Point(526, 486);
            btnTuketiciKayitCancel.Name = "btnTuketiciKayitCancel";
            btnTuketiciKayitCancel.Size = new Size(94, 29);
            btnTuketiciKayitCancel.TabIndex = 20;
            btnTuketiciKayitCancel.Text = "Vazgeç";
            btnTuketiciKayitCancel.UseVisualStyleBackColor = true;
            btnTuketiciKayitCancel.Click += btnTuketiciKayitCancel_Click;
            // 
            // frmTuketiciIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 567);
            Controls.Add(btnTuketiciKayitCancel);
            Controls.Add(cmbTuketiciMahalle);
            Controls.Add(cmbTuketiciIlce);
            Controls.Add(cmbTuketiciIl);
            Controls.Add(btnTuketiciSave);
            Controls.Add(txtTuketiciEmail);
            Controls.Add(txtTuketiciTelNo);
            Controls.Add(txtTuketiciSoyadi);
            Controls.Add(txtTuketiciAdi);
            Controls.Add(lblTuketiciIlce);
            Controls.Add(lblTuketiciMahalle);
            Controls.Add(lblTuketiciIslemleriTuketici);
            Controls.Add(lblTuketiciIl);
            Controls.Add(lblTuketiciEmail);
            Controls.Add(lblTuketiciTelNo);
            Controls.Add(lblTuketiciSoyadi);
            Controls.Add(lblTuketiciAdi);
            Controls.Add(lblTüketiciIslemleriBaslik);
            Name = "frmTuketiciIslemleriForm";
            Text = "frmTuketiciIslemleri";
            Load += frmTuketiciIslemleriForm_Load;
            TextChanged += TuketiciSave_TextChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTüketiciIslemleriBaslik;
        private Label lblTuketiciAdi;
        private Label lblTuketiciSoyadi;
        private Label lblTuketiciTelNo;
        private Label lblTuketiciEmail;
        private Label lblTuketiciIl;
        private Label lblTuketiciIslemleriTuketici;
        private Label lblTuketiciMahalle;
        private Label lblTuketiciIlce;
        private TextBox txtTuketiciAdi;
        private TextBox txtTuketiciSoyadi;
        private TextBox txtTuketiciTelNo;
        private TextBox txtTuketiciEmail;
        private Button btnTuketiciSave;
        private ComboBox cmbTuketiciIl;
        private ComboBox cmbTuketiciIlce;
        private ComboBox cmbTuketiciMahalle;
        private Button btnTuketiciKayitCancel;
    }
}