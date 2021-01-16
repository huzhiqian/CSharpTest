using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lambda_Linq
{
    internal class Student
    {


        /// <summary>
        /// 构造函数
        /// </summary>
       public Student()
        {

        }

        public int ID { get; set; }
        public string name { get; set; }


        public void SayMorning(string name)
        {
            Console.WriteLine($"早上好,{name}");
            Console.WriteLine("123");
        }


        /// <summary>
        /// SayMorning方法，适应不同的人和不同的打招呼的方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="peopleType"></param>
        public void SayMorning(string name,PeopleType peopleType )
        {
            switch (peopleType)
            {
                case PeopleType.Chiness:
                    {
                        Console.WriteLine($"早上好,{name}");
                    }
                    break;
                case PeopleType.America:
                    {
                        Console.WriteLine($"Good Morning,{name}");
                    }
                    break;
                default:
                    throw new Exception("类型出错！");
            }
        }

        public enum PeopleType
        {
            Chiness=0,
            America=1,
        }

        public void SayMorningPrefect(string name, SayMorningCallBack mathod )
        {
            Console.WriteLine("写日志");
            mathod.Invoke(name);
            Console.WriteLine("后续操作");
        }


        public void SayMorning_Chiness(string name )
        {
            Console.WriteLine($"早上好，{name}");
        }

        public void SayMorning_America(string name)
        {
            Console.WriteLine($"Good Morning，{name}");
        }
    }
    public delegate void SayMorningCallBack(string name);
}
