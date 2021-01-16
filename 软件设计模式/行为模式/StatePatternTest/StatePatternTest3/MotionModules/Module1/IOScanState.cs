using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Timers;


//**********************************************
//文件名：IOScanState
//命名空间：StatePatternTest3.MotionModules.Module1
//CLR版本：4.0.30319.42000
//内容：
//功能：模拟扫描IO
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/17 9:55:45
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionModules.Module1
{
   public class IOScanState:State,IDisposable
    {
        private System.Timers.Timer timer = null;
        #region 构造函数

        public IOScanState()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += TimerElapsed;

            timer.Start();
        }

        public override void StateHandle(Context context)
        {
            if (TempData.inCommingIO && !TempData.isCameraScan && TempData.isAxisAtOriginPost)
                context.SetState = new CarryProductState();//由于是测试所有每次都New对象，在实际软甲中为了节省构造时间通常都提前构造好对象
        }

        #endregion


        #region 属性



        #endregion

        #region 公共方法



        #endregion

        #region 私有方法

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (TempData.inCommingIO == false)
                TempData.inCommingIO = true;
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                    if (timer != null)
                    {
                        timer.Stop();
                        timer.Dispose();
                        timer = null;
                    }

                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~IOScanState() {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
             GC.SuppressFinalize(this);
        }
        #endregion

        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
