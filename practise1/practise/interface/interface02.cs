using System;
using System.Collections.Generic;
using System.Text;

namespace practise1
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
        
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1} ", DateTime.Now.ToLongTimeString(), message);
        }
        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1} ", DateTime.Now.ToLongTimeString(), message);
        }

        
    }
    class Interface02
    {
        static void Main(string[] argv)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The World is not flat.");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }

    }
    
}
