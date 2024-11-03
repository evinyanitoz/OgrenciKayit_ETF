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
      OgrenciKayitContext ogrenciKayitContext = new OgrenciKayitContext();
        
        public List<Ogrenci> OgrenciListele() {
       return   ogrenciKayitContext.Ogrenci.ToList();

        }
        public void OgrenciEkle(Ogrenci ogrenci) {

                 ogrenciKayitContext.Ogrenci.Add(ogrenci);
                ogrenciKayitContext.SaveChanges();

        }
        public void OgrenciSil(Ogrenci ogrenci)
        {

                var entity = ogrenciKayitContext.Entry(ogrenci);
                entity.State = EntityState.Deleted;
                ogrenciKayitContext.SaveChanges();

        }
        public void OgrenciGuncelle(Ogrenci ogrenci)
        {
                var entity = ogrenciKayitContext.Entry(ogrenci);
                entity.State = EntityState.Modified;
                ogrenciKayitContext.SaveChanges();  }
    }
}
