using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridTest1
{
    public partial class Form1 : Form
    {
        private Line line = new Line();
        public Form1()
        {
            InitializeComponent();
            line.Changed += DrawLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = line;
        }

        private void DrawLine()
        {
            Graphics g = groupBox1.CreateGraphics();
            g.Clear(groupBox1.BackColor);
            using (Pen pen = new Pen(line.LineColor,5))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;//实线
                g.DrawLine(pen, new Point(line.StartPoint.PointX, line.StartPoint.PointY),
              
            }
        }
    }
}
