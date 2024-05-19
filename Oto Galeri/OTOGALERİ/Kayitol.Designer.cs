namespace OTOGALERİ
{
    partial class Kayitol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayitol));
            this.txteposta = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtsifreonay = new System.Windows.Forms.TextBox();
            this.cbsifregoster = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnkayitol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btngeridon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(582, 151);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(206, 20);
            this.txteposta.TabIndex = 0;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(582, 193);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 1;
            // 
            // txtsifreonay
            // 
            this.txtsifreonay.Location = new System.Drawing.Point(688, 193);
            this.txtsifreonay.Name = "txtsifreonay";
            this.txtsifreonay.PasswordChar = '*';
            this.txtsifreonay.Size = new System.Drawing.Size(100, 20);
            this.txtsifreonay.TabIndex = 2;
            // 
            // cbsifregoster
            // 
            this.cbsifregoster.AutoSize = true;
            this.cbsifregoster.Location = new System.Drawing.Point(582, 232);
            this.cbsifregoster.Name = "cbsifregoster";
            this.cbsifregoster.Size = new System.Drawing.Size(88, 17);
            this.cbsifregoster.TabIndex = 3;
            this.cbsifregoster.Text = "Şifreyi Göster";
            this.cbsifregoster.UseVisualStyleBackColor = true;
            this.cbsifregoster.CheckedChanged += new System.EventHandler(this.cbsifregoster_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // btnkayitol
            // 
            this.btnkayitol.Location = new System.Drawing.Point(640, 275);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(95, 23);
            this.btnkayitol.TabIndex = 6;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = true;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(631, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kayıt Ol";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btngeridon
            // 
            this.btngeridon.Location = new System.Drawing.Point(524, 415);
            this.btngeridon.Name = "btngeridon";
            this.btngeridon.Size = new System.Drawing.Size(75, 23);
            this.btngeridon.TabIndex = 9;
            this.btngeridon.Text = "Geri Dön";
            this.btngeridon.UseVisualStyleBackColor = true;
            this.btngeridon.Click += new System.EventHandler(this.btngeridon_Click);
            // 
            // Kayitol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngeridon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnkayitol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbsifregoster);
            this.Controls.Add(this.txtsifreonay);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txteposta);
            this.Name = "Kayitol";
            this.Text = "Kayitol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtsifreonay;
        private System.Windows.Forms.CheckBox cbsifregoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkayitol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btngeridon;
    }
}