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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciListesi _ogrenciListesi= new OgrenciListesi();   
            _ogrenciListesi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkle _ogrenciEkle= new OgrenciEkle();
            _ogrenciEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciGuncelle _ogrenciGuncelle= new OgrenciGuncelle(); 
            _ogrenciGuncelle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciSil _ogrencisil=new OgrenciSil();
            _ogrencisil.Show();
        }
    }
}
