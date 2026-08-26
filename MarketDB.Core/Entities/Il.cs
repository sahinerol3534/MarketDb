namespace MarketDB.Core.Entities
{
    public class Il : BaseEntity
    {
        public required string IlAdi { get; set; }
        public int IlKodu {  get; set; }
        public  ICollection<Ilce> Ilceler { get; set; } = new List<Ilce>();
    
    }
}

