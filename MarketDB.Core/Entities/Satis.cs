namespace MarketDB.Core.Entities
{
    public class Satis: BaseEntity
    {
        public int? TuketiciId { get; set; }                                   
        public int SubeId { get; set; }                                        
        public DateTime SatisTarihi { get; set; }                          
        public decimal? SatisToplami { get; set; }                       
        public decimal? IndirimToplami { get; set; }                    
        public decimal? KdvToplami { get; set; }                         
        public int OdemeId { get; set; }                                     
        public int TurId { get; set; }                                           
        public int? KartId { get; set; }                                        
        public int? TaksitSayisi { get; set; }                                

        public decimal? TaksitTutari { get; set; }                         
        public decimal? DigerVergilerToplami { get; set; }           
        public Tuketici?  Tuketici { get; set; }  
       public required Sube Sube { get; set; }
       public required OdemeSekli  OdemeSekli { get; set; }
       public required OdemeTuru OdemeTuru { get; set; }
       public  Kart? Kart { get; set; } 
       public  ICollection<SatisKalemi> SatisKalemleri { get; set; } = new List<SatisKalemi>();
    }
}
