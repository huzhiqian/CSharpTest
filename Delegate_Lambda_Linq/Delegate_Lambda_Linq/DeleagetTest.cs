using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lambda_Linq
{

    
    public class DeleagetTest
    {
        //委托实际是一个类型，继承与System.MulticastDelgate
        public delegate void NoReturnNoPara();
        public delegate void NoReturnWithPara(int id,string name);
        public delegate int WithRetrurnNoPara();


        public void Show()
        {

            {
                //常规做法
                Student student = new Student()
                {
                    ID = 123,
                    name = "hzq"
                };
                student.SayMorning("kc");
            }

            {
                //增加不同的人不同的打招呼的方式,才分成不同的方法，不同的对象执行不同的方法
                Student student = new Student()
                {
                    ID = 123,
                    name = "hzq"
                };
                student.SayMorning("fq", Student.PeopleType.Chiness);

                student.SayMorning("cc",Student.PeopleType.America);
            }

            {
                Student student = new Student()
                {
                    ID = 123,
                    name = "hzq"
                };
                SayMorningCallBack mathod = new SayMorningCallBack(student.SayMorning_Chiness);
                mathod.Invoke("hzq");

                SayMorningCallBack mathod2 = new SayMorningCallBack(student.SayMorning_America);
                mathod2.Invoke("cc");
            }
         
        }


        private void TestFun()
        {

        }

    }
}
