using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class Banka: BaseEntity
    {
        public string BankaAdi { get; set; }
        public ICollection <Kart> Kartlar {  get; set; }
    }
}
