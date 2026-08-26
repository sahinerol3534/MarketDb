namespace MarketDB.Core.Entities
{
    public class Fatura: BaseEntity
    {
        public  required string FaturaNo { get; set; }
        public int? TuketiciId { get; set; }
        public int SatisId { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public required Satis Satis { get; set; }
        public Tuketici? Tuketici { get; set; } 
    }
}
