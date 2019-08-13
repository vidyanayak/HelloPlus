 namespace HelloPlusWeb.Models
{
    using System.Configuration;
    using HelloPlusWeb.LocalResources;

    public class BaseViewModel
    {
        public BaseViewModel()
        {
            this.URL_APP_ROOT = ConfigurationManager.AppSettings["ApiBaseUrl"];
            this.LblWelcome = Language.GetFromResourceFile("lbl_Welcome");
        }

        public string URL_APP_ROOT { get; set; }

        public string LblWelcome { get; set; }
    }
}