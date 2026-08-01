using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
   public class Ilce: BaseEntity
    {
        public string IlceAdi {  get; set; }
        public int IlId {  get; set; }
        public ICollection<Mahalle> Mahalleler { get; set; }   
    }
}
