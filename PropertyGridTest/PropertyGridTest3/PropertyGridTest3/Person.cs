using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.ComponentModel;


//**********************************************
//文件名：Person
//命名空间：PropertyGridTest3
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/4 16:09:58
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest3
{
   public  class Person
    {
        private string m_name = "";//姓名
        private int m_age = 0;    //年龄
        private Sex m_sex = Sex.MALE;//性别
        private double m_stature = 1.6;//升高 
        #region 构造函数

        public Person()
        {

        }

        #endregion


        #region 属性
        [Browsable(true)]
        [DefaultValue("")]
        [Category("基本信息"),Description("姓名"),ReadOnly(false)]
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        [Browsable(true)]
        [DefaultValue(10)]
        [Category("基本信息"), Description("年龄"), ReadOnly(false)]
        public int Age
        { get { return m_age; }
            set { m_age = value; }
        }

        [Browsable(true)]
        [DefaultValue(10)]
        [Category("基本信息"), Description("性别"), ReadOnly(false)]
        public Sex Sex
        {
            get { return m_sex; }
            set { m_sex = value; }
        }

        [Browsable(true)]
        [DefaultValue(10)]
        [Category("基本信息"), Description("身高"), ReadOnly(false)]
        public double Stature
        {
            get { return m_stature; }
            set { m_stature = value; }
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

    public enum Sex
    {
        MALE=0,
        FEMALE=1
    }
}
