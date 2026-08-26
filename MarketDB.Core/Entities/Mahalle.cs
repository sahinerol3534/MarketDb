namespace MarketDB.Core.Entities
{
    public class Mahalle : BaseEntity
    {
        public required string MahalleAdi {  get; set; }
        public string? MahalleTuru {  get; set; }
        public int IlceId {  get; set; } 
        public required Ilce Ilce { get; set; }
        public  ICollection<Tuketici> Tuketiciler { get; set; } = new List<Tuketici>();


    }
}

