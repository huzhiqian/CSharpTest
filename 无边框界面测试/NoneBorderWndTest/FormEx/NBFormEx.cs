using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace FormEx
{
    public partial class NBFormEx : Form
    {
        private Color titleBarColor = Color.Turquoise;
        private Point mPoint;
        public NBFormEx():base()
        {
           
            this.StartPosition = FormStartPosition.CenterScreen;
           
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(titleBar.Width / 4, titleBar.Height * 2);
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);//添加阴影效果
            label1.Text = this.Text;
        }

        private  void NBFormEx_Load(object sender, EventArgs e)
        {

        }

        #region 属性

        /// <summary>
        /// 获取或设置标题栏颜色
        /// </summary>
        [Browsable(true), Description("设置标题栏背景颜色")]
        public Color TitleBarColor
        {
            get { return titleBarColor; }
            set
            {
                if (value != titleBarColor)
                {
                    titleBarColor = value;
                    titleBar.BackColor = titleBarColor;
                    this.Invalidate();
                }
            }
        }

        private bool maxVisible = true;
        [Browsable(true), Description("是否允许最大化")]
        public bool MaxVisible
        {
            get { return maxVisible; }
            set
            {
                maxVisible = value;
                if (!maxVisible)
                {
                    this.btnEXMin.Location = new System.Drawing.Point(this.btnEXMax.Location.X, 12);
                    this.btnEXMax.Visible = false;
                }
                else
                {
                    this.btnEXMin.Location = new System.Drawing.Point(this.btnEXMax.Location.X - 20, 12);
                    this.btnEXMax.Visible = true;
                }
            }
        }

        /// <summary>
        /// 窗体标题
        /// </summary>
        private string titleText;
        [Description("窗体标题")]
        public string TitleText
        {
            get { return titleText; }
            set
            {
                titleText = value;
                label1.Text = titleText;

            }
        }

        /// <summary>
        /// 窗体标题是否显示
        /// </summary>
        private bool titleVisible = true;
        [Description("窗体标题是否显示")]
        public bool TitleVisible
        {
            get { return titleVisible; }
            set
            {
                titleVisible = value;
                label1.Visible = titleVisible;
            }
        }


        /// <summary>
        /// 窗口默认大小
        /// FormSize.NORMAL OR FormSize.MAX
        /// </summary>
        private FormSize defaultFormSize = FormSize.NORMAL;
        [Description("窗口默认大小")]
        public FormSize DefaultFormSize
        {
            get { return defaultFormSize; }
            set
            {
                defaultFormSize = value;
                if (defaultFormSize == FormSize.MAX)
                {
                    //防止遮挡任务栏
                    this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                    this.WindowState = FormWindowState.Maximized;
                    //最大化图标切换
                    this.btnEXMax.DefaultImage = global::FormEx.Properties.Resources.Max;
                }
            }
        }
        [Browsable(true)]
        public new Icon Icon
        {
            get { return base.Icon; }
            set {
                base.Icon = value;
                this.pictureBox1.Image = value.ToBitmap();
            }
        }
        #endregion

        const int WM_NCHITTEST = 0x0084;
        const int HTLEFT = 10;      //左边界
        const int HTRIGHT = 11;     //右边界
        const int HTTOP = 12;       //上边界
        const int HTTOPLEFT = 13;   //左上角
        const int HTTOPRIGHT = 14;  //右上角
        const int HTBOTTOM = 15;    //下边界
        const int HTBOTTOMLEFT = 0x10;    //左下角
        const int HTBOTTOMRIGHT = 17;     //右下角

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                //case 0x0201://鼠标左键按下的消息 
                //    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标 
                //    m.LParam = IntPtr.Zero;//默认值 
                //    m.WParam = new IntPtr(2);//鼠标放在标题栏内 
                //    base.WndProc(ref m);
                //    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            base.WndProc(ref m);
        //            Point vPoint = new Point((int)m.LParam & 0xFFFF,
        //                (int)m.LParam >> 16 & 0xFFFF);
        //            vPoint = PointToClient(vPoint);
        //            if (vPoint.X <= 5)
        //                if (vPoint.Y <= 5)
        //                    m.Result = (IntPtr)HTTOPLEFT;
        //                else if (vPoint.Y >= ClientSize.Height - 5)
        //                    m.Result = (IntPtr)HTBOTTOMLEFT;
        //                else m.Result = (IntPtr)HTLEFT;
        //            else if (vPoint.X >= ClientSize.Width - 5)
        //                if (vPoint.Y <= 5)
        //                    m.Result = (IntPtr)HTTOPRIGHT;
        //                else if (vPoint.Y >= ClientSize.Height - 5)
        //                    m.Result = (IntPtr)HTBOTTOMRIGHT;
        //                else m.Result = (IntPtr)HTRIGHT;
        //            else if (vPoint.Y <= 5)
        //                m.Result = (IntPtr)HTTOP;
        //            else if (vPoint.Y >= ClientSize.Height - 5)
        //                m.Result = (IntPtr)HTBOTTOM;
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}


        public enum FormSize
        {
            MIN,
            NORMAL,
            MAX,
        }

        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        private void btnEXMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEXMax_Click(object sender, EventArgs e)
        {
            this.MaxNormalSwitch();
        }


        private void MaxNormalSwitch()
        {
            if (this.WindowState == FormWindowState.Maximized)//如果当前状态是最大化状态 则窗体需要恢复默认大小
            {
                this.WindowState = FormWindowState.Normal;
                //
                this.btnEXMax.DefaultImage = global::FormEx.Properties.Resources.Max_Normal;
            }
            else
            {
                //防止遮挡任务栏                
                this.MaximumSize = new Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
                //最大化图标切换
                this.btnEXMax.DefaultImage = global::FormEx.Properties.Resources.Max;
            }
            this.Invalidate();//使重绘
        }

        private void btnEXClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region 移动窗体

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0XA1;   //.定义鼠標左鍵按下
        private const int HTCAPTION = 2;

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);

            //为当前的应用程序释放鼠标捕获
            //ReleaseCapture();
            //发送消息﹐让系統误以为在标题栏上按下鼠标
            //SendMessage((int)this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion




        private void titleBar_Resize(object sender, EventArgs e)
        {         
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {        
            this.Region = null;
           
            SetWindowRegion();

             base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {         
            DrawTitleBar();
            base.OnPaint(e);
        }
        /// <summary>
        /// 设置窗体的Region
        /// </summary>
        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height); 
            //switch (this.StartPosition)
            //{
            //    case FormStartPosition.Manual:
            //        break;
            //    case FormStartPosition.CenterScreen:
            //       Rectangle screenRect= Screen.GetBounds(this);
            //        int locationX = screenRect.Width / 2 - this.Width / 2;
            //        int locationY = screenRect.Height / 2 - this.Height / 2;
            //        rect= new Rectangle(locationX, locationY, this.Width, this.Height);
            //        break;
            //    case FormStartPosition.WindowsDefaultLocation:
            //        break;
            //    case FormStartPosition.WindowsDefaultBounds:
            //        break;
            //    case FormStartPosition.CenterParent:
            //        break;
            //    default:
            //        break;
            //}
         
            FormPath = GetRoundedRectPath(rect, 10);
          
            this.Region = new Region(FormPath);

        }

        private void DrawTitleBar()
        {
            SolidBrush solidBrush = new SolidBrush(titleBarColor);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(solidBrush,new Rectangle(0,0,this.Width,35));

        }

        /// <summary>
        /// 绘制圆角路径
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }

        private void titleBar_DoubleClick(object sender, EventArgs e)
        {
            MaxNormalSwitch();
        }
    }
}
