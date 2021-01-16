using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace 带ref的属性测试
{

    /***********************************************
    文件名：CTest
    命名空间：带ref的属性测试
    CLR版本：4.0.30319.42000
    内容：
    功能：
    文件关系：
    作者：胡志乾
    小组：
    生成日期：2018/3/15 22:18:39
    版本号：V1.0.0.0
    修改日志：
    版权说明：
    联系电话：18352567214
    **********************************************/

    class CTest
    {
        private string property1="123";
        private Class1 testval;

	#region 构造函数

	///<summary>
        /// 默认构造函数 
        ///</summary>	
	public CTest(ref Class1 val)
	{
            testval = val;

            testval.TestProperty_1 = "cccc";
            testval.TestProperty_2 = "ddddd";
    }

	#endregion


	#region 属性

        public ref string property
        {
            get { return ref property1; }
        }


        internal void GetValue(ref string val)
        {
            val = property1; 
        }
	#endregion


	#region 公共方法



	#endregion


	#region 私有方法



	#endregion


	#region 事件



	#endregion


	#region 委托



	#endregion
    }
}
