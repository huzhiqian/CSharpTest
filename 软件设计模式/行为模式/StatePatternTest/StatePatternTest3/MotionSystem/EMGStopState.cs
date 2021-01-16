using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：EMGStopState
//命名空间：StatePatternTest3.MotionSystem
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/9 13:37:20
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionSystem
{
   public class EMGStopState:State
    {

        #region 构造函数

        public EMGStopState()
        {
            motionState = MotionStateConstant.EMGSTOP;
        }



        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public override void MotionStateHandle(MotionSYSContext context)
        {
            if (context.SysStateManager.MotionState != MotionStateConstant.EMGSTOP)
            {
                Console.WriteLine("紧急停止！");
                EMGStopMachineEvent?.Invoke(true);
                context.SysStateManager.MotionState = MotionStateConstant.EMGSTOP;
            }
          
        }

        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件

        public event Action<bool> EMGStopMachineEvent;

        #endregion
    }
}
