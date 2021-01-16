using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewNotifyControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CommonModules.Notifier.NotifyListView listView = new CommonModules.Notifier.NotifyListView(listView1);
            CommonModules.Notifier.NotifyHelper.NotifyBoard = listView;
            listView.MaxDisplayCount = 100;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case -1:
                    return;
                case 0:
                    CommonModules.Notifier.NotifyHelper.Notify( CommonModules.Notifier.NotifyLevel.DISPLAY
                        ,string.Format("This is a {0} Level Loger.", "Display"));
                    break;
                case 1:
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.ALL
                     , string.Format("This is a {0} Level Loger.", "All"));
                    break;
                case 2:
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.FATAL
                     , string.Format("This is a {0} Level Loger.", "Fatal"));
                    break;
                case 3:
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.ERROR
                     , string.Format("This is a {0} Level Loger.", "Error"));
                    break;
                case 4:
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.WARNING
                     , string.Format("This is a {0} Level Loger.", "Warning"));
                    break;
                case 5:
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.DEBUG
                     , string.Format("This is a {0} Level Loger.", "Debug"));
                    break;
                case 6:
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.INFO
                     , string.Format("This is a {0} Level Loger.", "Info"));
                    break;
                default:
                    break;
            }
        }

     
    }
}
