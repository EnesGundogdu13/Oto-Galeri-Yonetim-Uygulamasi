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
    public partial class Katagoriler : Form
    {
        public Katagoriler()
        {
            InitializeComponent();
        }

        private void btnArabalar_Click(object sender, EventArgs e)
        {
            arabalar frm = new arabalar();
            this.Hide();
            frm.Show();
        }

        private void btnMüsteriler_Click(object sender, EventArgs e)
        {
            Müsteriler frm = new Müsteriler();
            this.Hide();
            frm.Show();
        }

        private void btnGirisler_Click(object sender, EventArgs e)
        {
            girispanel frm = new girispanel();
            this.Hide();
            frm.Show();
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
