namespace MarketDB.Core.Entities
{
   public class OdemeDetay:BaseEntity
    {
        public  int SatisId {  get; set; }
        public  int? KartId {  get; set; }
        public  decimal NakitTutar {  get; set; }
        public  decimal KartTutar {  get; set; }
        public Kart? Kart { get; set; }
        public Satis? Satis { get; set; }
       
    }
}
