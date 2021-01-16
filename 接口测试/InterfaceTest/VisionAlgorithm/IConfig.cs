using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisionAlgorithm
{
   public interface IConfig
    {


        void Config();

        void Config(string name,string value);
    }
}
