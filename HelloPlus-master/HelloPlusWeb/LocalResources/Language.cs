namespace HelloPlusWeb.LocalResources
{
    using System.Configuration;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public static class Language
    {
        public static string GetFromResourceFile(string key, string culture = null)
        {
            string value = string.Empty;
            if (culture == null)
            {
                culture = ConfigurationManager.AppSettings["CurrentlanguageCulture"];
            }
            CultureInfo ci;
            ci = new CultureInfo(culture);

            if (culture.Trim().ToUpper() == "EN-US")
            {
                value = en_US.ResourceManager.GetString(key, ci);
            }
            else if (culture.Trim().ToUpper() == "FR-CA")
            {
                value = fr_CA.ResourceManager.GetString(key, ci);
            }
            else
            {
                value = en_US.ResourceManager.GetString(key, ci);
            }
            return value;
        }
    }
}