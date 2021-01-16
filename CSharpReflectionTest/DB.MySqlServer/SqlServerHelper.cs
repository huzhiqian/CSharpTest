using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：SqlServerHelper
//命名空间：DB.MySqlServer
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/4 22:37:51
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace DB.MySqlServer
{
  public  class SqlServerHelper:DB.Interface.IDBHelper
    {

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SqlServerHelper()
        {

        }

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="val"></param>
        public SqlServerHelper(int ival)
        {
            Console.WriteLine($"SqlServerHelper的构造函数，参数类型：{ival.GetType().ToString()},参数值：{ival}");
        }
        /// <summary>
        /// 构造
        /// </summary>
        public SqlServerHelper(string sval)
        {
            Console.WriteLine($"SqlServerHelper的构造函数，参数类型：{sval.GetType().ToString()},参数值：{sval}");
        }

        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public bool LinkDB()
        {
            Console.WriteLine("SqlServer:连接数据库！");
            return true;
        }

        public void Query()
        {
            Console.WriteLine("SqlServer:执行查询数据库方法");
        }

       public  static void Staticmethod()
        {
            Console.WriteLine("SqlServer:调用静态方法");
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
