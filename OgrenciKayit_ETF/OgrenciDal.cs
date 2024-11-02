using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciKayit_ETF
{
    public class OgrenciDal
    {
        public List<Ogrenci> OgrenciListele() {

            using (OgrenciKayitContext ogrenciKayitContext=new OgrenciKayitContext()) {



              return   ogrenciKayitContext.Ogrenci.ToList();
            
            
            }
        
        
        
        }
        public void OgrenciEkle(Ogrenci ogrenci) {


            using (OgrenciKayitContext ogrenciKayitContext = new OgrenciKayitContext())
            {



              ogrenciKayitContext.Ogrenci.Add(ogrenci);
                ogrenciKayitContext.SaveChanges();


            }


        }
        public void OgrenciSil(Ogrenci ogrenci)
        {


            using (OgrenciKayitContext ogrenciKayitContext = new OgrenciKayitContext())
            {



                var entity = ogrenciKayitContext.Entry(ogrenci);
                entity.State = EntityState.Deleted;
                ogrenciKayitContext.SaveChanges();


            }


        }
        public void OgrenciGuncelle(Ogrenci ogrenci)
        {


            using (OgrenciKayitContext ogrenciKayitContext = new OgrenciKayitContext())
            {



                var entity = ogrenciKayitContext.Entry(ogrenci);
                entity.State = EntityState.Modified;
                ogrenciKayitContext.SaveChanges();

            }


        }
    }
}
