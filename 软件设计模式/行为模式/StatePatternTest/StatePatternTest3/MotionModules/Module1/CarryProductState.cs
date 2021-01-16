using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：CarryProductState
//命名空间：StatePatternTest3.MotionModules.Module1
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/17 10:28:00
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionModules.Module1
{
   public class CarryProductState:State
    {
        private bool isCarryProduct = false;
        #region 构造函数

        public CarryProductState()
        {

        }



        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public override void StateHandle(Context context)
        {
            if (!isCarryProduct)
            {
                TempData.inCommingIO = false;
                isCarryProduct = true;
                CommonModules.Notifier.NotifyHelper.Notify( CommonModules.Notifier.NotifyLevel.INFO, "开始搬运物料");
                TempData.isAxisAtOriginPost = false;
                Thread.Sleep(2000);
                CommonModules.Notifier.NotifyHelper.Notify( CommonModules.Notifier.NotifyLevel.INFO,"搬运物料完成");
                TempData.isProductInVisionStation = true;
           
                //执行返回程序
                context.SetState =new AxisReturnState();
                isCarryProduct = false;
            }
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
