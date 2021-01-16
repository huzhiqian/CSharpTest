using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpWithCppDll
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double t = DoLoop(9);
                Console.WriteLine($"C++耗时：{t}");

                double t2 = DoLoopTime(999999999);
                Console.WriteLine($"C++耗时：{t2}");

                double t3 = DoLoopTest(999);
                Console.WriteLine($"C#耗时：{t3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            Console.ReadLine();
        }

        [DllImport("CppDllTest.dll")]
            public static extern double DoLoop(int loopCount);

        [DllImport("CppDllTest.dll")]
        public static extern double DoLoopTime(int loopCount);

       static double  DoLoopTest(int loopCount)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            long values = 0;
    
            for (int i = 0; i < loopCount; i++)
            {
                for (int j = 0; j < loopCount; j++)
                {
                    long tc = 0;
                    for (int k = 0; k < loopCount; k++)
                    {
                        tc++;
                    }
                    values++;
                }
            }
            sw.Stop();
            return (double)sw.ElapsedMilliseconds/ 1000;
        }
    }
}
