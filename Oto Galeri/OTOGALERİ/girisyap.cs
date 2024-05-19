using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOGALERİ
{
    public partial class girisyap : Form
    {
        public girisyap()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader oku;

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
            con.Open();
            string sorgu = "Select * From Uyeler Where eposta=@eposta AND sifre=@sifre";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@eposta", txteposta.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                string mesaj = "Giriş Başarılı, Yönlendiriliyorsunuz...";
                MessageBox.Show(mesaj);
                AnaSayfa frm = new AnaSayfa();
                frm.Show();
                this.Hide();
            }
            con.Close();
        }

        private void cbsifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (txtsifre.PasswordChar == '*')
            {
                txtsifre.PasswordChar = '\0';
            }
            else
            {
                txtsifre.PasswordChar = '*';
            }
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
