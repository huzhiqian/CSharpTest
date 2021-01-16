using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：State
//命名空间：StatePatternTest2
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/7 13:56:48
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest2
{
  public abstract class State
    {
        //定义一个接口，封装Context一个特定状态的行为
        public abstract void DoCommond(MachineContext machineContext);          
    }
}
