using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：SaveImage
//命名空间：DecoratorPatternTest
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/23 20:33:01
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace DecoratorPatternTest
{
   public class SaveImage : ISaveImage
    {

        #region 构造函数

        public SaveImage()
        {

        }

        #endregion


        #region 属性



        #endregion

        #region 公共方法


        public virtual void Save(string path)
        {
            Console.WriteLine("保存图片");
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
