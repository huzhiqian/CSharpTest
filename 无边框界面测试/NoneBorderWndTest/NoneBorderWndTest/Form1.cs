using FormEx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoneBorderWndTest
{
    public partial class Form1 : NBFormEx
    {
        private System.Threading.Thread thread ;
        public Form1():base()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            thread = new System.Threading.Thread(o=>TestFunc());
            thread.IsBackground = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NBFormEx nBFormEx = new NBFormEx();
            nBFormEx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxEx.ShowDialog("准备放料时未检测到负压信号，可能是送料过程中物料掉了！准备放料时未检测到负压信号，可能是送料过程中物料掉了！准备放料时未检测到负压信号，可能是送料过程中物料掉了！", "警告");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thread.Start();
        }

        int i=0;
        private void TestFunc()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(2);
                for ( i = 0; i < 20; i++)
                {
                    System.Threading.Thread.Sleep(500);
                    if (i == 10)
                    {
                        if (MessageBoxEx.ShowDialog($"当前值为：{i}", "提示") == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                if (i == 19)
                {
                    i = 0;
                }
                continue;
            }
        }
    }
}
