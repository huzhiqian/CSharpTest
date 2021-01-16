using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Drawing;
using System.ComponentModel;

namespace PropertyGridTest2
{
    /// <summary>
    /// 线段父类
    /// </summary>
   public class LineSegmentBase
    {
        private string name = "Line";
        private CPoint startPoint ;
        private CPoint endPoint;
        private Color lineColor=Color.Red;

        #region 构造函数

        public LineSegmentBase():this(new CPoint(0,0),new CPoint(1,1)){
           
        }

        public LineSegmentBase(CPoint _startPoint,CPoint _endPoint)
        {
            startPoint = _startPoint;
            endPoint = _endPoint;
        }

        #endregion

        public string Name {
            get { return name; }
        }

        #region 属性
        [TypeConverter(typeof(PointConverter))]
        public CPoint StartPoint {
            get { return startPoint; }
            set { startPoint = value;
                OnChanged();
            }
        }

        [TypeConverter(typeof(PointConverter))]
        public CPoint EndPoint
        {
            get { return endPoint; }
            set { endPoint = value;
                OnChanged();
            }
        }

        public Color LineColor
        {
            get { return lineColor; }
            set { lineColor = value;
                OnChanged();
            }
        }

        #endregion

        #region 公共方法



        #endregion

        #region 私有方法

        protected virtual void OnChanged()
        {
            Changed?.Invoke();
        }

        #endregion

        #region 委托



        #endregion

        #region 事件

        public event Action Changed;

        #endregion
    }
}
