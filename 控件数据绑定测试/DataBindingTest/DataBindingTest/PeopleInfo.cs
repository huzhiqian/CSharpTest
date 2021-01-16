using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：PeopleInfo
//命名空间：DataBindingTest
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/17 17:35:51
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace DataBindingTest
{
   public class PeopleInfo:IPeopleInfo
    {

        #region 构造函数

        public PeopleInfo()
        {

        }


        #endregion


        #region 属性

        public string Name { get; set; }

        public double Age { get; set; }

        public SexConstant Sex { get; set; }

        public string Address { get; set; }


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
