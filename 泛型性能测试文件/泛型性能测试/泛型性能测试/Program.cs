using System;

namespace 泛型性能测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor monitor = new Monitor();
            for (int i = 0; i < 20; i++)
                monitor.Show();

            Console.ReadLine();
        }
    }
}
