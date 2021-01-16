using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：CTest
//命名空间：InterfaceTestDLL
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2019/1/9 13:02:29
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace InterfaceTestDLL
{
    internal class CTest : ITest
    {
        private int intVal = 1;
        private double doubleVal = 1.0;

        private string strVal = "Test";
        #region 构造函数

        public CTest(int ival,double dval)
        {
            intVal = ival;
            doubleVal = dval;
        }



        #endregion


        #region 属性

        int ITest.iValue
        {
            get { return intVal; }
            set
            {
                intVal = value;
            }
        }
        double ITest.dValue
        {
            get { return doubleVal; }
            set { doubleVal = value; }
        }

        public string StringVal
        {
            get { return strVal; }
            set
            {
                strVal = value;
            }
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
