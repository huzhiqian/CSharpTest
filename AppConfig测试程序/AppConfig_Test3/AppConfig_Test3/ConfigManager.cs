using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace AppConfig_Test3
{
    public static class ConfigManager
    {
        static Configuration _appConfig;
        static bool _error = false;
        static ConfigManager()
        {
            //string appConfigPath = string.Format("{0}{1}",
            //    System.AppDomain.CurrentDomain.RelativeSearchPath??
            //    System.AppDomain.CurrentDomain.BaseDirectory,"App.config");
            /*如果需要将制定客户端（.exe文件）的配置文件作为当前配置文件，则将上面注释代码取消注释*/
            //Console.WriteLine(appConfigPath);
            try
            {
                _appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            }
            catch (ConfigurationErrorsException ex)
            {
                _error = true;
                throw ex;
            }
        }

        public static KeyValueConfigurationCollection AppSettings
        {
            get {
                if (_appConfig != null && !_error)
                    return _appConfig.AppSettings.Settings;
                else
                    return null;
            }
        }

        public static ConnectionStringSettingsCollection ConnectionStrings
        {
            get {
                if (_appConfig != null && !_error)
                    return _appConfig.ConnectionStrings.ConnectionStrings;
                else
                    return null;
            }

        }

        public static T GetSection<T>(string name) where T : ConfigurationSection
        {
            if (_appConfig == null || _error) return null;
            return _appConfig.GetSection(name) as T;
        }
    }
}
