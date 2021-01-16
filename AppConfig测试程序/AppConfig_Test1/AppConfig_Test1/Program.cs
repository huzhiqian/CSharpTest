using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace AppConfig_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                Console.WriteLine($"{config.AppSettings.Settings.Count}");
                //读取appSettings中的所有项
                foreach (string item in config.AppSettings.Settings.AllKeys)
                {
                    Console.WriteLine($"key:{item},value:{config.AppSettings.Settings[item].Value}");
                }

                Console.WriteLine("************************************************************");
                //读取connectionStrings
                Console.WriteLine($"Name:connection1,connectionString:{config.ConnectionStrings.ConnectionStrings["connection1"]}");
                Console.WriteLine($"Name:connection2,connectionString:{config.ConnectionStrings.ConnectionStrings["connection2"]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());              
            }
            Console.ReadLine();
        }
    }
}
