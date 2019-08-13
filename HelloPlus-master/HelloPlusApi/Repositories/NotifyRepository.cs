using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloPlusApi.Models;
using HelloPlusApi.Resources;

namespace HelloPlusApi.Repositories
{
    public class NotifyRepository 
    {

        private INotifier notifier;

        //default to console notifier
        public NotifyRepository()
        {
            this.notifier = new ConsoleNotifier(); 
        }

        //inject db or file notifier for other variations
        public NotifyRepository(INotifier notifier)
        {
            this.notifier = notifier; 
        }

        public string Notify(Message message)
        {
            this.notifier.Notify(message);
            return message.messageText;
        }
        
    }
}