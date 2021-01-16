using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：ScanImageState
//命名空间：StatePatternTest3.MotionModules.Module2
//CLR版本：4.0.30319.42000
//内容：
//功能：扫描图像
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/17 11:18:12
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionModules.Module2
{
    public  class ScanImageState:State
    {
        private bool isScanning = false;
        #region 构造函数

        public ScanImageState()
        {

        }


        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public override void Handle(Context context)
        {
            if (TempData.isProductInVisionStation && !isScanning)
            {
                isScanning = true;
                CommonModules.Notifier.NotifyHelper.Notify( CommonModules.Notifier.NotifyLevel.INFO,
                    "开始扫描物料。");
                Thread.Sleep(1000);
                CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.INFO,
               "扫描物料完成");

                context.SteState = context.ImageProcessState ;//执行图像处理程序
                isScanning = false;
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
