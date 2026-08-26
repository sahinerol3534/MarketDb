namespace MarketDB.Core.Entities
{
   public class Ilce: BaseEntity
    {
        public required string IlceAdi {  get; set; }
        public int IlId {  get; set; }
        public required Il Il { get; set; }
        public  ICollection<Mahalle> Mahalleler { get; set; }   = new List<Mahalle>();
    }
}
