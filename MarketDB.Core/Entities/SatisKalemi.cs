using System.ComponentModel.DataAnnotations.Schema;

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
        public int? TaksitSayisi{ get; set; } 
        public decimal? TaksitTutari{ get; set; }
        public int? OdemeSekliId { get; set; }
        public OdemeSekli? OdemeSekli { get; set; }
        public  Satis? Satis {  get; set; }
        public  Urun? Urun {  get; set; }

        [NotMapped]
        public string UrunAdi
        {
            get
            {
                if (Urun== null)
                {
                    return ("Ürün Bilgisi Yok!");
                }
                return Urun.UrunAdi;
            }
        }

        [NotMapped]
        public string OdemeAdi
        {
            get
            {
                if (OdemeSekli== null) { return ("Ödeme Adı Bilgisi Yok!"); }
                return OdemeSekli.OdemeAdi;
            }
        }
    }
}




