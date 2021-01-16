using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisionAlgorithm
{
    public class VisionAlgorithm : IVisionAlgorithm,IConfig 
    {


        public string AlgorithmPath {
            get { return @"Algorithm Path:{C:\Algo.vpp}"; }
        }
        public void Config()
        {
            Console.WriteLine("Config Algorithm");
        }

        public void Config(string name, string value)
        {
            Console.WriteLine($"Config Algorithm Name:{name},Value:{value}");
        }

        public void LoadAlgorithm()
        {
            Console.WriteLine("Load Algorithm");
        }

        public void Run()
        {
            Console.WriteLine("Run Algorithm");
        }
    }
}
