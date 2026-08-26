namespace MarketDB.Core.Entities
{
    public class OdemeSekli: BaseEntity
    {
        public required string OdemeAdi {  get; set; }
        public  ICollection<Satis> Satislar { get; set; } = new List<Satis>(); 
    }
}
