using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternTest
{
    class Program
    {
        /// <summary>
        /// 1:用一个抽象类（state）描述状态
        /// 2:Context是状态对象管理器，与State是聚合关系
        /// 3:ConcreteStateA与ConcreteStateB是具体状态类，这两个类都继承了State抽象类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                State.Context context = new State.Context(new State.ConcreteStateA());
                context.Request();
                context.Request();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
