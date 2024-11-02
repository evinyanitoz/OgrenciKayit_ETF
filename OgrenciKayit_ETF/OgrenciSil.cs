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
    public partial class OgrenciSil : Form
    {
        public OgrenciSil()
        {
            InitializeComponent();
        }

        private void OgrenciSil_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {


            OgrenciDal ogrenciDal = new OgrenciDal();
            dataGridView1.DataSource = ogrenciDal.OgrenciListele();
            dataGridView1.Columns[0].Visible = false;


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OgrenciDal dal = new OgrenciDal();
            dal.OgrenciSil(new Ogrenci()
            {

                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                OgrenciAdi = txtName.Text,
                OgrenciSoyadi = txtSurname.Text,
                OgrenciSinifi = cmbSinif.Text,
                OgrenciBolumu = txtBolum.Text,


            });
            MessageBox.Show("ÖĞRENCİ SİLİNDİ");
            Listele();
        }
    }
}
