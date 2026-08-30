namespace MarketDB.Core.Entities
{
    public class Kategori : BaseEntity
    {
        public required string KategoriAdi { get; set; }
        public int? UstKategoriId { get; set; }

        public Kategori? UstKategori { get; set; }
        public ICollection<Kategori> AltKategoriler { get; set; } = new List<Kategori>();
        public ICollection<Urun> Urunler { get; set; } = new List<Urun>();


    }
}
