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
    public partial class Kayitol : Form
    {
        public Kayitol()
        {
            InitializeComponent();
        }

        private void cbsifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsifregoster.Checked == true) 
            {
                txtsifre.PasswordChar = '\0';
                txtsifreonay.PasswordChar = '\0';
            }
            else
            {
                txtsifre.PasswordChar = '*';
                txtsifreonay.PasswordChar = '*';
            }
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            if (txteposta.Text != "" || txtsifre.Text != "" || txtsifreonay.Text != "")
            {
                if (txtsifre.Text == txtsifreonay.Text)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    DateTime bugun = DateTime.Today;
                    cmd.CommandText = "INSERT INTO Uyeler(eposta,sifre,kayit_tarihi) VALUES (@eposta,@sifre,@kayit_tarihi)";
                    cmd.Parameters.AddWithValue("@eposta", txteposta.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
                    cmd.Parameters.AddWithValue("@kayit_tarihi", bugun);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        txteposta.Clear();
                        txtsifre.Clear();
                        txtsifreonay.Clear();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Hata:" + ex);
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show("Kayıt başarıyla oluşturuldu!");
                    }
                }
            }
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
