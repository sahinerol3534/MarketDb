using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class Kategori: BaseEntity
    {
        public string KategoriAdi { get; set; }
        public int? UstKategoriId { get; set; }
       
        public Kategori UstKategori { get; set; }
        public ICollection<Kategori> AltKategoriler { get; set; }
        public ICollection<Urun> Urunler { get; set; }


    }
}
