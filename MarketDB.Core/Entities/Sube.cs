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


    }
}
