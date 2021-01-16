using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;


//**********************************************
//文件名：FCButton
//命名空间：FormEx
//CLR版本：4.0.30319.42000
//内容：
//功能：窗体控制按钮，控制窗体关闭最大化最小化等
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/5/29 13:11:04
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace FormEx
{
  public  class FCButton:UserControl
    {
        
        #region 构造函数

        public FCButton()
        {
            InitializeComponent();
        }

        #endregion

        #region 属性

        private ButtonType buttonType = ButtonType.Minimize;

        /// <summary>
        /// 获取或设置按钮的类型
        /// </summary>
        [Browsable(true),Description("设置窗体控制按钮的样式，如Min表示最小化按钮，Close表示关闭按钮")]
        [ReadOnly(false)]
        public ButtonType ButtonType
        {
            get { return buttonType; }
            set {
                if (value != buttonType) {
                    buttonType = value;
                    switch (buttonType)
                    {
                        case ButtonType.Minimize:
                            DefaultImage = global::FormEx.Properties.Resources.Min;
                            break;
                        case ButtonType.Max:
                            DefaultImage = global::FormEx.Properties.Resources.Max;
                            break;
                        case ButtonType.MaxNormal:
                            DefaultImage = global::FormEx.Properties.Resources.Max_Normal;
                            break;
                        case ButtonType.Close:
                            DefaultImage = global::FormEx.Properties.Resources.Close;
                            break;
                        default:
                            break;
                    }
                    this.Invalidate();
                }
            }
        }

        private Color mouseEnterColor = Color.White;
        /// <summary>
        /// 获取或设置鼠标进入是的背景颜色
        /// </summary>
        [Browsable(true),Description("设置鼠标进入时按钮背景颜色")]
        [ReadOnly(false)]
        public Color MouseEnterColor
        {
            get { return mouseEnterColor; }
            set {
                if (value != mouseEnterColor)
                {
                    mouseEnterColor = value;
                    this.Invalidate();
                }
            }
        }

        private Color mouseLeaveColor = Color.White;

        /// <summary>
        /// 获取或设置鼠标离开时的背景颜色
        /// </summary>
        [Browsable(true), Description("设置鼠标离开时按钮背景颜色")]
        [ReadOnly(false)]
        public Color MouseLeaveColor
        {
            get { return mouseLeaveColor; }
            set {
                if (value != mouseLeaveColor)
                {
                    mouseLeaveColor = value;
                    this.Invalidate();
                }
            }
        }

        private Color mouseUpColor = Color.Blue;

        /// <summary>
        /// 获取或设置鼠标抬起时背景颜色
        /// </summary>
        [Browsable(true), Description("设置鼠标抬起时背景颜色")]
        [ReadOnly(false)]
        public Color MouseUpColor
        {
            get { return mouseUpColor; }
            set {
                if (value != mouseUpColor)
                {
                    mouseUpColor = value;
                    this.Invalidate();
                }
            }
        }

        private Color mouseDownColor = Color.Blue;

        /// <summary>
        /// 获取或设置鼠标按下时的颜色
        /// </summary>
        [Browsable(true), Description("设置鼠标按下时背景颜色")]
        [ReadOnly(false)]
        public Color MouseDownColor
        {
            get { return mouseDownColor; }
            set {
                if (value != mouseDownColor)
                {
                    mouseDownColor = value;
                    this.Invalidate();
                }
            }
        }

        private Image defaultImage = global::FormEx.Properties.Resources.Min;

        /// <summary>
        /// 获取或设置默认背景图
        /// </summary>
        [Browsable(false)]
        public Image DefaultImage
        {
            get { return defaultImage; }
            set {
                if (value != defaultImage)
                {
                    defaultImage = value;
                    this.BackgroundImage = defaultImage;
                    this.Invalidate();
                }
            }
        }
        
        #endregion

        #region 公共方法



        #endregion

        #region 私有方法

        private void FCButton_Paint(object sender, PaintEventArgs e)
        {
           
            //switch (buttonType)
            //{
            //    case ButtonType.Minimize:
            //        this.BackgroundImage = global::FormEx.Properties.Resources.Min;
            //        break;
            //    case ButtonType.Max:
            //        this.BackgroundImage = global::FormEx.Properties.Resources.Max;
            //        break;
            //    case ButtonType.MaxNormal:
            //        this.BackgroundImage = global::FormEx.Properties.Resources.Max_Normal;
            //        break;
            //    case ButtonType.Close:
            //        if (isMouseEnter)
            //        {
            //            this.BackgroundImage = global::FormEx.Properties.Resources.Close_MoseEnter;
            //        }
            //        else
            //        {
            //            this.BackgroundImage = global::FormEx.Properties.Resources.Close;
            //        }
            //        break;
            //    default:
            //        break;
            //}
        }

        private bool isMouseEnter = false;
        private void FCButton_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter = true;
            if (buttonType == ButtonType.Close)
            {
                DefaultImage = global::FormEx.Properties.Resources.Close_MoseEnter;
            }
            this.BackColor = MouseEnterColor;
            this.Invalidate();
        }

        private void FCButton_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter = false;
            if (buttonType == ButtonType.Close)
            {
                DefaultImage = global::FormEx.Properties.Resources.Close;
            }
            this.BackColor = mouseLeaveColor;
            this.Invalidate();
        }

        private void FCButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = mouseDownColor;
            this.Invalidate();
        }

        private void FCButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = mouseUpColor;
            this.Invalidate();
        }
        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FCButton
            // 
            //this.BackgroundImage = global::FormEx.Properties.Resources.Min;
            this.Name = "FCButton";
            this.Size = new System.Drawing.Size(16, 16);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FCButton_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FCButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FCButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FCButton_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FCButton_MouseUp);
            this.ResumeLayout(false);

        }

       
    }

    public enum ButtonType
    {
        Minimize,//最小化
        Max,//最大化
        MaxNormal,//最大化正常状态
        Close//关闭
    }
}
