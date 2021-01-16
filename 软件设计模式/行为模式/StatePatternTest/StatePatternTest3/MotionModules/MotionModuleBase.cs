using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：MotionModuleBase
//命名空间：StatePatternTest3.MotionModules
//CLR版本：4.0.30319.42000
//内容：
//功能：运动控制系统中模块基类
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/9 9:03:00
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionModules
{
    public class MotionModuleBase
    {
        protected MotionSystem.MotionSysStateManager m_StateManager;

        protected bool mStepMode = false;//单步模式
        protected int stepFlag = 0;
        #region 构造函数

        public MotionModuleBase(MotionSystem.MotionSysStateManager stateManager)
        {
            m_StateManager = stateManager;
        }

        #endregion


        #region 属性

        internal int StepFlag
        {
            set
            {
                if (value != stepFlag)
                {
                    stepFlag = value;
                    StepFlageChange?.BeginInvoke(null, null);
                }
            }
        }

        #endregion

        #region 公共方法

        public virtual void Run() {

        }

        #endregion

        #region 私有方法

        protected void DoCommand(Action act)
        {
            if (m_StateManager.MotionState == MotionStateConstant.EMGSTOP ||
                m_StateManager.MotionState == MotionStateConstant.STOP)
                return;
            //暂停
            if (m_StateManager.MotionState == MotionStateConstant.PAUSE)
            {
                while (true)
                {
                    Thread.Sleep(1);
                    //在暂停的过程中，如果按下停止或急停直接跳出过程
                    if (m_StateManager.MotionState == MotionStateConstant.EMGSTOP ||
                         m_StateManager.MotionState == MotionStateConstant.STOP)
                        return;
                    if (m_StateManager.MotionState == MotionStateConstant.RUNNING)
                        break;
                }
            }
            //单步模式
            if (mStepMode)
            {
                while (stepFlag != 1)//当stepFlag=1时单步等待 
                {
                    Thread.Sleep(1);
                }
            }
            act.BeginInvoke(new AsyncCallback(DocommandActionCB), null);
        }


        private void DocommandActionCB(IAsyncResult ar)
        {
            if (mStepMode)
            {
                if (stepFlag == 0)
                    stepFlag += 1;
            }
        }
        #endregion

        #region 委托



        #endregion

        #region 事件

        public event Action StepFlageChange;

        #endregion
    }
}
