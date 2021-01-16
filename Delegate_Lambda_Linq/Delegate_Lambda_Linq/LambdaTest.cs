using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lambda_Linq
{
    public class LambdaTest
    {
        //委托实际是一个类型，继承与System.MulticastDelgate
        public delegate void NoReturnNoPara();
        public delegate void NoReturnWithPara(int id, string name);
        public delegate int WithRetrurnNoPara();

        public void Show()
        {
            {
                //1.0最普通的写法
                NoReturnWithPara mathod = new NoReturnWithPara(this.TestFunction);  //实例化委托
                mathod.Invoke(123, "hzq"); //委托实例的调用
            }

            {
                //2.0方法，匿名方法
                NoReturnWithPara mathod = new NoReturnWithPara(
               delegate (int id, string name)
               {
                   Console.WriteLine($"ID：{id}，Name:{name}");
               }
               );
                mathod.Invoke(123, "hzq");
            }

            {
                //3.0 Lambda表达式
                NoReturnWithPara mathod = new NoReturnWithPara(
               (int id, string name) => //gose to Lambda表达式，左边是参数列表右边是方法体
              {
                  Console.WriteLine($"ID：{id}，Name:{name}");
              }
              );
                mathod.Invoke(123, "hzq");
            }

            {
                //Lambda表达式的语法糖，省略类型
                NoReturnWithPara mathod = new NoReturnWithPara(
                    (id, name) =>
                    { //编译器语法糖
                        Console.WriteLine($"ID:{id},Name:{name}");
                    }
                    );
                mathod.Invoke(333, "cc");
            }
            {
                //Lambda表达式的进一步缩减
                NoReturnWithPara mathod = (id, name) => Console.WriteLine($"ID:{id},Nmae:{name}");
                mathod.Invoke(30789, "hzq");
            }

            //.Net3.0系统自带的委托，Action,Func
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lambda表达式（系统自带委托，无参数无返回值）");
            {
                //1.0
                Action act = new Action(this.TestNoParaFuntion);
                act.Invoke();
            }
            {
                //2.0
                Action act = new Action(
                    delegate ()
                    {
                        this.TestNoParaFuntion();
                    }
                    );
                act.Invoke();
            }
            {

                Action act = new Action(
                    () => this.TestNoParaFuntion()
                    );
                act.Invoke();
            }
            {
                Action act = () => this.TestNoParaFuntion();
                act.Invoke();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lambda表达式（系统自带委托，有参数无返回值）");
            {
                //2.0匿名函数
                Action<int,string> act = new Action<int,string>( //泛型委托
                    delegate (int id,string name) {
                        Console.WriteLine($"ID:{id},Name:{name}");
                    }
                    );
                act.Invoke(6666,"HZQ");
            }
            {
                //3.0写法，lambda表达式
                Action<int, string> act = (id, name) =>  Console.WriteLine($"ID：{id},Nmae:{name}");
                act.Invoke(567,"HZQ");
            }
        }


        private void TestNoParaFuntion()
        {
            Console.WriteLine("这里是Lambda空方法。");
        }

        private void TestFunction(int id, string name)
        {
            Console.WriteLine("ID：{0}，Name:{1}", id, name);
        }
    }
}
