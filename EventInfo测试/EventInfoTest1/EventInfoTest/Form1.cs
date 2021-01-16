using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventInfoTest
{
    /// <summary>
    /// 该测试主要测试EventInfo中的一些属性，以及如何获取对象的EventInfo信息
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllEvent(this);
        }

        private void ShowAllEvent(object o)
        {
            System.Reflection.EventInfo[] events = o.GetType().GetEvents();
            listBox1.Items.Clear();
            foreach (System.Reflection.EventInfo eventInfo in events)
            {
                listBox1.Items.Add(string.Format("事件名称：{0},事件基础委托类型:{1}",eventInfo.Name,eventInfo.EventHandlerType));
            }
        }
    }
}
