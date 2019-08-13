using HelloPlusApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloPlusApi
{
    public class Notifier :INotifier
    {
        public Notifier()
        {

        }

        public string Notify(Message message)
        {
            string retMsg = message.messageText;
            if (message.args != null)
            {
              
                retMsg = message.FormattedMessageText;
            }
            return retMsg;
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }

}