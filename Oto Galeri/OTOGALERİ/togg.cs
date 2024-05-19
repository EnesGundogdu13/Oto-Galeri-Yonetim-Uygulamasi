using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOGALERİ
{
    public partial class togg : Form
    {
        public togg()
        {
            InitializeComponent();
        }

        int sayac = 0;
        string durum;

        private void btnsatinal_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("Aracı, başarıyla satın aldınız.\n Bizi tercih ettiğiniz için teşekkür eder iyi günler dileriz!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac++;
                durum = "satın aldınız.";
            }
            else
            {
                MessageBox.Show("Aracı zaten " + durum);
            }
        }

        private void btnkirala_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("Aracı, başarıyla kiraladınız.\n Bizi tercih ettiğiniz için teşekkür eder iyi günler dileriz!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac++;
                durum = "kiraladınız.";
            }
            else
            {
                MessageBox.Show("Aracı zaten " + durum);
            }
        }

        private void togg_Load(object sender, EventArgs e)
        {
            ekle();
            resim();
        }
        SqlConnection con;
        void resim()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = sınav; User Id = sa; Password = 123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From arabalar Where ilan_no=@id", con);
            cmd.Parameters.AddWithValue("@id", 5);
            SqlDataReader oku = cmd.ExecuteReader();
            try
            {
                if (oku.Read())
                {
                    if (oku["resim"] != null)
                    {
                        byte[] resim = new byte[0];
                        resim = (byte[])oku["resim"];
                        MemoryStream ms = new MemoryStream(resim);
                        pbaraba.Image = Image.FromStream(ms);
                        oku.Close();
                        cmd.Dispose();
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {
            }
            con.Close();
        }

        void ekle()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex);
            }
            finally
            {
                string sorgu = "Select * From arabalar Where ilan_no=5";
                SqlCommand cmd = new SqlCommand(sorgu, con);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    lblarabamarka.Text = oku[2].ToString();
                    lblbaslik.Text = oku[1].ToString();
                    lblarabamodeli.Text = oku[3].ToString();
                    lblcikistarihi.Text = oku[4].ToString();
                    lblkilometre.Text = oku[5].ToString();
                    lblbeygir.Text = oku[6].ToString();
                    lblarabaturu.Text = oku[7].ToString();
                    lblrenk.Text = oku[8].ToString();
                    lblhasarhaydi.Text = oku[9].ToString();
                    lblfiyat.Text = oku[10].ToString();
                    rtxaciklama.Text = oku[12].ToString();
                }
                con.Close();
            }
        }
    }
}
