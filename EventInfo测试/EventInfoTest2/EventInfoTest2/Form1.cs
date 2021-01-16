using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;

namespace EventInfoTest2
{
    /// <summary>
    /// 动态绑定事件和解绑事件
    /// </summary>
    public partial class Form1 : Form
    {
        private TestClass testClass = new TestClass();
        private ArrayList source= new ArrayList();
        public Form1()
        {
            InitializeComponent();
          
        }

        /// <summary>
        /// 动态绑定事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (AddEvent(button1, testClass))
            {
                MessageBox.Show("绑定成功！");
            }
        }

        /// <summary>
        /// 动态解绑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            RemoveEvent(button1, testClass);
        }


        private bool AddEvent(object o,object target)
        {
            try
            {
                EventInfo[] events = o.GetType().GetEvents();
                foreach (EventInfo eventInfo in events)
                {
                    if (eventInfo.Name == "Click")
                    {
                        eventInfo.AddEventHandler(o,Delegate.CreateDelegate(eventInfo.EventHandlerType,target,"ClickEvent"));
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add an event for " + o.GetType().Name + " because of the following error: " + ex.Message);
            }
            return false;
        }


        private void RemoveEvent(object o,object target)
        {
            try
            {
                EventInfo[] events = o.GetType().GetEvents();
                EventInfo[] array = events;
                int num = 0;
                EventInfo eventInfo;
                while (true)
                {
                    if (num >= array.Length)
                    {
                        return;
                    }
                    eventInfo = array[num];
                    if (eventInfo.Name == "Changed")
                    {
                        break;
                    }
                    num++;
                }
                eventInfo.RemoveEventHandler(o,Delegate.CreateDelegate(eventInfo.EventHandlerType, target, "ClickEvent"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remome an event for " + o.GetType().Name + " because of the following error: " + ex.Message);
            }
        }
    }

   
}

public class TestClass
{
    public  void ClickEvent(object sender,EventArgs e)
    {
        MessageBox.Show("Button Click!");
    }
}


