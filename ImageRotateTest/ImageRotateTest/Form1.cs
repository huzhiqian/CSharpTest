using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageRotateTest
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
            image = new Bitmap("TestImage.jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
        }

        private void btn_RotateImage_Click(object sender, EventArgs e)
        {
           
            //bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            image.RotateFlip(RotateFlipType.Rotate180FlipNone);
      
            pictureBox1.Image = image;
         

        }
    }
}
