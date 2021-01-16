using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：ConcreteStateA
//命名空间：StatePatternTest.State
//CLR版本：4.0.30319.42000
//内容：
//功能：具体状态子类A
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/7 10:18:59
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest.State
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
