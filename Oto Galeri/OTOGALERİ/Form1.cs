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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            Girisler frm = new Girisler();
            frm.Show();
            this.Hide();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            Kayitol frm = new Kayitol();
            frm.Show();
            this.Hide();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            girisyap frm = new girisyap();
            frm.Show();
            this.Hide();
        }
    }
}
        
