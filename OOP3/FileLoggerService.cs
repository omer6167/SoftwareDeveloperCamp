using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logging to the file");
        }
    }
}
