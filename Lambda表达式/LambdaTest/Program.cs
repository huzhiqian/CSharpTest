using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTest
{
    class Program
    {

        
        delegate int Del1(int val);
        delegate int Del2(int val1,int val2);
        delegate void Del3();

        /// <summary>
        /// Lambda表达式是一种可用于创建委托或表达式目录树类型的匿名函数，简单来说Lambda是牛名函数。
        /// 表达式目录树类似于这样(m, n) => m * n + m + n + 2;
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                //
                Del3 myTest1 = () => Test();
                myTest1.Invoke();

                //
                Del3 myTest2 = () => Test2();
                myTest2.Invoke();

                //
                Del3 myTest3 = () => Test3();
                myTest3.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }

       
       public static void  Test()
        {
            Console.WriteLine("------------------------Test--------------------------------");
            Del1 del1 = x => x * x;
            Del1 del2 = (x) => x * x;
            Del1 del3 = (int x) => x*x;
            Del1 del4 = (int x) => { return x * x; };

            Console.WriteLine("Del1 del1 = x => x * x:{0}",del1(2));
            Console.WriteLine("Del1 del2 = (x) => x * x:{0}", del2(2));
            Console.WriteLine("Del1 del3 = (int x) => x*x:{0}", del3(2));
            Console.WriteLine("Del1 del4 = (int x) => return x * x;:{0}", del4(2));
            Console.WriteLine("--------------------------------------------------------");
        }


        public static void Test2()
        {
            Console.WriteLine("------------------------Test2--------------------------------");
            Del2 del2 = (x,y) => x * y;
            Del2 del3 = (int x,int y ) => x * y;
            Del2 del4 = (int x,int y) => { return x * y; };

            Console.WriteLine("Del2 del2 = (x,y) => x * y:{0}", del2(2,3));
            Console.WriteLine("Del2 del3 = (int x,int y ) => x * y:{0}", del3(2,3));
            Console.WriteLine("Del2 del4 = (int x,int y) =>  return x * y; :{0}", del4(2,3));
            Console.WriteLine("--------------------------------------------------------");
        }

        public static void Test3()
        {
            Console.WriteLine("------------------------Test3--------------------------------");
            Func<int> func = () => 2;
            Console.WriteLine("Func<int> func = () => 2:{0}", func());

            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
