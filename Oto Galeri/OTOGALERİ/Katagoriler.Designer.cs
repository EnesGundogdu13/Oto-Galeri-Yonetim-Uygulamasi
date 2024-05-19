namespace OTOGALERİ
{
    partial class Katagoriler
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
            this.btnArabalar = new System.Windows.Forms.Button();
            this.btnGirisler = new System.Windows.Forms.Button();
            this.btnMüsteriler = new System.Windows.Forms.Button();
            this.btngeridon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArabalar
            // 
            this.btnArabalar.Location = new System.Drawing.Point(12, 12);
            this.btnArabalar.Name = "btnArabalar";
            this.btnArabalar.Size = new System.Drawing.Size(203, 137);
            this.btnArabalar.TabIndex = 0;
            this.btnArabalar.Text = "ARABALAR";
            this.btnArabalar.UseVisualStyleBackColor = true;
            this.btnArabalar.Click += new System.EventHandler(this.btnArabalar_Click);
            // 
            // btnGirisler
            // 
            this.btnGirisler.Location = new System.Drawing.Point(125, 189);
            this.btnGirisler.Name = "btnGirisler";
            this.btnGirisler.Size = new System.Drawing.Size(198, 151);
            this.btnGirisler.TabIndex = 1;
            this.btnGirisler.Text = "GİRİŞLER";
            this.btnGirisler.UseVisualStyleBackColor = true;
            this.btnGirisler.Click += new System.EventHandler(this.btnGirisler_Click);
            // 
            // btnMüsteriler
            // 
            this.btnMüsteriler.Location = new System.Drawing.Point(262, 12);
            this.btnMüsteriler.Name = "btnMüsteriler";
            this.btnMüsteriler.Size = new System.Drawing.Size(179, 137);
            this.btnMüsteriler.TabIndex = 2;
            this.btnMüsteriler.Text = "MÜŞTERİLER";
            this.btnMüsteriler.UseVisualStyleBackColor = true;
            this.btnMüsteriler.Click += new System.EventHandler(this.btnMüsteriler_Click);
            // 
            // btngeridon
            // 
            this.btngeridon.Location = new System.Drawing.Point(12, 344);
            this.btngeridon.Name = "btngeridon";
            this.btngeridon.Size = new System.Drawing.Size(75, 23);
            this.btngeridon.TabIndex = 3;
            this.btngeridon.Text = "Geri Dön";
            this.btngeridon.UseVisualStyleBackColor = true;
            this.btngeridon.Click += new System.EventHandler(this.btngeridon_Click);
            // 
            // Katagoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 379);
            this.Controls.Add(this.btngeridon);
            this.Controls.Add(this.btnMüsteriler);
            this.Controls.Add(this.btnGirisler);
            this.Controls.Add(this.btnArabalar);
            this.Name = "Katagoriler";
            this.Text = "Katagoriler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArabalar;
        private System.Windows.Forms.Button btnGirisler;
        private System.Windows.Forms.Button btnMüsteriler;
        private System.Windows.Forms.Button btngeridon;
    }
}