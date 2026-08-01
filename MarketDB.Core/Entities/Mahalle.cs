using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDB.Core.Entities
{
    public class Mahalle : BaseEntity
    {
        public string MahalleAdi {  get; set; }
        public string MahalleTuru {  get; set; }
        public int IlceId {  get; set; } 
        public ICollection<Tuketici> Tuketiciler { get; set; }


    }
}

