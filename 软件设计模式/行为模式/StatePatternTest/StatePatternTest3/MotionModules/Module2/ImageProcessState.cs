using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Drawing;


//**********************************************
//文件名：ImageProcessState
//命名空间：StatePatternTest3.MotionModules.Module2
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/17 11:29:53
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionModules.Module2
{
    public class ImageProcessState : State
    {
        private Bitmap srcImage1 = null;
        private Bitmap srcImage2 = null;
        private Random random = new Random();
        #region 构造函数

        public ImageProcessState()
        {
            srcImage1 = new Bitmap("1.jpg");
            srcImage2 = new Bitmap("2.jpg");
           
        }



        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public override void Handle(Context context)
        {
            CommonModules.Notifier.NotifyHelper.Notify( CommonModules.Notifier.NotifyLevel.INFO,"ImageProcess");
            int val=random.Next(1,100);
            if (val % 2 == 0)
            {
                //OK
                ImageProcessComplete.BeginInvoke(true,srcImage1,null,null);
            }
            else
            {
                //NG
                ImageProcessComplete.BeginInvoke(false, srcImage2, null, null);
            }
            context.SteState = new ScanImageState();
            //下料
            TempData.isProductInVisionStation = false;

        }

        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件

        public event Action<bool, Bitmap> ImageProcessComplete;

        #endregion
    }
}
