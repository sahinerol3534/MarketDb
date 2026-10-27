using System.ComponentModel.DataAnnotations.Schema;

namespace MarketDB.Core.Entities
{
    public class Kart : BaseEntity
    {
        public required string KartAdi { get; set; }
        public int BankaId { get; set; }
        public Banka? Banka { get; set; }
        // public  ICollection<Satis> Satislar { get; set; }=new List<Satis>();

        [NotMapped]

        public string BankaKartlari
        {
            get
            {

                if (Banka == null)
                {
                    return ("Banka Bilgisi Yok!");
                }

                string[] kartDizin = { KartAdi, Banka.BankaAdi };
                List<string> kartlarBankalar = kartDizin.Where(b => !string.IsNullOrEmpty(b)).ToList();
                string kartVeBanka = string.Join("/", kartlarBankalar);
                return kartVeBanka;
            }
        }
    }

}
