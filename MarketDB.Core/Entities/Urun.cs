using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class Urun: BaseEntity
    {
        public string UrunAdi { get; set; }
        public string UrunMarkasi { get; set; }
        public string UrunCinsi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int KategoriId { get; set; }
        public Kategori  Kategori {  get; set; }

    }
}
