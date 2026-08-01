using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class OdemeTuru: BaseEntity
    {
        public  string TurAdi {  get; set; }
        public ICollection<Satis> Satislar { get; set; }
    }
}
