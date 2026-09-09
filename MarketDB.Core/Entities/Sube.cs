using System.ComponentModel.DataAnnotations.Schema;

namespace MarketDB.Core.Entities
{
   public class Sube: BaseEntity
    {
        public required string SubeAdi { get; set; }
        public int MarketId { get; set; }
        public required Marketler Market { get; set; }
      
        public int MahalleId { get; set; }
        public required Mahalle Mahalle { get; set; }
        public ICollection<Satis> Satislar { get; set; } = new List<Satis>();
    
        [NotMapped]
        
        //public string SubeIlIlceMahalle => $"{SubeAdi}-{Mahalle.MahalleAdi}-{Mahalle.Ilce.IlceAdi}-{Mahalle.Ilce.Il.IlAdi}";
        public string SubeIlIlceMahalle
        {
            get 
            {
                string[] FakeSubeFormatDizin = { SubeAdi, Mahalle.MahalleAdi, Mahalle.Ilce.IlceAdi, Mahalle.Ilce.Il.IlAdi };
                List<string> subeIlIlceMahalle = FakeSubeFormatDizin.Where(f=>f != "").ToList();
                string temizSube=string.Join("-", subeIlIlceMahalle);
                return temizSube;
            }
    } 
        
       

    }
}
