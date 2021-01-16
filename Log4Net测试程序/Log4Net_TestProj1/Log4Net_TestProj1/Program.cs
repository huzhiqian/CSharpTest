using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using log4net;

namespace Log4Net_TestProj1
{
    class Program
    {
        static void Main(string[] args)
        {
            string logConfig = ConfigurationManager.AppSettings["log4net"];
            Console.WriteLine(logConfig);
            var fi = new System.IO.FileInfo(logConfig);

            log4net.Config.XmlConfigurator.Configure(fi);

             log4net.ILog Loginfo = log4net.LogManager.GetLogger("loginfo");
          
            Loginfo.Info("Error:123",new Exception("error"));

        Console.ReadLine();
        }
    }
}
