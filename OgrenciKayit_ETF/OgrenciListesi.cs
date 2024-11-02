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
    public partial class OgrenciListesi : Form
    {
        public OgrenciListesi()
        {
            InitializeComponent();
        }

        private void OgrenciListesi_Load(object sender, EventArgs e)

        {
            OgrenciDal ogrenciDal = new OgrenciDal();
            dgwOgrenciListele.DataSource = ogrenciDal.OgrenciListele();
            dgwOgrenciListele.Columns[0].Visible= false;     
        }
    }
}
