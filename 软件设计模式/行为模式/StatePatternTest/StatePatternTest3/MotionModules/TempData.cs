using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：TempData
//命名空间：StatePatternTest3.MotionModules
//CLR版本：4.0.30319.42000
//内容：
//功能：静态临时数据
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/17 9:57:41
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionModules
{
   public static class TempData
    {
        public static bool inCommingIO = false;//来料IO
        public static bool isAxisAtOriginPost = true;
       
        public static bool isCameraScan = false;
        public static bool isProductInVisionStation = false;
        #region 构造函数

         static TempData()
        {

        }

        #endregion


        #region 属性



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
