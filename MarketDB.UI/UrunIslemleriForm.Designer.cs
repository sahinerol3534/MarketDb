namespace MarketDB.UI
{
    partial class frmUrunIslemleriForm
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
            lblUrunAdi = new Label();
            lblUrunMarkasi = new Label();
            lblUrunFiyati = new Label();
            lblUrunCinsi = new Label();
            lblUrunKategorisi = new Label();
            txtUrunAdi = new TextBox();
            txtUrunMarkasi = new TextBox();
            txtUrunFiyati = new TextBox();
            cmbUrunKategorisi = new ComboBox();
            btnUrunSave = new Button();
            txtUrunCinsi = new TextBox();
            SuspendLayout();
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Location = new Point(27, 74);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(83, 20);
            lblUrunAdi.TabIndex = 0;
            lblUrunAdi.Text = "Ürünün Adı";
            // 
            // lblUrunMarkasi
            // 
            lblUrunMarkasi.AutoSize = true;
            lblUrunMarkasi.Location = new Point(27, 113);
            lblUrunMarkasi.Name = "lblUrunMarkasi";
            lblUrunMarkasi.Size = new Size(111, 20);
            lblUrunMarkasi.TabIndex = 1;
            lblUrunMarkasi.Text = "Urünün Markası";
            // 
            // lblUrunFiyati
            // 
            lblUrunFiyati.AutoSize = true;
            lblUrunFiyati.Location = new Point(27, 162);
            lblUrunFiyati.Name = "lblUrunFiyati";
            lblUrunFiyati.Size = new Size(95, 20);
            lblUrunFiyati.TabIndex = 2;
            lblUrunFiyati.Text = "Ürünün Fiyatı";
            // 
            // lblUrunCinsi
            // 
            lblUrunCinsi.AutoSize = true;
            lblUrunCinsi.Location = new Point(27, 213);
            lblUrunCinsi.Name = "lblUrunCinsi";
            lblUrunCinsi.Size = new Size(91, 20);
            lblUrunCinsi.TabIndex = 3;
            lblUrunCinsi.Text = "Ürünün Cinsi";
            // 
            // lblUrunKategorisi
            // 
            lblUrunKategorisi.AutoSize = true;
            lblUrunKategorisi.Location = new Point(27, 257);
            lblUrunKategorisi.Name = "lblUrunKategorisi";
            lblUrunKategorisi.Size = new Size(127, 20);
            lblUrunKategorisi.TabIndex = 4;
            lblUrunKategorisi.Text = "Ürünün Kategorisi";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(182, 67);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(125, 27);
            txtUrunAdi.TabIndex = 5;
            txtUrunAdi.TextChanged += TextBox_TextChanged;
            // 
            // txtUrunMarkasi
            // 
            txtUrunMarkasi.Location = new Point(182, 113);
            txtUrunMarkasi.Name = "txtUrunMarkasi";
            txtUrunMarkasi.Size = new Size(125, 27);
            txtUrunMarkasi.TabIndex = 6;
            txtUrunMarkasi.TextChanged += TextBox_TextChanged;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(182, 159);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(125, 27);
            txtUrunFiyati.TabIndex = 7;
            txtUrunFiyati.TextChanged += TextBox_TextChanged;
            // 
            // cmbUrunKategorisi
            // 
            cmbUrunKategorisi.FormattingEnabled = true;
            cmbUrunKategorisi.Location = new Point(182, 249);
            cmbUrunKategorisi.Name = "cmbUrunKategorisi";
            cmbUrunKategorisi.Size = new Size(151, 28);
            cmbUrunKategorisi.TabIndex = 9;
            // 
            // btnUrunSave
            // 
            btnUrunSave.Location = new Point(489, 340);
            btnUrunSave.Name = "btnUrunSave";
            btnUrunSave.Size = new Size(229, 29);
            btnUrunSave.TabIndex = 10;
            btnUrunSave.Text = "Kaydet";
            btnUrunSave.UseVisualStyleBackColor = true;
            btnUrunSave.Click += btnUrunSave_Click;
            // 
            // txtUrunCinsi
            // 
            txtUrunCinsi.Location = new Point(182, 206);
            txtUrunCinsi.Name = "txtUrunCinsi";
            txtUrunCinsi.Size = new Size(125, 27);
            txtUrunCinsi.TabIndex = 11;
            txtUrunCinsi.TextChanged += TextBox_TextChanged;
            // 
            // frmUrunIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 450);
            Controls.Add(txtUrunCinsi);
            Controls.Add(btnUrunSave);
            Controls.Add(cmbUrunKategorisi);
            Controls.Add(txtUrunFiyati);
            Controls.Add(txtUrunMarkasi);
            Controls.Add(txtUrunAdi);
            Controls.Add(lblUrunKategorisi);
            Controls.Add(lblUrunCinsi);
            Controls.Add(lblUrunFiyati);
            Controls.Add(lblUrunMarkasi);
            Controls.Add(lblUrunAdi);
            Name = "frmUrunIslemleriForm";
            Text = "Ürün İşlemleri ";
            Load += frmUrunIslemleriForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUrunAdi;
        private Label lblUrunMarkasi;
        private Label lblUrunFiyati;
        private Label lblUrunCinsi;
        private Label lblUrunKategorisi;
        private TextBox txtUrunAdi;
        private TextBox txtUrunMarkasi;
        private TextBox txtUrunFiyati;
        private ComboBox cmbUrunKategorisi;
        private Button btnUrunSave;
        private TextBox txtUrunCinsi;
    }
}