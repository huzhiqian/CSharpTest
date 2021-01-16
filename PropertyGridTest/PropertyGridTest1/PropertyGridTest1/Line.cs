using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.IO;


//**********************************************
//文件名：Line
//命名空间：PropertyGridTest1
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/2 21:26:58
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest1
{

   public  class Line
    {
        private double lineLength = 0;
        private Color lineColor= Color.AntiqueWhite;
        private string name = "Line1";

        private CPoint startPoint = new CPoint();
        private CPoint endPoint = new CPoint();
        #region 构造函数

        public Line()
        {

        }

        #endregion


        #region 属性


        [Browsable(true)]
        [CategoryAttribute("常规"), DescriptionAttribute("线段长度"), ReadOnlyAttribute(true)]
        public string LineName
        {
            get { return name; }
            set { name = value; }
        }


        [Browsable(true)]
        [CategoryAttribute("属性"),DescriptionAttribute("线段长度"),ReadOnlyAttribute(true)]
        public double LineLength
        {
            get { return lineLength; }
            set { lineLength = value; }
        }

        [Browsable(true)]
        [CategoryAttribute("属性"), DescriptionAttribute("线段颜色"), ReadOnlyAttribute(false)]
        public Color LineColor
        {
            get { return lineColor; }
            set { lineColor = value;
                Changed?.Invoke();
            }
        }

        [TypeConverter(typeof(LineConverter))]
        [Browsable(true)]
        [CategoryAttribute("位置"), DescriptionAttribute("线段起始点"), ReadOnlyAttribute(false)]
        public CPoint StartPoint
        {
            get { return startPoint; }
            set {
                startPoint = value;
                Changed?.Invoke();
            }
        }

        [TypeConverter(typeof(LineConverter))]
        [Browsable(true)]
        [CategoryAttribute("位置"), DescriptionAttribute("线段起终点"), ReadOnlyAttribute(false)]
        public CPoint EndPoint
        {
            get { return endPoint; }
            set { endPoint = value;
                Changed?.Invoke();
            }
        }


        #endregion

        #region 公共方法



        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件

        public event Action Changed;

        #endregion
    }
}
