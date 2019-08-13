using HelloPlusApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPlusApi
{
    public interface INotifier :IDisposable
    {
        string Notify(Message message);

        // void Write(Func<string> messageFactory);
        // void WriteFormatted(String format, params Object[] args);
        // string GetMessage();
    }
}
