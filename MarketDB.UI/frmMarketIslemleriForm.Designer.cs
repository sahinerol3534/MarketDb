namespace MarketDB.UI
{
    partial class frmMarketIslemleriForm
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
            lblFormBasligi = new Label();
            lblMarketAdi = new Label();
            txtMarketAdi = new TextBox();
            btnMarketSave = new Button();
            SuspendLayout();
            // 
            // lblFormBasligi
            // 
            lblFormBasligi.AutoSize = true;
            lblFormBasligi.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFormBasligi.Location = new Point(21, 23);
            lblFormBasligi.Name = "lblFormBasligi";
            lblFormBasligi.Size = new Size(234, 38);
            lblFormBasligi.TabIndex = 0;
            lblFormBasligi.Text = "Market İşlemleri";
            // 
            // lblMarketAdi
            // 
            lblMarketAdi.AutoSize = true;
            lblMarketAdi.Location = new Point(21, 93);
            lblMarketAdi.Name = "lblMarketAdi";
            lblMarketAdi.Size = new Size(82, 20);
            lblMarketAdi.TabIndex = 1;
            lblMarketAdi.Text = "Market Adı";
            // 
            // txtMarketAdi
            // 
            txtMarketAdi.Location = new Point(120, 90);
            txtMarketAdi.Name = "txtMarketAdi";
            txtMarketAdi.Size = new Size(125, 27);
            txtMarketAdi.TabIndex = 2;
            txtMarketAdi.TextChanged += txtMarketAdi_TextChanged;
            // 
            // btnMarketSave
            // 
            btnMarketSave.Location = new Point(521, 282);
            btnMarketSave.Name = "btnMarketSave";
            btnMarketSave.Size = new Size(221, 29);
            btnMarketSave.TabIndex = 3;
            btnMarketSave.Text = "Kaydet";
            btnMarketSave.UseVisualStyleBackColor = true;
            btnMarketSave.Click += btnMarketSave_Click;
            // 
            // frmMarketIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 450);
            Controls.Add(btnMarketSave);
            Controls.Add(txtMarketAdi);
            Controls.Add(lblMarketAdi);
            Controls.Add(lblFormBasligi);
            Name = "frmMarketIslemleriForm";
            Text = "frmMarketIslemleriForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormBasligi;
        private Label lblMarketAdi;
        private TextBox txtMarketAdi;
        private Button btnMarketSave;
    }
}