using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lambda_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***********委托、Lambda以及Linq练习*****************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            try
            {
                //委托测试
                Console.WriteLine("***********委托测试****************");
                DeleagetTest deleagetTest = new DeleagetTest();
                deleagetTest.Show();


                //Labmda表达式测试
                Console.WriteLine("***********Lambda表达式测试****************");
                LambdaTest myLambdaTets = new LambdaTest();
                myLambdaTets.Show();


                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}
