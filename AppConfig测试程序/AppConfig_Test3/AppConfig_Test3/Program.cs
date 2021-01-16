using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace AppConfig_Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              Console.WriteLine($"{ConfigManager.AppSettings["TestVal"].Value}");
                Console.WriteLine($"{ConfigManager.ConnectionStrings["sqlString"].ConnectionString}");
              var sec=  ConfigManager.GetSection<CustomConfigurationBaseSection>("Params");

                Console.WriteLine($"{sec.ConfigFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                            }
            Console.ReadLine();
        }
    }
}
