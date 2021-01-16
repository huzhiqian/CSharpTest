using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatePatternTest3
{
    public partial class Form1 : Form
    {
        private MotionSystem.MotionSystem motionSystem = MotionSystem.MotionSystem.GetMotionSystemINstance();
        public Form1()
        {
            InitializeComponent();
            motionSystem.Context.StartMachineState.Module2Application.Context.ImageProcessState.ImageProcessComplete += ImageProcessCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            motionSystem.ResetMachine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            motionSystem.StartMachine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            motionSystem.StopMachine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            motionSystem.EMGStopMachine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CommonModules.Notifier.NotifyHelper.NotifyBoard = new CommonModules.Notifier.NotifyTextBox(textBox1);
            CommonModules.Notifier.NotifyHelper.NotifyBoard.MaxDisplayCount = 50;
        }

        private void ImageProcessCompleted(bool result, Bitmap img)
        {
            pictureBox1.Invoke(new Action(() =>
            {
                pictureBox1.Image = img;
            }));

            label1.Invoke(new Action(() =>
            {
                if (result)
                {
                    label1.Text = "OK";
                    label1.BackColor = Color.Green;
                }
                else
                {
                    label1.Text = "NG";
                    label1.BackColor = Color.Red;
                }
            }));

        }
    }
}
