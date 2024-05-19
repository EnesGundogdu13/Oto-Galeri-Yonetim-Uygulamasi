namespace OTOGALERİ
{
    partial class girisyap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisyap));
            this.txteposta = new System.Windows.Forms.TextBox();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.cbsifregoster = new System.Windows.Forms.CheckBox();
            this.btngeridon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(646, 161);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(116, 20);
            this.txteposta.TabIndex = 0;
            // 
            // btngirisyap
            // 
            this.btngirisyap.Location = new System.Drawing.Point(646, 284);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(116, 33);
            this.btngirisyap.TabIndex = 1;
            this.btngirisyap.Text = "Giriş Yap";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(646, 202);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(116, 20);
            this.txtsifre.TabIndex = 2;
            // 
            // cbsifregoster
            // 
            this.cbsifregoster.AutoSize = true;
            this.cbsifregoster.Location = new System.Drawing.Point(646, 239);
            this.cbsifregoster.Name = "cbsifregoster";
            this.cbsifregoster.Size = new System.Drawing.Size(88, 17);
            this.cbsifregoster.TabIndex = 3;
            this.cbsifregoster.Text = "Şifreyi Göster";
            this.cbsifregoster.UseVisualStyleBackColor = true;
            this.cbsifregoster.CheckedChanged += new System.EventHandler(this.cbsifregoster_CheckedChanged);
            // 
            // btngeridon
            // 
            this.btngeridon.Location = new System.Drawing.Point(572, 415);
            this.btngeridon.Name = "btngeridon";
            this.btngeridon.Size = new System.Drawing.Size(75, 23);
            this.btngeridon.TabIndex = 4;
            this.btngeridon.Text = "Geri Dön";
            this.btngeridon.UseVisualStyleBackColor = true;
            this.btngeridon.Click += new System.EventHandler(this.btngeridon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(641, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giriş Yap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "E-Posta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre:";
            // 
            // girisyap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngeridon);
            this.Controls.Add(this.cbsifregoster);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.txteposta);
            this.Name = "girisyap";
            this.Text = "girisyap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.CheckBox cbsifregoster;
        private System.Windows.Forms.Button btngeridon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}