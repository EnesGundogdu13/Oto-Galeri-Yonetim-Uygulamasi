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
    public partial class girispanel : Form
    {
        public girispanel()
        {
            InitializeComponent();
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Katagoriler frm = new Katagoriler();
            this.Hide();
            frm.Show();
        }

        private void girispanel_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        SqlConnection con;
        void griddoldur()
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM giriş", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "giriş");
                dataGridView1.DataSource = ds.Tables["giriş"];
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
            cmd.CommandText = "INSERT INTO giriş(kullanici_adi,sifre)VALUES(@kullanici_adi,@sifre)";
            cmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtkullaniciadi.Clear();
                txtsifre.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Başarıyla ekleme yaptınız.");
                griddoldur();
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
            cmd.CommandText = "Delete From giriş Where id=@id";
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
                MessageBox.Show("başarıyla silme yaptınız.");
                griddoldur();
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
            cmd.CommandText = "Update giriş Set kullanici_adi=@kullanici_adi,sifre=@sifre Where id=@id";
            cmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtid.Clear();
                txtkullaniciadi.Clear();
                txtsifre.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Başarıyla güncelleme yaptınız.");
                griddoldur();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txtkullaniciadi.Text = dataGridView1.CurrentRow.Cells["kullanici_adi"].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
        }
    }
}
