using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类测试
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass myTest;       //定义test的对象
            myTest = new TestClass
            {
                ID = 20
            };//实例化Test的对象

            myTest.GetLocalTime();
            int _value = myTest.GetRandomValue();
            Console.WriteLine("获取的随机数为：{0}", _value);


            Console.ReadLine();
        }

    }
}
