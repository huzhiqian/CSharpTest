using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：Singleton
//命名空间：DB.MySqlServer
//CLR版本：4.0.30319.42000
//内容：
//功能：单列类
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/9 10:21:39
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace DB.MySqlServer
{
  public sealed  class Singleton
    {
        private static Singleton _sinbgleton =null;

                    #region 构造函数

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private Singleton()
        {
            Console.WriteLine("构造私有构造函数");
        }

        static Singleton()
        {
            _sinbgleton = new Singleton();
        }


        public static Singleton GetSingleton()
        {
            return _sinbgleton;
        }
        #endregion


        #region 属性



        #endregion

        #region 公共方法



        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
