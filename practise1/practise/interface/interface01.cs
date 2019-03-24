// interface practise.
using System;
using System.IO;

namespace practise1
{
    interface ILogger
    {
        void WriteLog(string log);
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요.: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;
                logger.WriteLog("현재 온도 :  " + temperature);
            }
        }
    }
    class FileLogger : ILogger
    {
        //need ->  using System.IO;
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }
    class Interface01
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("Hello, World!");
            //output to console
            //ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            
            //output to file
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();
            

        }
        
    }
    


}
