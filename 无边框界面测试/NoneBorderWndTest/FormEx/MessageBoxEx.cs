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
    public partial class MessageBoxEx : Form
    {

        #region Ctor

        public MessageBoxEx()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);//添加阴影效果
        }

        public MessageBoxEx(string msgInfo) : this()
        {
            _messageInfo = msgInfo;
        }

        public MessageBoxEx(string msgInfo, string title) : this()
        {
            _messageInfo = msgInfo;
            _titleText = title;
        }

        #endregion


        private void MessageBoxEx_Load(object sender, EventArgs e)
        {
            if (_messageInfo.Trim() != "")
            {
                lbl_MessageInfo.Text = _messageInfo;
                lbl_Title.Text = _titleText;
            }
        }

        #region 属性

        private string _titleText = "提示";

        /// <summary>
        /// 获取或设置MessageBox标题
        /// </summary>
        public string TitleText
        {
            get { return _titleText; }
            set { _titleText = value; }
        }

        private string _messageInfo = "暂无信息";

        /// <summary>
        /// 获取或设置提示信息
        /// </summary>
        public string MessageInfo
        {
            get { return _messageInfo; }
            set { _messageInfo = value; }
        }
        #endregion

        //const int WM_NCHITTEST = 0x0084;
        //const int HTLEFT = 10;      //左边界
        //const int HTRIGHT = 11;     //右边界
        //const int HTTOP = 12;       //上边界
        //const int HTTOPLEFT = 13;   //左上角
        //const int HTTOPRIGHT = 14;  //右上角
        //const int HTBOTTOM = 15;    //下边界
        //const int HTBOTTOMLEFT = 0x10;    //左下角
        //const int HTBOTTOMRIGHT = 17;     //右下角

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
        //        case 0x0201://鼠标左键按下的消息 
        //            m.Msg = 0x00A1;//更改消息为非客户区按下鼠标 
        //            m.LParam = IntPtr.Zero;//默认值 
        //            m.WParam = new IntPtr(2);//鼠标放在标题栏内 
        //            base.WndProc(ref m);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}

        #region 阴影效果

        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        #endregion

        #region 移动窗体

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0XA1;   //.定义鼠標左鍵按下
        private const int HTCAPTION = 2;

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //为当前的应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息﹐让系統误以为在标题栏上按下鼠标
            SendMessage((int)this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        #endregion

        private void btnEXMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MessageBoxEx_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
            this.Invalidate();
        }

        /// <summary>
        /// 设置窗体的Region
        /// </summary>
        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 10);
            this.Region = new Region(FormPath);

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

        #region 公共方法


        public static DialogResult ShowDialog(string msg, string title)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(msg, title);
            messageBoxEx.StartPosition = FormStartPosition.CenterScreen;
            return messageBoxEx.ShowDialog();
        }

        public static DialogResult ShowDialog(string msg, string title, IWin32Window owner)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(msg, title);
            messageBoxEx.StartPosition = FormStartPosition.CenterScreen;
            return messageBoxEx.ShowDialog(owner);
        }

        public static DialogResult ShowDialog(string msg)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(msg);
            messageBoxEx.StartPosition = FormStartPosition.CenterScreen;
            return messageBoxEx.ShowDialog();
        }
        public static DialogResult ShowDialog(string msg, IWin32Window owner)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(msg);
            messageBoxEx.StartPosition = FormStartPosition.CenterScreen;
            return messageBoxEx.ShowDialog(owner);
        }

        public static void Show(string msg, string title)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(msg, title);
            messageBoxEx.StartPosition = FormStartPosition.CenterScreen;
            messageBoxEx.Show();
        }

        public static void Show(string msg)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(msg);
            messageBoxEx.StartPosition = FormStartPosition.CenterScreen;
            messageBoxEx.Show();
        }
        #endregion

        private void btnEXClose_Click(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.Close();
            }
        }
    }
}
