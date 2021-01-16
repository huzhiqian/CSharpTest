using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace AppConfig_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            try
            {
                var sec = config.GetSection("ParamSection") as CustomConfigurationBaseSection;
                //config.Sections.Remove("ParamSection");
                //config.Sections.Add("ParamSection", new CustomConfigurationBaseSection());
                //config.Save();
                //ConfigurationManager.RefreshSection("ParamSection");
                //sec = ConfigurationManager.GetSection("ParamSection") as CustomConfigurationBaseSection;

                Console.WriteLine($"File:{sec.ConfigFile},ID:{sec.ID},Value:{sec.Value}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();

        }
    }
}
