namespace MarketDB.Business
{
   public  class OdemeTuruHesabi
    {
        public decimal OdemeTuruneGoreTutarHesapla(decimal kalemlerToplami, decimal nakitTutar)
        {
            decimal kartOdemesi = kalemlerToplami-nakitTutar;
            return kartOdemesi;
        }
    }
}
