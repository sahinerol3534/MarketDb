namespace MarketDB.UI
{
    partial class DashboardForm
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

        private void InitializeComponent()
        {
            btnUrunleriListele = new Button();
            dgvUrunler = new DataGridView();
            btnUrunIslemleri = new Button();
            btnMarketIslemleri = new Button();
            btnTuketiciIslemleri = new Button();
            btnSatisIslemleri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // btnUrunleriListele
            // 
            btnUrunleriListele.Location = new Point(27, 5);
            btnUrunleriListele.Name = "btnUrunleriListele";
            btnUrunleriListele.Size = new Size(202, 29);
            btnUrunleriListele.TabIndex = 0;
            btnUrunleriListele.TabStop = false;
            btnUrunleriListele.Text = "Ürünleri Listele";
            btnUrunleriListele.UseVisualStyleBackColor = true;
            btnUrunleriListele.Click += btnUrunleriListele_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(27, 40);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(1224, 240);
            dgvUrunler.TabIndex = 1;
            // 
            // btnUrunIslemleri
            // 
            btnUrunIslemleri.Location = new Point(27, 297);
            btnUrunIslemleri.Name = "btnUrunIslemleri";
            btnUrunIslemleri.Size = new Size(202, 29);
            btnUrunIslemleri.TabIndex = 2;
            btnUrunIslemleri.Text = "Ürün İşlemleri";
            btnUrunIslemleri.UseVisualStyleBackColor = true;
            btnUrunIslemleri.Click += btnUrunIslemleri_Click;
            // 
            // btnMarketIslemleri
            // 
            btnMarketIslemleri.Location = new Point(27, 333);
            btnMarketIslemleri.Name = "btnMarketIslemleri";
            btnMarketIslemleri.Size = new Size(202, 29);
            btnMarketIslemleri.TabIndex = 3;
            btnMarketIslemleri.Text = "Market İşlemleri";
            btnMarketIslemleri.UseVisualStyleBackColor = true;
            btnMarketIslemleri.Click += btnMarketIslemleri_Click;
            // 
            // btnTuketiciIslemleri
            // 
            btnTuketiciIslemleri.Location = new Point(27, 368);
            btnTuketiciIslemleri.Name = "btnTuketiciIslemleri";
            btnTuketiciIslemleri.Size = new Size(202, 29);
            btnTuketiciIslemleri.TabIndex = 4;
            btnTuketiciIslemleri.Text = "Tüketici İşlemleri";
            btnTuketiciIslemleri.UseVisualStyleBackColor = true;
            btnTuketiciIslemleri.Click += btnTuketiciIslemleri_Click;
            // 
            // btnSatisIslemleri
            // 
            btnSatisIslemleri.Location = new Point(27, 405);
            btnSatisIslemleri.Name = "btnSatisIslemleri";
            btnSatisIslemleri.Size = new Size(202, 29);
            btnSatisIslemleri.TabIndex = 5;
            btnSatisIslemleri.Text = "Satış İşlemleri";
            btnSatisIslemleri.UseVisualStyleBackColor = true;
            btnSatisIslemleri.Click += btnSatisIslemleri_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 514);
            Controls.Add(btnSatisIslemleri);
            Controls.Add(btnTuketiciIslemleri);
            Controls.Add(btnMarketIslemleri);
            Controls.Add(btnUrunIslemleri);
            Controls.Add(dgvUrunler);
            Controls.Add(btnUrunleriListele);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
        }



        private Button btnUrunleriListele;
        private DataGridView dgvUrunler;
        private Button btnUrunIslemleri;
        private Button btnMarketIslemleri;
        private Button btnTuketiciIslemleri;
        private Button btnSatisIslemleri;
    }
}


