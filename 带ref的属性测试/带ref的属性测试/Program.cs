using System;

namespace 带ref的属性测试
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            Class1 val = new Class1()
            {
                TestProperty_1 = "aaa",
                TestProperty_2 = "bbbb"

            };
            CTest mytest = new CTest(ref val);
           
             mytest.GetValue(ref a);

            Console.WriteLine(a);
            Console.WriteLine(val.TestProperty_1);
            a = "456";

            Console.WriteLine(mytest.property);
            Console.ReadLine();
        }
    }
}
