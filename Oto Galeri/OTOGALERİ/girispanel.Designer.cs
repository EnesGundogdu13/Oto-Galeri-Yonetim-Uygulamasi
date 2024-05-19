namespace OTOGALERİ
{
    partial class girispanel
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
            this.btngeridon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeridon
            // 
            this.btngeridon.Location = new System.Drawing.Point(12, 415);
            this.btngeridon.Name = "btngeridon";
            this.btngeridon.Size = new System.Drawing.Size(75, 23);
            this.btngeridon.TabIndex = 0;
            this.btngeridon.Text = "Geri Dön";
            this.btngeridon.UseVisualStyleBackColor = true;
            this.btngeridon.Click += new System.EventHandler(this.btngeridon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(360, 240);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 31;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(360, 214);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txtkullaniciadi.TabIndex = 30;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(198, 181);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 29;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(198, 247);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 23);
            this.btngüncelle.TabIndex = 28;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(198, 214);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 27;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 136);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "id:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(360, 183);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 36;
            // 
            // girispanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngeridon);
            this.Name = "girispanel";
            this.Text = "girispanel";
            this.Load += new System.EventHandler(this.girispanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeridon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
    }
}