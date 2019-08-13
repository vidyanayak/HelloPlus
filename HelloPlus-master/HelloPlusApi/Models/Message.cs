using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPlusApi.Models
{
    public class Message
    {
        public string messageText;
        public IFormatProvider formatProvider;
        public string[] args;
        
        public string FormattedMessageText
        {
            get
            {
                if (args == null)
                    return messageText;
               else
                    return String.Format(CultureInfo.CurrentCulture, messageText, args);
            }
        }
    }
}
