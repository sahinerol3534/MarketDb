using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class Tuketici: BaseEntity
    {
        public string TuketiciAdi { get; set; }
        public string TuketiciSoyadi { get; set; }
        public string TuketiciTelNo { get; set; }
        public string TuketiciEmail { get; set; }
        public int MahalleId { get; set; }
        public Mahalle Mahalle { get; set; }
        public ICollection<Satis> Satislar {  get; set; }
    }
}
