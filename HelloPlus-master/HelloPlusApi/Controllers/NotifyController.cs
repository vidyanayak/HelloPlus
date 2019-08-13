using System.Web.Http;
using HelloPlusApi;
using HelloPlusApi.Models;
using HelloPlusApi.Resources;
using System.Configuration;
using HelloPlusApi.Repositories;
using System;
using System.Web.Http.Cors;


namespace HelloPlusApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/notification")]
    public class NotifyController : ApiController
    {

  

        [Route("post")]
        [HttpPost]
        public string NotifyMessage(string language = null)//Message message)
        {
            INotifier notifier = new ConsoleNotifier();
            string notifierType = "none";
            try
            {
                notifierType = ConfigurationManager.AppSettings["NotifierType"];

            }
            catch (Exception) { }

            Message message = GetNotificationMessage();// Language.GetFromResourceFile("BaseHelloMessage");// "Hello World";


            if (notifierType.ToUpper().Trim() == "CONSOLE")
            {
                notifier = new ConsoleNotifier();
            }
            else if (notifierType.ToUpper().Trim() == "FILE")
            {
                notifier = new FileNotifier();
            }
           else  if (notifierType.ToUpper().Trim() == "DB")
            {
                notifier = new DBNotifier();
            }
            else
            {
                notifier = new Notifier();
            }
            return NotifyMessage(message, notifier);
        }



        private string NotifyMessage(Message message, INotifier notifier)
        {
            NotifyRepository repo = new NotifyRepository(notifier);
           return repo.Notify(message);

        }

        [Route("postdefault")]
        [HttpPost]
        public string Notify(IConfigurationManager configurationManager)
        {
            if (configurationManager == null) { throw new ArgumentNullException("configurationManager"); }

            INotifier notifier = new ConsoleNotifier();
            string notifierType = "none";
            try
            {
                notifierType = configurationManager.GetAppSetting("NotifierType");
                // notifierType =  ConfigurationManager.AppSettings["NotifierType"];

            }
            catch (Exception) { }

            Message message = new Message();
            message.messageText = Language.GetFromResourceFile("BaseHelloMessage");// "Hello World";


            if (notifierType.ToUpper().Trim() == "CONSOLE")
            {
                notifier = new ConsoleNotifier();
            }
            else if (notifierType.ToUpper().Trim() == "FILE")
            {
                notifier = new FileNotifier();
            }
            else if (notifierType.ToUpper().Trim() == "DB")
            {
                notifier = new DBNotifier();
            }
            else
            {
                notifier = new Notifier();
            }
            return NotifyMessage(message, notifier);
        }

        [Route("Get")]
        [HttpGet]
        public string GetMessage()
        {
            Message m = GetNotificationMessage();
            return m.messageText;
        }

        [Route("GetByLanguage")]
        [HttpGet]
        public string GetMessageByLanguage(string language)
        {
            Message m = GetNotificationMessage(language);
            return m.messageText;
        }

        private Message GetNotificationMessage(string language = null)
        {
            var notifier = new NotifyRepository();

            Message returnMsg = new Message();

            returnMsg.messageText = Language.GetFromResourceFile("BaseHelloMessage", language);// "Hello World";

            notifier.Notify(returnMsg);
            return returnMsg;
        }
    }
}
