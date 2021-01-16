using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Diagnostics;

namespace 泛型性能测试
{

    /***********************************************
    文件名：Monitor
    命名空间：泛型性能测试
    CLR版本：4.0.30319.42000
    内容：泛型性能测试
    功能：
    文件关系：
    作者：胡志乾
    小组：
    生成日期：2018/3/13 19:59:52
    版本号：V1.0.0.0
    修改日志：
    版权说明：
    联系电话：18352567214
    **********************************************/

    class Monitor
    {


	#region 构造函数

	///<summary>
        /// 默认构造函数 
        ///</summary>	
	public Monitor()
	{

	}

        #endregion


        #region 属性



        #endregion


        #region 公共方法

        public void Show()
        {
            Stopwatch c_sw = new Stopwatch();
            Stopwatch o_sw = new Stopwatch();
            Stopwatch g_sw = new Stopwatch();

            //普通方法
            {
                
                c_sw.Restart();
                for (int i = 0; i < 99999999; i++)
                {
                    CommonFunc(i);
                }
                c_sw.Stop();
            }

            //Object方法
            {
                
                o_sw.Restart();
                for (int i = 0; i < 99999999; i++)
                {
                    ObjectFunc(i);
                }
                o_sw.Stop();
            }
            //泛型方法
            {
                
                g_sw.Restart();
                for (int i = 0; i < 99999999; i++)
                {
                    GenericFunc(i);
                }
                g_sw.Stop();
            }

            Console.WriteLine($"普通方法：{c_sw.ElapsedMilliseconds},Object方法：{o_sw.ElapsedMilliseconds}," +
                $"泛型方法;{g_sw.ElapsedMilliseconds}");
        }

        #endregion


        #region 私有方法

        private void CommonFunc(int val)
        {

        }

        private void ObjectFunc(object obj)
        {

        }
        private void GenericFunc<T>(T val)
        {

        }
	#endregion


	#region 事件



	#endregion


	#region 委托



	#endregion
    }
}
