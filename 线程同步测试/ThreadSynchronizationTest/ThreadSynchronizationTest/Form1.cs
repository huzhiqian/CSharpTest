using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ThreadSynchronizationTest
{
    public partial class Form1 : Form
    {
        private int CountdownTime = 5000;//5秒钟
        private System.Timers.Timer timer = new System.Timers.Timer();
        private AutoResetEvent cam1_AutoReset = new AutoResetEvent(true);
        private AutoResetEvent cam2_AutoReset = new AutoResetEvent(true);
        private AutoResetEvent cam3_AutoReset = new AutoResetEvent(true);
        private AutoResetEvent cam4_AutoReset = new AutoResetEvent(true);
        private bool cam1Complete = false;
        private bool cam2Complete = false;
        private bool cam3Complete = false;
        private bool cam4Complete = false;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 50;
            timer.Elapsed += TimerElapsed;
            cam1_AutoReset.Reset();
            cam2_AutoReset.Reset();
            cam3_AutoReset.Reset();
            cam4_AutoReset.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CommonModules.Notifier.NotifyRichTextBox notifyRichText = new CommonModules.Notifier.NotifyRichTextBox(richTextBox1);
            notifyRichText.MaxDisplayCount = 50;
            CommonModules.Notifier.NotifyHelper.NotifyBoard = notifyRichText;


        }

        private int curSysTick;
        private void btn_TriggerCamera_Click(object sender, EventArgs e)
        {
         
            //出发相机，倒计时定时器
            CountdownTime = 5000;
            CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.INFO,
                "触发相机.");
            label1.Text = CountdownTime.ToString();
            curSysTick = System.Environment.TickCount;
            cam1Complete = false;
            cam2Complete = false;
            cam3Complete = false;
            cam4Complete = false;
            cam1_AutoReset.Reset();
            cam2_AutoReset.Reset();
            cam3_AutoReset.Reset();
            cam4_AutoReset.Reset();
            timer.Enabled = true;
            timer.Start();
            Task.Factory.StartNew(()=> {
                WaitResult();
            });
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (CountdownTime < 50)
            {
                CountdownTime = 0;
                timer.Stop();
                CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.INFO,
                    "倒计时时间到.");

                return;
            }
            label1.Invoke(new Action(() =>
            {
              
                CountdownTime -= (System.Environment.TickCount- curSysTick);
                curSysTick = System.Environment.TickCount;
                label1.Text = CountdownTime.ToString();
            }));
        }

        
        private void WaitResult()
        {
            while (true)
            {
                List<Task> taskList = new List<Task>();
                taskList.Add( Task.Factory.StartNew(() => {
                    if (cam1_AutoReset.WaitOne(5000))
                        cam1Complete = true;
                }));
                taskList.Add( Task.Factory.StartNew(()=> {
                    if (cam2_AutoReset.WaitOne(5000))
                        cam2Complete = true;
                }));
               taskList.Add( Task.Factory.StartNew(()=> {
                    if (cam3_AutoReset.WaitOne(5000))
                        cam3Complete = true;
                }));

                taskList.Add( Task.Factory.StartNew(()=> {
                    if (cam4_AutoReset.WaitOne(5000))
                        cam4Complete = true;
                }));
                Task.WaitAll(taskList.ToArray());

                if (!cam1Complete)
                {
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.ERROR,
                      "相机1超时。");
                }
                if (!cam2Complete)
                {
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.ERROR,
                     "相机2超时。");
                }
                if (!cam3Complete)
                {
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.ERROR,
                    "相机3超时。");
                }
                if (!cam4Complete)
                {
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.ERROR,
                   "相机4超时。");
                }
                return;
            }
        }

        private void btn_Cam1Done_Click(object sender, EventArgs e)
        {
            cam1_AutoReset.Set();
            CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.INFO,
                       "相机1完成。");
        }

        private void btn_Cam2Done_Click(object sender, EventArgs e)
        {
            cam2_AutoReset.Set();
            CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.INFO,
                      "相机2完成。");
        }

        private void btn_Cam3Done_Click(object sender, EventArgs e)
        {
            cam3_AutoReset.Set();
            CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.INFO,
                     "相机3完成。");
        }

        private void btn_Cam5Done_Click(object sender, EventArgs e)
        {
            cam4_AutoReset.Set();
            CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.INFO,
                     "相机4完成。");
        }
    }
}
