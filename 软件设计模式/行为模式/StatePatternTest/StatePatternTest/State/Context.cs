using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：Context
//命名空间：StatePatternTest.State
//CLR版本：4.0.30319.42000
//内容：
//功能：状态管理器，维持一个ConcreteState子类的实例
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/7 9:50:08
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest.State
{
   public class Context
    {

        private State state = null;

        public Context(State _state)
        {
            this.State = _state;
        }

        internal State State
        {
            get { return state; }
            set {
                state = value;
                Console.WriteLine("当前状态：" + this.state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
