using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridTest3
{
    public partial class ImageViewer : UserControl
    {
        private Bitmap image;
        public ImageViewer(Bitmap _image)
        {
            InitializeComponent();
            image = _image;
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
        }

        public Bitmap Image
        {
            get { return image; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "选择图片";
            openFileDialog.Filter = "Image|*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                Bitmap bitmap = new Bitmap(fileName);
                image = bitmap;
                pictureBox1.Image = image;
            }

        }
    }
}
