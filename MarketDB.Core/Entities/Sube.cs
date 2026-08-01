using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
   public class Sube: BaseEntity
    {
        public string SubeAdi { get; set; }
        public int MarketId { get; set; }
        public Marketler Market { get; set; }
      
        public int MahalleId { get; set; }
        public Mahalle Mahalle { get; set; }
        public ICollection<Satis> Satislar { get; set; }


    }
}
