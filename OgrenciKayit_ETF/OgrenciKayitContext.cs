using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciKayit_ETF
{
    public class OgrenciKayitContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenci { get; set; }
    }
}
