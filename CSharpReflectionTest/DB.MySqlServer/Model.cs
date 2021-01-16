using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：Model
//命名空间：DB.MySqlServer
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/10 17:38:40
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace DB.MySqlServer
{
   public class Model
    {

        //字段
        public int iTestValue = 1;
        public string sTestValue = "Test";
        public double dTestValue = 2.0;


        #region 构造函数

        public Model()
        {

        }

        #endregion


        #region 属性

        public int ID { get; set; } = 1;

        public string Name { get; set; } = "huzhiqian";

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
