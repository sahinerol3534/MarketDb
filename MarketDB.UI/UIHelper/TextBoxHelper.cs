namespace MarketDB.UI.UIHelper
{
    public static  class TextBoxHelper
    {
        public static string TelNoFormatKontrol(string telNo)
        {
            string telNoSqlFormat = telNo.Trim();
            string telNoSqlFormatZ = telNo.Replace(" ", "");
            if (telNoSqlFormatZ.StartsWith( "0")) 
            {
               telNoSqlFormat= telNoSqlFormatZ.Substring(1);    
             }
            else
            {
               telNoSqlFormat = telNoSqlFormatZ;
            }
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
        public  static bool EmailFormatKontrol(string email)
        {
            bool emailDoluMu = !string.IsNullOrWhiteSpace(email);
            int kacinciKarakter = email.IndexOf('@');
            if (emailDoluMu && (kacinciKarakter == 0 || kacinciKarakter == -1))
            {
                return false;
            }
            return true;
        }

    }
}


