using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using DB.Interface;

//**********************************************
//文件名：SqlHelper
//命名空间：DB.Mysql
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/5 21:59:07
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace DB.Mysql
{
    class SqlHelper:DB.Interface.IDBHelper
    {

        #region 构造函数

        public SqlHelper()
        {

        }

        public bool LinkDB()
        {
            Console.WriteLine("Sql:连接数据库");
            return true;
        }

        public void Query()
        {
            Console.WriteLine("Sql:执行查询方法");
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
