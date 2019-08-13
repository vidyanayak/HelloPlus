using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Web;

namespace HelloPlusApi.Resources
{
    public class Language
    {
        public static string GetFromResourceFile(string key, string culture=null)
        {
            string value = string.Empty;
            if (culture == null)
                culture = ConfigurationManager.AppSettings["CurrentlanguageCulture"];

            if (culture == null)
                culture = "EN-US";
                CultureInfo ci;
            ci = new CultureInfo(culture);

            if (culture.Trim().ToUpper() == "EN-US")
            {
                value = en_us.ResourceManager.GetString(key, ci);
            }
            else if (culture.Trim().ToUpper() == "FR-CA")
            {
                value = fr_CA.ResourceManager.GetString(key, ci);
            }
            else
            {
                value = en_us.ResourceManager.GetString(key, ci);
            }
            return value;
        }
    }
}