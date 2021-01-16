using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;



namespace Log4Net_TestProj4
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog loggerErr = log4net.LogManager.GetLogger("Logger_Error");

            loggerErr.Error("12333");

            Console.ReadLine();
        }
    }
}
