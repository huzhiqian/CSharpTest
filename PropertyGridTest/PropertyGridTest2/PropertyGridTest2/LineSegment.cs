using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Drawing.Drawing2D;
using System.ComponentModel;


//**********************************************
//文件名：LineSegment
//命名空间：PropertyGridTest2
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/4 13:20:03
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest2
{
    //线段类
   public class LineSegment:LineSegmentBase
    {
        private LineCap startCap= LineCap.Square;
        private LineCap endCap = LineCap.Square;
        #region 构造函数

        public LineSegment():base()
        {

        }

        public LineSegment(CPoint _startPoint, CPoint _endPoint) : base(_startPoint, _endPoint)
        {

        }
        #endregion


        #region 属性

        [Browsable(true)]
        [CategoryAttribute("样式"), DescriptionAttribute("线段起点样式"), ReadOnlyAttribute(false)]
        public LineCap StartCap
        {
            get { return startCap; }
            set { startCap = value;
                OnChanged();
            }
        }

        [Browsable(true)]
        [CategoryAttribute("样式"), DescriptionAttribute("线段终点样式"), ReadOnlyAttribute(false)]
        public LineCap EndCap
        {
            get { return endCap; }
            set { endCap = value;
                OnChanged();
            }
        }

        [Browsable(false)]
        public new string Name
        {
            get { return base.Name; }
 
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
