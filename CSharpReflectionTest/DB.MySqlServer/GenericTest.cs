using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：GenericTest
//命名空间：DB.MySqlServer
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/9 10:50:12
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace DB.MySqlServer
{
    public class GenericTest<T, W, S>
    {

        #region 构造函数

        public GenericTest()
        {

        }

        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public void Show(T t, W w, S s)
        {
            Console.WriteLine($"t.Type:{t.GetType()},w.Type:{w.GetType()},s.Type:{s.GetType()}");
        }

        public void Show2<A, B, C>(A a, B b, C c)
        {
            Console.WriteLine($"t.Type:{a.GetType()},w.Type:{b.GetType()},s.Type:{c.GetType()}\n 值 a：{a},b:{b},c:{c}");

        }


        public void Test()
        {
            Console.WriteLine("无参数无返回值的重载方法！");
        }

        public void Test(int ival)
        {
            Console.WriteLine($"参数类型：{ival.GetType()},无返回值");
        }

        public void Test(string sval)
        {
            Console.WriteLine($"参数类型：{sval.GetType()},无返回值");
        }

        public void Test(double dval)
        {
            Console.WriteLine($"参数类型：{dval.GetType()},无返回值");
        }


        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
