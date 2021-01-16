using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：MotionStateConstant
//命名空间：StatePatternTest3
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/9 8:38:50
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3
{
    public enum MotionStateConstant
    {
        UNRESET=-1,//未初始化
        STOP=0,    //停止
        RUNNING=1,//运行
        EMGSTOP=2,//急停
        PAUSE=3//暂停
    }
}
