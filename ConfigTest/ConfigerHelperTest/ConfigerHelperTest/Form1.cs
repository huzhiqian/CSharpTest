using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigerHelperTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            object writeValue = null;
            string key = tbx_Write_Key.Text;
            string value = tbx_write_Value.Text;
            if (value.Contains(","))
                writeValue = value.Split(',');
            else
                writeValue = value;
            if (!string.IsNullOrEmpty(key))
            {
                CommonModules.Configer.ConfigHelper.SaveValue(key, writeValue);
            }
            else
                MessageBox.Show("Key值为空！");
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            string key = tbx_Read_Key.Text;
            if (!string.IsNullOrEmpty(key))
            {
                object value = CommonModules.Configer.ConfigHelper.GetValue(key, null);
                if (value != null)
                {
                    if (value is Array)
                    {
                        string strValue = string.Empty;
                        foreach (var item in (Array)value)
                        {
                            strValue += string.Format(",{0}", item);
                        }
                        strValue = strValue.Remove(0, 1);
                        tbx_Read_Value.Text = strValue;
                    }
                    else
                    {
                        tbx_Read_Value.Text = value.ToString();
                    }
                }
            }
            else
                MessageBox.Show("Key值为空！");
        }


        //*****************************************************************************************
        private string key;
        private uint maxThreadCount = 20;
        private List<Task> taskList = new List<Task>();
        private TaskFactory taskFac = new TaskFactory();
        private int value = 1;
        private bool isStart = false;
        private void btn_StaetTest_Click(object sender, EventArgs e)
        {
            //
            key = tbx_Speed_key.Text;
            if (!string.IsNullOrEmpty(key))
            {
                if (!isStart)
                {
                    isStart = true;
                    value = 0;
                    btn_StartTest.Enabled = false;
                    btn_StartTest.BackColor = Color.Green;
                    btn_StopTest.BackColor = Color.White;
                    System.Threading.Thread thread = new System.Threading.Thread(() =>
                    {
                        DoTest();
                    });
                    thread.Start();
                }
            }
        }

        private void btn_StopTest_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                isStart = false;
                btn_StartTest.BackColor = Color.White;
                btn_StopTest.BackColor = Color.Red;
                btn_StartTest.Enabled = true;
            }
        }

        private void DoTest()
        {
            while (isStart)
            {
                System.Threading.Thread.Sleep(100);
                if (taskList.Count > maxThreadCount)
                {
                    Task.WaitAny(taskList.ToArray());
                    taskList = taskList.Where(t => t.Status == TaskStatus.Running).ToList();
                    continue;
                }
                value++;
                taskList.Add(taskFac.StartNew(() =>
                {
                    CommonModules.Configer.ConfigHelper.SaveValue(key, value);
                    ListBoxShowInfo(lbx_WriteData, value.ToString());

  
                    Console.WriteLine("-1");
                }));
                System.Threading.Thread.Sleep(2);
            }
        }

        private void ListBoxShowInfo(ListBox lbx, string value)
        {
            try
            {
                lbx.Invoke(new Action(() =>
                {
                    lbx.Items.Add(value);
                    if (lbx.Items.Count > 20)
                        lbx.Items.RemoveAt(0);
                }));
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
