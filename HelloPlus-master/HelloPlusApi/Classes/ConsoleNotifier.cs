using HelloPlusApi.Models;
using HelloPlusApi.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloPlusApi
{
    public class ConsoleNotifier : INotifier
    {
        public string Notify(Message message)
        { 
            //Do the formatting here?
            Console.WriteLine(message.messageText);
            return message.messageText;
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}