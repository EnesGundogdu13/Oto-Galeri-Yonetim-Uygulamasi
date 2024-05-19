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
    public partial class Girisler : Form
    {
        public Girisler()
        {
            InitializeComponent();
        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader oku;

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = sınav; User Id = sa; password = 123456;";
            con.Open();
            string sorgu = "SELECT kullanici_adi,sifre FROM giriş WHERE kullanici_adi = @kullanici_adi AND sifre = @sifre;";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@kullanici_adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                string mesaj = "Hosgeldin " + oku[0].ToString();
                MessageBox.Show(mesaj);
                Katagoriler frm = new Katagoriler();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            con.Close();
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
