namespace OTOGALERİ
{
    partial class Form1
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
            this.btnkayit = new System.Windows.Forms.Button();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.btnadmingiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkayit
            // 
            this.btnkayit.Location = new System.Drawing.Point(566, 15);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(75, 23);
            this.btnkayit.TabIndex = 7;
            this.btnkayit.Text = "Kayıt Ol";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // btngirisyap
            // 
            this.btngirisyap.Location = new System.Drawing.Point(647, 15);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(75, 23);
            this.btngirisyap.TabIndex = 6;
            this.btngirisyap.Text = "Giriş Yap";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // btnadmingiris
            // 
            this.btnadmingiris.Location = new System.Drawing.Point(485, 15);
            this.btnadmingiris.Name = "btnadmingiris";
            this.btnadmingiris.Size = new System.Drawing.Size(75, 23);
            this.btnadmingiris.TabIndex = 5;
            this.btnadmingiris.Text = "Admin Giriş";
            this.btnadmingiris.UseVisualStyleBackColor = true;
            this.btnadmingiris.Click += new System.EventHandler(this.btnadmingiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 354);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.btnadmingiris);
            this.Name = "Form1";
            this.Text = "GYK GARAJ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.Button btnadmingiris;
    }
}

