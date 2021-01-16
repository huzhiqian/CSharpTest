using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;


//**********************************************
//文件名：PointConverter
//命名空间：PropertyGridTest2
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/4 14:30:10
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest2
{
    //转换器类
   public class PointConverter:TypeConverter
    {

        #region 构造函数

        public PointConverter()
        {

        }

        #endregion


        #region 属性



        #endregion

        #region 公共方法


        /// <summary>
        /// 判断可以从哪些类型转换而来
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// 判断可以转换成哪些类型
        /// </summary>
        /// <param name="context"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            //判断是否可以从string类型转换而来
            if (destinationType == typeof(string))
                return true;
            if (destinationType == typeof(InstanceDescriptor))//InstanceDescriptor提供创建对象信息的类型
                return true;
            return base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// 将类型转换成字符串
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value != null)
            {
                CPoint point = value as CPoint;
                string str = string.Format($"{point.X},{point.Y}");
                return str;
            }

            if (destinationType == typeof(InstanceDescriptor) && value != null)
            {
                ConstructorInfo constructorInfo = typeof(CPoint).GetConstructor(new Type[] { typeof(int), typeof(int) });
                CPoint point = value as CPoint;
                return new InstanceDescriptor(constructorInfo, new object[] { point.X, point.Y });
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }


        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                string str = value as string;
                string[] p = str.Split(',');
                if (p.Length != 2)
                {
                    throw new NotSupportedException("非法参数类型");
                }

                int X = 0;
                int Y = 0;

                bool result = int.TryParse(p[0], out X);
                if (!result)
                    throw new NotSupportedException("输入参数出错");
                //
                result = int.TryParse(p[1], out Y);
                if (!result)
                    throw new NotSupportedException("输入参数出错");

                CPoint point = new CPoint(X, Y);


                return point;
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
            //return base.GetPropertiesSupported(context);
        }
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(value, attributes);
            //return base.GetProperties(context, value, attributes);
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
