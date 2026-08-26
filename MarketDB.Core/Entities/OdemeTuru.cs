namespace MarketDB.Core.Entities
{
    public class OdemeTuru: BaseEntity
    {
        public  required string TurAdi {  get; set; }
        public ICollection<Satis> Satislar { get; set; } = new List<Satis>();
    }
}
