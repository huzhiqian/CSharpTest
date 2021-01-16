using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：SaveImageDecorator
//命名空间：DecoratorPatternTest
//CLR版本：4.0.30319.42000
//内容：
//功能：保存图片的装饰者
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/23 20:36:00
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace DecoratorPatternTest
{
   public class SaveImageDecorator:ISaveImage
    {
        /// <summary>
        /// 被装饰者
        /// </summary>
        private ISaveImage mySaveImage;
        #region 构造函数
        public SaveImageDecorator(ISaveImage saveImage)
        {
            mySaveImage = saveImage;
        }

        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public virtual void Save(string path)   //实现ISaveimage接口中的方法
        {
            Console.WriteLine("装饰者：保存图片");
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
