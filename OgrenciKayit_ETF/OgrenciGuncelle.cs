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
    public partial class OgrenciGuncelle : Form
    {
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1;
            OgrenciDal ogrenci = new OgrenciDal();
             ogrenci.OgrenciGuncelle(new Ogrenci()
            {

                Id=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                OgrenciAdi = txtName.Text,
                OgrenciSoyadi = txtSurname.Text,
                OgrenciSinifi = txtSinif.Text,
                OgrenciBolumu=txtBolum.Text ,


            });
            MessageBox.Show("ÖĞRENCİ GÜNCELLENDİ");
            Listele();
        }
        public void Listele() {


            OgrenciDal ogrenciDal = new OgrenciDal();
            dataGridView1.DataSource = ogrenciDal.OgrenciListele();
            dataGridView1.Columns[0].Visible = false;


        }

        private void OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBolum.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSinif.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
