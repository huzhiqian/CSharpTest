using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：Module2Application
//命名空间：StatePatternTest3.MotionModules.Module2
//CLR版本：4.0.30319.42000
//内容：
//功能：模块二程序
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/17 13:57:20
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionModules.Module2
{
   public class Module2Application:MotionModuleBase
    {
        Context _context = null;
        #region 构造函数

        public Module2Application(MotionSystem.MotionSysStateManager motionSysStateManager):base(motionSysStateManager)
        {
            _context = new Context();
        }

        #endregion


        #region 属性

        public Context Context
        {
            get { return _context; }
        }

        #endregion

        #region 公共方法

        public override void Run()
        {
            System.Threading.Tasks.Task task = new System.Threading.Tasks.Task(() =>
            {
               
                _context.DoStateAction();
            });
            task.Start();
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
