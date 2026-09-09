namespace MarketDB.UI.UIHelper
{
    public static  class TextBoxHelper
    {
        public static string TelNoFormatKontrol(string telNo)
        {
            string telNoSqlFormat = telNo.Replace(" ", "");
            string telNoKarakterSayisi = telNoSqlFormat.Length > 10
                ? telNoSqlFormat.Substring(0, 10)
                : telNoSqlFormat;
            string formatliTelNo = "";
            for (int i = 0; i < telNoKarakterSayisi.Length; i++)
            {
                if (i==3 || i == 6)
                {
                    formatliTelNo += " ";
                }
                formatliTelNo += telNoKarakterSayisi[i];
              }
            return formatliTelNo;

        }
    }
}
