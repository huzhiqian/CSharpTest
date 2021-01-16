using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：CPoint
//命名空间：PropertyGridTest1
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/3 9:18:10
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest1
{
    public class CPoint
    {
        private int pX = 0;
        private int pY = 0;
        #region 构造函数

        public CPoint()
        {

        }
        public CPoint(int x,int y)
        {
            pX = x;
            pY = y;
        }
        #endregion


        #region 属性


        public int PointX {
            get { return pX; }
            set { pX = value; }
        }

        public int PointY
        {
            get { return pY; }
            set { pY = value; }
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
