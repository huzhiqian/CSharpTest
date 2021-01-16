using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundButton
{

    [ToolboxItemAttribute(true)]
    public partial class RoundButton : Button
    {

        private RectangleF rect = new RectangleF();//控件矩形区域
        private bool mouseEnter = false;//鼠标是否进入控件区域
        private bool buttonOnPressed = false;//按钮是否被按下
        private bool buttonClicked = false;//按钮是否被点击

        private int _height;
        private int _width;
        #region 构造函数

        public RoundButton()
        {
            //控件风格
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            //设置初始值
            this.Height = this.Width = 80;
            this._width = this.Width;
            this._height = this.Height;

            DistanceToBorder = 4;
            ButtonCenterColorStart = Color.CornflowerBlue;
            ButtonCenterColorEnd = Color.DodgerBlue;
            BorderColor = Color.Black;
            FocusBorderColor = Color.Orange;
            IconColor = Color.Black;
            BorderWidth = 4;
            BorderTransparent = 200;
            GradientAngle = 90;

            mouseEnter = false;
            buttonClicked = false;
            buttonOnPressed = false;
            IsShowIcon = false;

            InitializeComponent();
        }

        #endregion


        #region 属性

        #region 形状

        /// <summary>
        /// 获取或设置圆形按钮的圆的边缘距离控件边框的距离
        /// </summary>
        [Browsable(true), DefaultValue(2)]
        [Category("Appearance")]
        public int DistanceToBorder { get; set; }

        #endregion


        #region 填充色


        /// <summary>
        /// 获取或设置按钮主体渐变起始颜色
        /// </summary>
        [Browsable(true), DefaultValue(typeof(Color), "CornflowerBlue"), Description("按钮主体渐变起始颜色")]
        [Category("Appearance")]
        public Color ButtonCenterColorStart { get; set; }

        /// <summary>
        /// 获取或设置按钮主体渐变终点颜色
        /// </summary>
        [Browsable(true), DefaultValue(typeof(Color), "DodgerBlue"), Description("按钮主体渐变终点颜色")]
        [Category("Appearance")]
        public Color ButtonCenterColorEnd { get; set; }

        /// <summary>
        /// 获取或设置按钮主体颜色渐变方向
        /// </summary>
        [Browsable(true), DefaultValue(90), Description("按钮主体颜色渐变方向，X轴顺时针开始")]
        [Category("Appearance")]
        public int GradientAngle { get; set; }

        /// <summary>
        /// 获取或设置是否显示中间标志
        /// </summary>
        [Browsable(true), DefaultValue(false), Description("是否显示中间标志")]
        [Category("Appearance")]
        public bool IsShowIcon { get; set; }

        /// <summary>
        /// 获取或设置中间标志的填充色
        /// </summary>
        [Browsable(true), DefaultValue(typeof(Color), "Black"), Description("按钮中间标志填充色")]
        [Category("Appearance")]
        public Color IconColor { get; set; }
        #endregion


        #region 边框

        /// <summary>
        /// 获取或设置按钮边框宽度
        /// </summary>
        [Browsable(true), DefaultValue(8), Description("按钮边框宽度")]
        [Category("Appearance")]
        public int BorderWidth { get; set; }

        /// <summary>
        /// 获取或设置按钮边框亚颜色
        /// </summary>
        [Browsable(true), DefaultValue(typeof(Color), "Black"), Description("按钮边框颜色")]
        [Category("Appearance")]
        public Color BorderColor { get; set; }

        /// <summary>
        /// 获取或设置边框透明度
        /// </summary>
        [Browsable(true), DefaultValue(200), Description("设置边框透明度")]
        [Category("Appearance")]
        public int BorderTransparent { get; set; }

        [Browsable(true), DefaultValue(typeof(Color), "Orange"), Description("按钮获取焦点后的边框颜色")]
        [Category("Appearance")]
        public Color FocusBorderColor { get; set; }
        #endregion

        #endregion

        #region 重写函数事件

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            base.OnPaintBackground(pevent);
            Graphics g = pevent.Graphics;


            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//抗锯齿

            ResizeCtrl();//获取控件区域
            using (var brush = new LinearGradientBrush(rect, ButtonCenterColorStart, ButtonCenterColorEnd, GradientAngle))
            {

                PaintShape(g, brush, rect);//绘制按钮中心区域

                DrawBorder(g);//绘制边框       

                if (mouseEnter)
                {
                    DrawHighLight(g);//绘制高亮区域
                                     //DrawStateIcon(g);//绘制功能标志
                }
                DrawStateIcon(g);//绘制中间区域功能表示
                DrawText(g);//绘制文字，如果不绘制图标则绘制文字
            }


        }

        /// <summary>
        /// 控件大小发生改变
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (this.Height != _height)
            {
                _height = this.Height;
                this.Width = this.Height;
            }

            if (this.Width != this._width)
            {
                _width = this.Width;
                this.Height = this.Width;
            }
        }
        #endregion


        #region 私有方法

        /// <summary>
        /// 重新获取控件大小
        /// </summary>
        protected void ResizeCtrl()
        {
            int x = DistanceToBorder;
            int y = DistanceToBorder;
            int width = this.Width - 2 * DistanceToBorder;
            int height = this.Height - 2 * DistanceToBorder;
            rect = new RectangleF(x, y, width, height);
        }


        /// <summary>
        /// 绘制图形
        /// </summary>
        /// <param name="g"></param>
        /// <param name="brush"></param>
        /// <param name="rect"></param>
        protected void PaintShape(Graphics g, Brush brush, RectangleF rect)
        {
            g.FillEllipse(brush, rect);
        }

        /// <summary>
        /// 绘制边框
        /// </summary>
        /// <param name="g"></param>
        protected virtual void DrawBorder(Graphics g)
        {
            Pen p = new Pen(BorderColor);
            if (Focused)
            {
                p.Color = FocusBorderColor;//外圈获取焦点后的颜色
                p.Width = BorderWidth;
                PaintShape(g, p, rect);
            }
            else
            {
                p.Width = BorderWidth;
                PaintShape(g, p, rect);
            }
        }

        /// <summary>
        /// 绘制图形
        /// </summary>
        /// <param name="g">Graphics对象</param>
        /// <param name="pen">Pen对象</param>
        /// <param name="rect">RectangleF对象</param>
        protected virtual void PaintShape(Graphics g, Pen pen, RectangleF rect)
        {
            g.DrawEllipse(pen, rect);
        }

        /// <summary>
        /// 绘制中间状态按钮
        /// </summary>
        /// <param name="g"></param>
        private void DrawStateIcon(Graphics g)
        {
            if (IsShowIcon)
            {
                if (buttonClicked)
                {
                    GraphicsPath startIconPath = new GraphicsPath();
                    int W = base.Width / 3;
                    Point p1 = new Point(W, W);
                    Point p2 = new Point(2 * W, W);
                    Point p3 = new Point(2 * W, 2 * W);
                    Point p4 = new Point(W, 2 * W);
                    Point[] pts = { p1, p2, p3, p4 };
                    startIconPath.AddLines(pts);
                    Brush brush = new SolidBrush(IconColor);
                    g.FillPath(brush, startIconPath);
                }
                else
                {
                    GraphicsPath stopIconPath = new GraphicsPath();
                    int W = base.Width / 4;
                    Point p1 = new Point(3 * W / 2, W);
                    Point p2 = new Point(3 * W / 2, 3 * W);
                    Point p3 = new Point(3 * W, 2 * W);
                    Point[] pts = { p1, p2, p3, };
                    stopIconPath.AddLines(pts);
                    Brush brush = new SolidBrush(IconColor);
                    g.FillPath(brush, stopIconPath);
                }
            }
        }

        private void DrawText(Graphics g)
        {
            if (!IsShowIcon)
            {
                if (!string.IsNullOrEmpty(this.Text))
                {

                    using (Brush brush = new SolidBrush(this.ForeColor))
                    {
                        using (StringFormat strFormat = new StringFormat()
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center,

                        })//文本格式
                        {
                            SizeF size = g.MeasureString(this.Text,this.Font);
                            RectangleF tempRect = this.rect;
                            tempRect.Height += size.Height/4;
                            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                            g.DrawString(this.Text, this.Font, brush, tempRect, strFormat);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 绘制高亮效果
        /// </summary>
        /// <param name="g"></param>
        protected virtual void DrawHighLight(Graphics g)
        {
            RectangleF highLightRect = rect;
            highLightRect.Inflate(-BorderWidth / 2, -BorderWidth / 2);
            Brush brush = Brushes.DodgerBlue;
            if (buttonOnPressed)
            {
                brush = new LinearGradientBrush(rect, ButtonCenterColorStart, ButtonCenterColorEnd, GradientAngle);
            }
            else
            {
                brush = new LinearGradientBrush(rect, Color.FromArgb(60, Color.White),
            Color.FromArgb(60, Color.White), GradientAngle);
            }
            PaintShape(g, brush, highLightRect);
        }
        #endregion

        #region 鼠标事件

        /// <summary>
        /// 鼠标点击事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            buttonClicked = !buttonClicked;
        }


        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button != MouseButtons.Left) return;
            buttonOnPressed = false;
            base.Invalidate();//从重绘控件
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button != MouseButtons.Left) return;
            buttonOnPressed = true;
        }

        /// <summary>
        /// 鼠标进入
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseEnter = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseEnter = false;
        }
        #endregion
    }

    public partial class RoundButton
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
    }
}
