using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisionAlgorithm;


namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                IVisionAlgorithm algorithm = new VisionAlgorithm.VisionAlgorithm();
                algorithm.LoadAlgorithm();
                algorithm.Run();

                (algorithm as VisionAlgorithm.IConfig).Config();
                (algorithm as VisionAlgorithm.IConfig).Config("123","456");

               string str= (algorithm as VisionAlgorithm.VisionAlgorithm).AlgorithmPath;
                Console.WriteLine(str);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());               
            }
            Console.ReadLine();
                   }
    }
}
