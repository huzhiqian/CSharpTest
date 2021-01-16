using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Configuration;
using DB.Interface;
using System.Reflection;


//**********************************************
//文件名：SimpleFactory
//命名空间：CSharpReflectionTest
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/5 21:33:51
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace CSharpReflectionTest
{
    /// <summary>
    /// Sql数据库的简单工厂类
    /// </summary>
   public  class SimpleFactory
    {
        private static string IDBHelperConfig = ConfigurationManager.AppSettings["IDBHelper"];
        private static string DllName = IDBHelperConfig.Split(',')[0];
        private static string DllType = IDBHelperConfig.Split(',')[1];

        #region 构造函数

        public SimpleFactory()
        {

        }

        #endregion


        #region 属性

        /// <summary>
        /// 创建对象
        /// </summary>
        /// <returns></returns>
        public IDBHelper CreatcInstance()
        {
            Assembly assembly = Assembly.Load(DllName);
            Type type = assembly.GetType(DllType);
            object oIDBHelper = Activator.CreateInstance(type);
            IDBHelper dBHelper = oIDBHelper as IDBHelper;
            return dBHelper;

        }

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
