using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class Il : BaseEntity
    {
        public string IlAdi { get; set; }
        public int IlKodu {  get; set; }
        public ICollection<Ilce> Ilceler { get; set; }
    
    }
}

