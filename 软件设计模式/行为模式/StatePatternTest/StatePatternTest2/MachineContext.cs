using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;


//**********************************************
//文件名：MachineContext
//命名空间：StatePatternTest2
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/7 13:57:35
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest2
{
    public class MachineContext
    {
        private ListBox listbox = null;
        private State _state = null;
        private MachineStateConstant machineState = MachineStateConstant.UnReset;
        #region 构造函数

        public MachineContext()
        {
           
        }

        #endregion


        #region 属性

        public ListBox InfoControl
        {
            set { listbox = value; }
        }


        internal State State
        {
            get { return _state; }
            set
            {
                _state = value;
                SetInfo(value.GetType().Name);
            }
        }

        /// <summary>
        /// 获取设备当前状态
        /// </summary>
        public MachineStateConstant MachineState
        {
            get { return machineState; }
            set
            {
                machineState = value;
            }
        }
        #endregion

        #region 公共方法

        /// <summary>
        /// 设置运行状态对象
        /// </summary>
        /// <param name="state"></param>
        /// <param name="machineState"></param>
        public void SetState(State state, MachineStateConstant machineState)
        {
           
            State = state;
            MachineState = machineState;
        }

        public void DoAction()
        {
            if (_state != null)
                _state.DoCommond(this);
        }

        #endregion

        #region 私有方法

        private void SetInfo(string info)
        {
            listbox.Invoke(new Action(() =>
            {
                if (listbox.Items.Count > 100)
                    listbox.Items.RemoveAt(0);

                listbox.Items.Add(string.Format($"{DateTime.Now.ToString("mm:ss.fff")}  {info}"));
            }));
        }


        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
