using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类测试
{
    class TestClass
    {

        public TestClass() {
            Console.WriteLine("执行构造函数！");
            DoSomething += TestClass_DoSomething;
        }

        private void TestClass_DoSomething()
        {
            Console.WriteLine("产生的随机数为偶数！");
        }

        #region 属性

        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID { get; set; }


        #endregion

        #region 方法

        /// <summary>
        /// 获取本地计算机的时间
        /// </summary>
        public void GetLocalTime()
        {
            Console.WriteLine("当前时间是：{0}",DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss.fff"));

        }

        /// <summary>
        /// 获取随机数
        /// </summary>
        /// <returns></returns>
        public int GetRandomValue()
        {
            int val = 0;

            Random myRan = new Random();
            val = myRan.Next();
            if (val % 2 == 0)
                DoSomething();  //触发事件
            return val;
        }
        #endregion

        #region 事件和委托

        //声明委托

        public delegate void DoSomethingEventHandler();

        public event DoSomethingEventHandler DoSomething;

        #endregion 

    }
}
