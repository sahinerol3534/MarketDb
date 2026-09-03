namespace MarketDB.Core.Entities
{
    public class Satis: BaseEntity
    {
        public int? TuketiciId { get; set; }                                   
        public int SubeId { get; set; }
        public string? FisNo { get; set; }
        public DateTime SatisTarihi { get; set; }                          
        public int OdemeSekliId { get; set; }                                     
        public int OdemeTuruId { get; set; }                                           
        public int? KartId { get; set; }
        public decimal? SatisToplami { get; set; }
        public decimal? IndirimToplami { get; set; }
        public decimal? KdvToplami { get; set; }
        public Kart? Kart { get; set; }
        public Tuketici?  Tuketici { get; set; }  
       public  Sube? Sube { get; set; }
       public  OdemeSekli?  OdemeSekli { get; set; }
       public  OdemeTuru? OdemeTuru { get; set; }
     
       public  ICollection<SatisKalemi> SatisKalemleri { get; set; } = new List<SatisKalemi>();
    }
}
