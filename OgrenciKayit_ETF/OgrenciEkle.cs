using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayit_ETF
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciDal ogrenciDal = new OgrenciDal();
            ogrenciDal.OgrenciEkle(new Ogrenci
            {
                OgrenciAdi = txtName.Text,
                OgrenciSoyadi = txtSoyad.Text,
                OgrenciBolumu = txtBolum.Text,
                OgrenciSinifi = cmbSinif.Text


            });
            MessageBox.Show("ÖĞRENCİ EKLENDİ");
            Listele();
           
        }
        public void Listele()
        {


            OgrenciDal ogrenciDal = new OgrenciDal();
            dataGridView1.DataSource = ogrenciDal.OgrenciListele();
            dataGridView1.Columns[0].Visible = false;


        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
