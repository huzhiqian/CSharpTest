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
//文件名：HobbiesConverter
//命名空间：PropertyGridTest3
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/4 17:37:01
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest3
{
   public class HobbiesConverter:TypeConverter
    {

        #region 构造函数

        public HobbiesConverter()
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
            //判断是否可以从string类型转换而来
            if (sourceType == typeof(string))
            {
                return true;
            }
            //也可以由其他类型转换而来
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
           
            if (destinationType == typeof(Hobbies))
                return true;
            if (destinationType == typeof(InstanceDescriptor))//InstanceDescriptor提供创建对象信息的类型
                return true;
            return base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// 使用指定的上下文和区域性信息将给定值对象转换为指定的类型。
        /// </summary>
        /// <param name="context">一个 System.ComponentModel.ITypeDescriptorContext，用于提供格式上下文。</param>
        /// <param name="culture">System.Globalization.CultureInfo。 如果传递 null，则采用当前区域性。</param>
        /// <param name="value">要转换的 System.Object。</param>
        /// <param name="destinationType">System.Type 转换 value 参数</param>
        /// <returns>一个 System.Object，它表示转换后的值。</returns>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            StringBuilder sb = new StringBuilder();
            if (value == null) return "";
            if (destinationType == typeof(string) )
            {
                Hobbies hobbies = value as Hobbies;
                if (hobbies.Music)
                    sb.Append("Music,");
                if (hobbies.Game)
                    sb.Append("Game,");
                if (hobbies.Running)
                    sb.Append("Running,");
                if (hobbies.Film)
                    sb.Append("Film,");
                if (hobbies.Basketball)
                    sb.Append("Basketball,");

                if (sb.Length > 0)
                    return sb.ToString().Substring(0,sb.ToString().Length-1);
                else
                return "";
            }

            if (destinationType == typeof(InstanceDescriptor) && value != null)
            {
                ConstructorInfo constructorInfo = typeof(Hobbies).GetConstructor(new Type[] {});
                Hobbies point = value as Hobbies;
                return new InstanceDescriptor(constructorInfo, new object[] {  });
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }


        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                Hobbies hobbies = new Hobbies();
                string[] par = value.ToString().Split(',');
                if (par.Length == 0)
                    throw new NotSupportedException("输入非法");
                foreach (var item in par)
                {
                    switch (item)
                    {
                        case "Music":
                            hobbies.Music = true;
                            break;
                        case "Game":
                            hobbies.Game = true;
                            break;
                        case "Running":
                            hobbies.Running = true;
                            break;
                        case "Film":
                            hobbies.Film = true;
                            break;
                        case "Basketball":
                            hobbies.Basketball = true;
                            break;
                        default:
                            break;
                    }
                }
                return hobbies;
            }

            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// 根据返回值确定是否支持下拉框的形式
        /// </summary>
        /// true: 下来框的形式  
        /// false: 普通文本编辑的形式  
        /// <param name="context"></param>
        /// <returns></returns>
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
