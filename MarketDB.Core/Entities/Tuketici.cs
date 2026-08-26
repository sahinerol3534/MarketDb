namespace MarketDB.Core.Entities
{
    public class Tuketici: BaseEntity
    {
        public required string TuketiciAdi { get; set; }
        public required string TuketiciSoyadi { get; set; }
        public required string TuketiciTelNo { get; set; }
        public  string? TuketiciEmail { get; set; } 
        public int? MahalleId { get; set; }           
        public  Mahalle? Mahalle { get; set; }
        public  ICollection<Satis> Satislar {  get; set; } = new List<Satis>();
    }
}
