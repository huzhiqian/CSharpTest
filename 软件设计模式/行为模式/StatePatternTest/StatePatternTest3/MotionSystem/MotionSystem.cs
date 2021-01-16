using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;


//**********************************************
//文件名：MotionSystem
//命名空间：StatePatternTest3.MotionSystem
//CLR版本：4.0.30319.42000
//内容：
//功能：运动控制系统类
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/9 8:58:17
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionSystem
{
    public class MotionSystem
    {
        //单例
        private static MotionSystem motionSystemObj = null;
        private static object locker = new object();

        private Thread actionThread = null;//动作执行线程
        private MotionSYSContext context = null;
        private MotionSysStateManager stateManager = null;
        //Flag
        private bool isMachineInitlized = false;
        #region 构造函数

        private MotionSystem()
        {
            stateManager = new MotionSysStateManager();
            context = new MotionSYSContext(stateManager);
            //初始化动作执行线程
            actionThread = new Thread(ActionThreadFunc);
            actionThread.IsBackground = true;
            actionThread.Priority = ThreadPriority.AboveNormal;//优先级高于常规
            actionThread.Start();

            context.EMGStopState.EMGStopMachineEvent += new Action<bool>(EmgStopFunc);
            context.ResetMachineState.ResetMachineComplete += ResteMachineComplete;
        }


        public static MotionSystem GetMotionSystemINstance()
        {
            if (motionSystemObj == null)
            {
                lock (locker)
                {
                    if (motionSystemObj == null)
                    {
                        motionSystemObj = new MotionSystem();
                    }
                }
            }
            return motionSystemObj;
        }
        #endregion


        #region 属性

        /// <summary>
        /// 获取运动控制系统状态管理对象
        /// </summary>
        public MotionSysStateManager SysStateManager
        {
            get { return stateManager; }
        }

        public MotionSYSContext Context
        {
            get { return context; }
        }


        #endregion

        #region 公共方法

        public void StartMachine()
        {
            if (!isMachineInitlized)
            {
                MessageBox.Show("设备未初始化！");
                return;
            }
            if (SysStateManager.MotionState != MotionStateConstant.RUNNING)
            {
                //启动设备
                context.SetState(context.StartMachineState);
            }

        }

        public void StopMachine()
        {
            if (!isMachineInitlized)
            {
                MessageBox.Show("设备未初始化！");
                return;
            }
            if (SysStateManager.MotionState != MotionStateConstant.STOP)
            {
                //停止设备
                context.SetState(context.StopMachineState);
            }
        }

        public void ResetMachine()
        {
            if (!isMachineInitlized)
            {
                //初始化设备
                context.SetState(context.ResetMachineState);
            }
        }

        /// <summary>
        /// 紧急停止
        /// </summary>
        public void EMGStopMachine()
        {
            context.SetState(context.EMGStopState);
        }

        #endregion

        #region 私有方法



        private void ActionThreadFunc()
        {
            while (true)
            {
                Thread.Sleep(2);
                context.DoStateCommond();//执行动作
            }
        }


        private void EmgStopFunc(bool state)
        {
            isMachineInitlized = false;
            SysStateManager.MotionState = MotionStateConstant.EMGSTOP;
        }
        private void ResteMachineComplete()
        {
            isMachineInitlized = true;

        }
        #endregion

        #region 委托



        #endregion

        #region 事件


        #endregion
    }
}
