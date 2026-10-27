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
            lblUrunAdi.Location = new Point(24, 56);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(68, 15);
            lblUrunAdi.TabIndex = 0;
            lblUrunAdi.Text = "Ürünün Adı";
            // 
            // lblUrunMarkasi
            // 
            lblUrunMarkasi.AutoSize = true;
            lblUrunMarkasi.Location = new Point(24, 85);
            lblUrunMarkasi.Name = "lblUrunMarkasi";
            lblUrunMarkasi.Size = new Size(91, 15);
            lblUrunMarkasi.TabIndex = 1;
            lblUrunMarkasi.Text = "Urünün Markası";
            // 
            // lblUrunFiyati
            // 
            lblUrunFiyati.AutoSize = true;
            lblUrunFiyati.Location = new Point(24, 122);
            lblUrunFiyati.Name = "lblUrunFiyati";
            lblUrunFiyati.Size = new Size(78, 15);
            lblUrunFiyati.TabIndex = 2;
            lblUrunFiyati.Text = "Ürünün Fiyatı";
            // 
            // lblUrunCinsi
            // 
            lblUrunCinsi.AutoSize = true;
            lblUrunCinsi.Location = new Point(24, 160);
            lblUrunCinsi.Name = "lblUrunCinsi";
            lblUrunCinsi.Size = new Size(76, 15);
            lblUrunCinsi.TabIndex = 3;
            lblUrunCinsi.Text = "Ürünün Cinsi";
            // 
            // lblUrunKategorisi
            // 
            lblUrunKategorisi.AutoSize = true;
            lblUrunKategorisi.Location = new Point(24, 193);
            lblUrunKategorisi.Name = "lblUrunKategorisi";
            lblUrunKategorisi.Size = new Size(102, 15);
            lblUrunKategorisi.TabIndex = 4;
            lblUrunKategorisi.Text = "Ürünün Kategorisi";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(159, 50);
            txtUrunAdi.Margin = new Padding(3, 2, 3, 2);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(110, 23);
            txtUrunAdi.TabIndex = 5;
            txtUrunAdi.TextChanged += TextBox_TextChanged;
            // 
            // txtUrunMarkasi
            // 
            txtUrunMarkasi.Location = new Point(159, 85);
            txtUrunMarkasi.Margin = new Padding(3, 2, 3, 2);
            txtUrunMarkasi.Name = "txtUrunMarkasi";
            txtUrunMarkasi.Size = new Size(110, 23);
            txtUrunMarkasi.TabIndex = 6;
            txtUrunMarkasi.TextChanged += TextBox_TextChanged;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(159, 119);
            txtUrunFiyati.Margin = new Padding(3, 2, 3, 2);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(110, 23);
            txtUrunFiyati.TabIndex = 7;
            txtUrunFiyati.TextChanged += TextBox_TextChanged;
            // 
            // cmbUrunKategorisi
            // 
            cmbUrunKategorisi.FormattingEnabled = true;
            cmbUrunKategorisi.Location = new Point(159, 187);
            cmbUrunKategorisi.Margin = new Padding(3, 2, 3, 2);
            cmbUrunKategorisi.Name = "cmbUrunKategorisi";
            cmbUrunKategorisi.Size = new Size(133, 23);
            cmbUrunKategorisi.TabIndex = 9;
            // 
            // btnUrunSave
            // 
            btnUrunSave.Location = new Point(428, 255);
            btnUrunSave.Margin = new Padding(3, 2, 3, 2);
            btnUrunSave.Name = "btnUrunSave";
            btnUrunSave.Size = new Size(200, 22);
            btnUrunSave.TabIndex = 10;
            btnUrunSave.Text = "Kaydet";
            btnUrunSave.UseVisualStyleBackColor = true;
            btnUrunSave.Click += btnUrunSave_Click;
            // 
            // txtUrunCinsi
            // 
            txtUrunCinsi.Location = new Point(159, 154);
            txtUrunCinsi.Margin = new Padding(3, 2, 3, 2);
            txtUrunCinsi.Name = "txtUrunCinsi";
            txtUrunCinsi.Size = new Size(110, 23);
            txtUrunCinsi.TabIndex = 11;
            txtUrunCinsi.TextChanged += TextBox_TextChanged;
            // 
            // frmUrunIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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