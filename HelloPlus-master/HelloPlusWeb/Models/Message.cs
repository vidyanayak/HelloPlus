namespace HelloPlusWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Message
    {
        private string messageText;
        private IFormatProvider formatProvider;
        private string[] args;

        public string FormattedMessageText
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture, this.messageText, this.args);
            }
        }
    }
}
