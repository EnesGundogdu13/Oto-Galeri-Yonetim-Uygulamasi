using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OTOGALERİ
{
    public partial class Müsteriler : Form
    {
        public Müsteriler()
        {
            InitializeComponent();
        }

        private void Müsteriler_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }
        SqlConnection con;
        void gridDoldur()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server = localhost; Database = sınav; User Id = sa; password = 123456;";
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("hata:" + ex.Message);
            }
            finally
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM musteriler", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "musteriler");
                dataGridView1.DataSource = ds.Tables["musteriler"];
                con.Close();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO musteriler(musteri_adi,musteri_soyadi,telefon,id)VALUES(@musteri_adi,@musteri_soyadi,@telefon,@id)";
            cmd.Parameters.AddWithValue("@musteri_adi", txtad.Text);
            cmd.Parameters.AddWithValue("@musteri_soyadi", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txttel.Text);
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtad.Clear();
                txtsoyad.Clear();
                txttel.Clear();
                txtid.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("BAŞARIYLA EKLEME YAPTINIZ");
                gridDoldur();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM musteriler WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", txtid.Text);

            try
            {
                cmd.ExecuteNonQuery();
                txtid.Clear();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("KAYIT BAŞARIYLA SİLİNDİ" + txtid.Text);
                gridDoldur();
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE musteriler SET musteri_adi=@musteri_adi,musteri_soyadi=@musteri_soyadi,telefon=@telefon WHERE id=@id;";
            cmd.Parameters.AddWithValue("@musteri_adi", txtad.Text);
            cmd.Parameters.AddWithValue("@musteri_soyadi", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txttel.Text);
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtad.Clear();
                txtsoyad.Clear();
                txttel.Clear();
                txtid.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("BAŞARIYLA EKLEME YAPTINIZ");
                gridDoldur();
            }
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Katagoriler frm = new Katagoriler();
            this.Hide();
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells["musteri_adi"].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells["musteri_soyadi"].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
        }
    }
}
