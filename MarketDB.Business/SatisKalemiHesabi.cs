namespace MarketDB.Business
{
    public static class SatisKalemiHesabi
    {
        public static  decimal? TaksitTutariHesapla
            (decimal birimFiyat, decimal miktar, int? taksitSayisi, decimal indirim  )
            {
                if (taksitSayisi is not int seciliTaksitSayisi || seciliTaksitSayisi == 0)
                    {
                        return null;
                    }
            decimal kalemToplami = SatisKalemiHesabi.KalemToplamiHesapla(birimFiyat, miktar, indirim);
            decimal taksitTutari = Math.Round( (kalemToplami / seciliTaksitSayisi), 2, MidpointRounding.AwayFromZero);
            return taksitTutari;
            }
        public static decimal KalemToplamiHesapla(decimal birimFiyat, decimal miktar, decimal indirim )
        {
            decimal kalemToplami = Math.Round((birimFiyat * miktar) - indirim, 2, MidpointRounding.AwayFromZero); 
            return kalemToplami;
        }

       
    }
}
