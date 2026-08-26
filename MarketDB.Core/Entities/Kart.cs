namespace MarketDB.Core.Entities
{
    public class Kart: BaseEntity
    {
        public required string KartAdi {  get; set; }
        public int BankaId {  get; set; }
        public required Banka Banka { get; set; }
        public  ICollection<Satis> Satislar { get; set; }=new List<Satis>();
    }
}
