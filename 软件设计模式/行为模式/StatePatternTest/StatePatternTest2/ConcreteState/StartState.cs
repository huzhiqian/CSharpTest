using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;


//**********************************************
//文件名：StartState
//命名空间：StatePatternTest2.ConcreteState
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/8 10:04:16
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest2.ConcreteState
{
    public class StartState : State
    {
       public Action<string> DisplayAction { get; set; }
        public override void DoCommond(MachineContext machineContext)
        {
          if(machineContext.MachineState== MachineStateConstant.Running)
            if (DisplayAction != null)
            {
                    Thread.Sleep(100);
                DisplayAction.Invoke($"当前时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            }
        }
    }
}
