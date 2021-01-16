using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceTestDLL;


namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass mainClass = new MainClass();

            Console.WriteLine($"{mainClass.TestObj.dValue}");
            Console.WriteLine($"{mainClass.TestObj.iValue}");
            Console.ReadLine();
        }
    }
}
