using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;



//**********************************************
//文件名：StartMachineState
//命名空间：StatePatternTest3.MotionSystem
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/9 9:38:57
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionSystem
{
   public class StartMachineState:State
    {
        private List<MotionModules.MotionModuleBase> motionModules = null;
        MotionModules.Module1.Module1Application module1Application = null;
        MotionModules.Module2.Module2Application module2Application = null;
        #region 构造函数

        public StartMachineState(MotionSysStateManager stateManager)
        {
            motionState = MotionStateConstant.RUNNING;

            motionModules = new List<MotionModules.MotionModuleBase>();

            //初始化执行模块，在Dome程序中直接实例化然后添加到列表中，在以后的软件中可以使用MEF方式实例化
             module1Application = new MotionModules.Module1.Module1Application(stateManager);
             module2Application = new MotionModules.Module2.Module2Application(stateManager);
            motionModules.Add(module1Application);
            motionModules.Add(module2Application);
        }



        #endregion


        #region 属性

        public MotionModules.Module2.Module2Application Module2Application
        {
            get { return module2Application; }
        }

        #endregion

        #region 公共方法

        public override void MotionStateHandle(MotionSYSContext context)
        {
            List<System.Threading.Tasks.Task> tasks = new List<System.Threading.Tasks.Task>();
            foreach (var item in motionModules)
            {
                tasks.Add(System.Threading.Tasks.Task.Factory.StartNew(()=> {
                    item.Run();
                }));
            }

            System.Threading.Tasks.Task.WaitAll(tasks.ToArray());
            Thread.Sleep(100);
            Console.WriteLine("Machine Running");
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
