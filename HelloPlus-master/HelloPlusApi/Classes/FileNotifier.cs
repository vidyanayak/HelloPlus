using HelloPlusApi.Models;
using HelloPlusApi.Resources;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace HelloPlusApi
{
    public class FileNotifier : INotifier
    {
        private StreamWriter sw;

        public FileNotifier()
        {

        }

        public string Notify(Message message)
        {
           string filePath = ConfigurationManager.AppSettings["FilePath"];
           sw = new StreamWriter(filePath, true);
           sw.AutoFlush = true;

            if (sw != null)
            {
                sw.WriteLine(message.messageText);
            }
            return message.messageText;
        }

        public void Dispose()
            {
            if (sw != null)
            {
                sw.Close();
                sw.Dispose();
                sw = null;
            }
            this.Dispose();
        }
    }
}