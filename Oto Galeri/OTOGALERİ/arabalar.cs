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
using static System.Net.Mime.MediaTypeNames.Image;
using System.IO;

namespace OTOGALERİ
{
    public partial class arabalar : Form
    {
        public arabalar()
        {
            InitializeComponent();
        }


        private void arabalar_Load(object sender, EventArgs e)
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM arabalar", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "arabalar");
                dataGridView1.DataSource = ds.Tables["arabalar"];
                con.Close();
            }
        }
        string resimyol;

        private void btnekle_Click(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream(resimyol, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(filestream);
            byte[] resim = binaryReader.ReadBytes((int)filestream.Length);
            binaryReader.Close();
            filestream.Close();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "set identity_insert arabalar on; INSERT INTO arabalar(ilan_no,baslik,araba_marka,araba_modeli,cikis_tarihi,kilometre,beygir,araba_türü,renk,hasar_kaydı,fiyat,resim,aciklama)VALUES(@ilan_no,@baslik,@araba_marka,@araba_modeli,@cikis_tarihi,@kilometre,@beygir,@araba_türü,@renk,@hasar_kaydı,@fiyat,@resim,@aciklama)";
            cmd.Parameters.AddWithValue("@ilan_no", txtilan.Text);
            cmd.Parameters.AddWithValue("@baslik", txtbaslik.Text);
            cmd.Parameters.AddWithValue("@araba_marka", txtarabamarka.Text);
            cmd.Parameters.AddWithValue("@araba_modeli", txtarabamodel.Text);
            cmd.Parameters.AddWithValue("@cikis_tarihi", txtcikistarihi.Text);
            cmd.Parameters.AddWithValue("@kilometre", txtkm.Text);
            cmd.Parameters.AddWithValue("@beygir", txtbeygir.Text);
            cmd.Parameters.AddWithValue("@araba_türü", txtarabatürü.Text);
            cmd.Parameters.AddWithValue("@renk", txtrenk.Text);
            cmd.Parameters.AddWithValue("@hasar_kaydı", txthasarkaydı.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            cmd.Parameters.Add("resim", SqlDbType.Image, resim.Length).Value = resim;
            cmd.Parameters.AddWithValue("@aciklama", rtxaciklama.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtilan.Clear();
                txtarabatürü.Clear();
                txtarabamodel.Clear();
                txtarabamarka.Clear();
                txtcikistarihi.Clear();
                txtkm.Clear();
                txtbeygir.Clear();
                txtrenk.Clear();
                txthasarkaydı.Clear();
                txtfiyat.Clear();
                txtbaslik.Clear();
                rtxaciklama.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("BAŞARIYLA EKLEME YAPTINIZ");
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
            cmd.CommandText = "Delete From arabalar Where ilan_no=@ilan_no";
            cmd.Parameters.AddWithValue("@ilan_no", txtilan.Text);
            try
            {
                cmd.ExecuteNonQuery();
                txtilan.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Başarıyla silme işlemini gerçekleştirdiniz.");
                griddoldur();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream(resimyol, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(filestream);
            byte[] resim = binaryReader.ReadBytes((int)filestream.Length);
            binaryReader.Close();
            filestream.Close();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE arabalar SET baslik=@baslik,araba_marka=@araba_marka,araba_modeli=@araba_modeli,cikis_tarihi=@cikis_tarihi,kilometre=@kilometre,beygir=@beygir,araba_türü=@araba_türü,renk=@renk,hasar_kaydı=@hasar_kaydı,fiyat=@fiyat,resim=@resim,aciklama=@aciklama Where ilan_no=@ilan_no";
            cmd.Parameters.AddWithValue("@ilan_no", txtilan.Text);
            cmd.Parameters.AddWithValue("@baslik", txtbaslik.Text);
            cmd.Parameters.AddWithValue("@araba_marka", txtarabamarka.Text);
            cmd.Parameters.AddWithValue("@araba_modeli", txtarabamodel.Text);
            cmd.Parameters.AddWithValue("@cikis_tarihi", txtcikistarihi.Text);
            cmd.Parameters.AddWithValue("@kilometre", txtkm.Text);
            cmd.Parameters.AddWithValue("@beygir", txtbeygir.Text);
            cmd.Parameters.AddWithValue("@araba_türü", txtarabatürü.Text);
            cmd.Parameters.AddWithValue("@renk", txtrenk.Text);
            cmd.Parameters.AddWithValue("@hasar_kaydı", txthasarkaydı.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            cmd.Parameters.AddWithValue("@aciklama", rtxaciklama.Text);
            cmd.Parameters.Add("resim", SqlDbType.Image, resim.Length).Value = resim;
            try
            {
                cmd.ExecuteNonQuery();
                txtilan.Clear();
                txtarabatürü.Clear();
                txtarabamodel.Clear();
                txtarabamarka.Clear();
                txtcikistarihi.Clear();
                txtkm.Clear();
                txtbeygir.Clear();
                txtrenk.Clear();
                txthasarkaydı.Clear();
                txtfiyat.Clear();
                txtbaslik.Clear();
                rtxaciklama.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Başarıyla düzenleme yaptınız");
                griddoldur();
            }
        }
        private void btnresimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim seç";
            openFileDialog1.Filter = "Jpg Dosyaları|*.jpg|jpeg Dosyaları|*.jpeg| Png Dosyaları|*.png| Gif Dosyaları|*.gif| Tüm Dosyalar | *.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbresim.Image = Image.FromFile(openFileDialog1.FileName);
                resimyol = openFileDialog1.FileName;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtilan.Text = dataGridView1.CurrentRow.Cells["ilan_no"].Value.ToString();
                txtbaslik.Text = dataGridView1.CurrentRow.Cells["baslik"].Value.ToString();
                txtarabamarka.Text = dataGridView1.CurrentRow.Cells["araba_marka"].Value.ToString();
                txtarabamodel.Text = dataGridView1.CurrentRow.Cells["araba_modeli"].Value.ToString();
                txtcikistarihi.Text = dataGridView1.CurrentRow.Cells["cikis_tarihi"].Value.ToString();
                txtkm.Text = dataGridView1.CurrentRow.Cells["kilometre"].Value.ToString();
                txtbeygir.Text = dataGridView1.CurrentRow.Cells["beygir"].Value.ToString();
                txtarabatürü.Text = dataGridView1.CurrentRow.Cells["araba_türü"].Value.ToString();
                txtrenk.Text = dataGridView1.CurrentRow.Cells["renk"].Value.ToString();
                txthasarkaydı.Text = dataGridView1.CurrentRow.Cells["hasar_kaydı"].Value.ToString();
                txtfiyat.Text = dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString();
                rtxaciklama.Text = dataGridView1.CurrentRow.Cells["aciklama"].Value.ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=localhost;Database=sınav;User Id=sa;Password=123456;";
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From arabalar Where ilan_no='" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'",con);
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    if (dr.Read())
                    {
                        if (dr["resim"] != null)
                        {
                            byte[] resim = new byte[0];
                            resim = (byte[])dr["resim"];
                            MemoryStream ms = new MemoryStream(resim);
                            pbresim.Image = Image.FromStream(ms);
                            dr.Close();
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
            catch (Exception)
            {
            }
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Katagoriler frm = new Katagoriler();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
