namespace MarketDB.Core.Entities
{
    public class SatisKalemi: BaseEntity
    {
        public int SatisId { get; set; } 
        public int UrunId{ get; set; } 
        public decimal Miktar{ get; set; } 
        public decimal BirimFiyat{ get; set; } 
        public decimal KalemToplami{ get; set; } 
        public decimal? IndirimTutari{ get; set; } 
        public decimal? KdvTutari{ get; set; } 
        public decimal? DigerVergiTutari{ get; set; } 
        public decimal? NetTutar{ get; set; } 
        public required Satis Satis {  get; set; }
        public required Urun Urun {  get; set; }
        
      
      

    }
}
