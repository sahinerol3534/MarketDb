namespace MarketDB.Core.Entities
{
    public class Marketler: BaseEntity
    {
        public required string MarketAdi { get; set; }
        public  ICollection<Sube> Subeler { get; set; } = new List<Sube>();
    }
}
