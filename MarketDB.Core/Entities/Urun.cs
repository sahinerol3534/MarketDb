namespace MarketDB.Core.Entities
{
    public class Urun: BaseEntity
    {
        public required string UrunAdi { get; set; }
        public  string? UrunMarkasi { get; set; }
        public required string UrunCinsi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int KategoriId { get; set; }
        public  required Kategori  Kategori{  get; set; } 
        public ICollection<SatisKalemi> SatisKalemleri { get; set; } = new List<SatisKalemi>();
       
  
  
   }
}

