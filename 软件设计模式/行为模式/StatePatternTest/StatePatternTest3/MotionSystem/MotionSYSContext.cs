using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：MotionSYSContext
//命名空间：StatePatternTest3.MotionSystem
//CLR版本：4.0.30319.42000
//内容：
//功能：运动控制系统中状态控制环境类
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/9 8:47:09
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionSystem
{
    public class MotionSYSContext
    {
        private State _state =null;
        private MotionStateConstant stateConstant = MotionStateConstant.UNRESET;
        //设备状态对象
        private StartMachineState startState = null;
        private StopMachineState stopState = null;
        private ResetMachineState resetState = null;
        private EMGStopState emgStopState = null;

        private MotionSysStateManager stateManager = null;
        #region 构造函数

        public MotionSYSContext(MotionSysStateManager motionSysState)
        {
            stateManager = motionSysState;
            startState = new StartMachineState(stateManager);
            stopState = new StopMachineState();
            resetState = new ResetMachineState();
            emgStopState = new EMGStopState();
        }

        #endregion


        #region 属性

        /// <summary>
        /// 获取系统状态管理对象
        /// </summary>
        public MotionSysStateManager SysStateManager
        {
            get { return stateManager; }
        }


        /// <summary>
        /// 获取启动状态对象
        /// </summary>
        public StartMachineState StartMachineState
        {
            get { return startState; }
        }

        /// <summary>
        /// 获取停止状态对象
        /// </summary>
        public StopMachineState StopMachineState
        {
            get { return stopState; }
        }

        public EMGStopState EMGStopState
        {
            get { return emgStopState; }
        }

        public ResetMachineState ResetMachineState
        {
            get { return resetState; }
        }
        #endregion

        #region 公共方法

        public void SetState(State state)
        {
            if (state.motionState == MotionStateConstant.RUNNING)
                stateManager.MotionState = state.motionState;
            _state = state;
        
        }

        public void DoStateCommond()
        {
            if (_state != null)
                _state.MotionStateHandle(this);
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
