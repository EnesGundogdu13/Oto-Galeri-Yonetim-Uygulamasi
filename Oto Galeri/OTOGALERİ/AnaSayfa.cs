using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOGALERİ
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mazda frm = new mazda();
            frm.Show();
            this.Hide();
        }

        private void pbaraba2_Click(object sender, EventArgs e)
        {
            nissan frm = new nissan();
            frm.Show();
            this.Hide();
        }

        private void pbaraba3_Click(object sender, EventArgs e)
        {
            dodge frm = new dodge();
            frm.Show();
            this.Hide();
        }

        private void pbaraba4_Click(object sender, EventArgs e)
        {
            Volvo frm = new Volvo();
            frm.Show();
            this.Hide();
        }

        private void pbaraba5_Click(object sender, EventArgs e)
        {
            togg frm = new togg();
            frm.Show();
            this.Hide();
        }

        private void pbaraba6_Click(object sender, EventArgs e)
        {
            volkswagen frm = new volkswagen();
            frm.Show();
            this.Hide();
        }

        private void btncikisyap_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
