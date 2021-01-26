using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sent sms");
        }
    }
}
