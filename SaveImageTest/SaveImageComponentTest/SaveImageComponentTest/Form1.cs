using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonModules.SaveImage;

namespace SaveImageComponentTest
{
    public partial class Form1 : Form
    {
        private SaveImageComponent saveImageComponent=null;
        private Bitmap image=null;
        private System.Threading.Thread thread;
        private bool saveImageFlag = false;
        public Form1()
        {
            InitializeComponent();
            image = new Bitmap("SrcImage.bmp");
            thread = new System.Threading.Thread(SaveImageThreadFunc);
            thread.IsBackground = true;
            saveImageComponent = new SaveImageComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveImageEditor1.Subject = saveImageComponent;
            thread.Start();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            saveImageFlag = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            saveImageFlag = false;
        }

        private void SaveImageThreadFunc()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                if (saveImageFlag)
                {
                    saveImageComponent.SaveImage(image,"img");
                }
            }
        }
    }
}
