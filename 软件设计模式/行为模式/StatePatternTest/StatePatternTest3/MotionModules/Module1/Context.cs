using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：Context
//命名空间：StatePatternTest3.MotionModules.Module1
//CLR版本：4.0.30319.42000
//内容：
//功能：模块一环境类
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/17 9:47:53
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionModules.Module1
{
   public class Context
    {
        private State _state = null;
        #region 构造函数

        public Context()
        {
            _state = new IOScanState();
        }

        #endregion


        #region 属性

        internal State SetState {
            set {
                _state = value;
            }
        }

        #endregion

        #region 公共方法

        public void DoStateAction()
        {
            if (_state != null)
            {
                _state.StateHandle(this);
            }
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
