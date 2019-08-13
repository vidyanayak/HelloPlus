namespace HelloPlusWeb.Controllers
{
    using System;
    using System.Configuration;
    using System.Web.Mvc;
    using HelloPlusWeb.Models;
    using Newtonsoft.Json;

    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ActionResult Index()
        {
            return this.LoadPage("Index");
        }

        
        private ActionResult LoadPage(string viewName)
        {
            BaseViewModel bvm = new BaseViewModel();
            this.ViewBag.URL_API_ROOT = ConfigurationManager.AppSettings["ApiBaseUrl"];
            this.ViewBag.CURRENT_LANGUAGE = ConfigurationManager.AppSettings["CurrentlanguageCulture"];
            return this.View(viewName, bvm);
        }

        [HandleError]
        public ActionResult ThrowException()
        {
            return this.View("NotFound");
        }
    }
}