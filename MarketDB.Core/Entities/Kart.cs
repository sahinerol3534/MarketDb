using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class Kart: BaseEntity
    {
        public string KartAdi {  get; set; }
        public int BankaId {  get; set; }
        public Banka Banka { get; set; }
        public ICollection<Satis> Satislar { get; set; }

    }
}
