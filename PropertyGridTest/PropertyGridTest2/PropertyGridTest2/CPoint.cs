using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：CPoint
//命名空间：PropertyGridTest2
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/4 13:22:43
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest2
{
   public class CPoint
    {
        private int x = 0;
        private int y = 0;
        #region 构造函数

        public CPoint(int _x,int _y)
        {
            x = _x;
            y = _y;
        }

        #endregion


        #region 属性

       public int X {
            get { return x; }
            set { x = value; }
        }


        public int Y {
            get { return y; }
            set { y = value; }
        }
        #endregion

        #region 公共方法



        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
