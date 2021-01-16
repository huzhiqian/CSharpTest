using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace AppConfig_Test2
{
    /// <summary>
    /// 用户自定义配置基类
    /// </summary>
    public class CustomConfigurationBaseSection : ConfigurationSection
    {
        public CustomConfigurationBaseSection()
        {
            this.ConfigFile = "Config.cfg";
            this.ID = 1;
            this.Value = string.Empty;
        }

        public CustomConfigurationBaseSection(string cfgFile, int id, string value)
        {
            this.ConfigFile = cfgFile;
            this.ID = id;
            this.Value = value;
        }

        [ConfigurationProperty("ConfigFile",DefaultValue ="Config.cfg",IsRequired =true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\"/*非法字符*/,MaxLength =50,MinLength =1)]
        public string ConfigFile
        {
            get { return (string)this["ConfigFile"]; }
            set {
                this["ConfigFile"] = value;
            }
        }

        [ConfigurationProperty("ID", DefaultValue = 1, IsRequired = false)]
        [IntegerValidator(MaxValue =999,MinValue =1)]
        public int ID
        {
            get { return (int)this["ID"]; }
            set { this["ID"] = value; }
        }

        [ConfigurationProperty("Value", DefaultValue = "", IsRequired = false)]
        //[StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\"/*非法字符*/, MaxLength = 50, MinLength = 1)]
        public string Value
        {
            get { return (string)this["Value"]; }
            set { this["Value"] = value; }
        }
    }
}
