using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class Marketler: BaseEntity
    {
        public string MarketAdi { get; set; }
        public ICollection<Sube> Subeler { get; set; }
    }
}
