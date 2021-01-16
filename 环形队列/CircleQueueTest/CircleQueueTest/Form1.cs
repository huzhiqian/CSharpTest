using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace CircleQueueTest
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer _timer;
        private CircleQueue<int> circleQueue;
        public Form1()
        {
            InitializeComponent();
            circleQueue = new CircleQueue<int>(10);
            _timer = new System.Timers.Timer();
            _timer.Interval = 100;
            _timer.Elapsed += ShowQueueInfo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();

            circleQueue.Dispose();
        }


        #region 入队
        private void btn_Enqueue_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (int.TryParse(textBox1.Text, out count) && count>0)
            {
                EnqueueFun(count);
            }
        }
        int val = 0;
        private void EnqueueFun(int count)
        {
            System.Threading.Tasks.Task enTask = new System.Threading.Tasks.Task(
                new Action(()=>
                {
                    for (int i = 0; i < count; i++)
                    {
                        circleQueue.EnQueue(val);
                        ShowListInfo(lst_EnqueueInfo,$"元素{val}入队");
                        val++;
                    }
                }));
            enTask.Start();
        }
        #endregion


        #region 出队

        private void btn_Dequeue_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (int.TryParse(textBox2.Text, out count) && count > 0)
            {
                DequeueFun(count);
            }
        }

        private void DequeueFun(int count)
        {
            System.Threading.Tasks.Task deTask = new System.Threading.Tasks.Task(
                new Action(()=> 
                {
                    for (int i = 0; i < count; i++)
                    {
                        ShowListInfo(lst_DequeueInfo ,$"元素{circleQueue.DeQueue()}出队");
                    }
                }));
            deTask.Start();
        }

        #endregion


        private void ShowQueueInfo(object sender, ElapsedEventArgs e)
        {
            ShowLabelInfo(lbl_queueLength,circleQueue.Length.ToString());
            ShowLabelInfo(lbl_queueHead, circleQueue.Head.ToString());
            ShowLabelInfo(lbl_QueueTail, circleQueue.Tail.ToString());
        }

        private delegate void ShowLabelTextInfoCallBack(Label lbl, string info);

        private void ShowLabelInfo(Label lbl, string info)
        {
            if (lbl.InvokeRequired)
            {
                ShowLabelTextInfoCallBack callBack = new ShowLabelTextInfoCallBack(ShowLabelInfo);
                lbl.Invoke(callBack, lbl, info);
                return;
            }
            else
            {
                lbl.Text = info;

            }
        }

        private delegate void ShowListInfoCallBack(ListBox lst,string info);

        private void ShowListInfo(ListBox lst, string info)
        {
            if (lst.InvokeRequired)
            {
                ShowListInfoCallBack callback = new ShowListInfoCallBack(ShowListInfo);
                lst.Invoke(callback, lst, info);
                return;
            }
            else
            {
                if (lst.Items.Count > 200)
                    lst.Items.RemoveAt(0);
                string str = DateTime.Now.ToString("HH:mm:ss.fff") + "  " + info;
                lst.Items.Add(str);
                lst.SelectedItem = str;
            }
        }

        private void btn_TravelQueue_Click(object sender, EventArgs e)
        {
            circleQueue.TravelQueue();
        }
    }
}
