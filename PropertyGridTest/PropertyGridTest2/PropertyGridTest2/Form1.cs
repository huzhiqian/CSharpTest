using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridTest2
{
    public partial class Form1 : Form
    {
        private LineSegment lineSegment;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lineSegment = new LineSegment();
            lineSegment.Changed += LineSegmentChaned;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = lineSegment;
        }

        private void LineSegmentChaned()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            using (Pen pen = new Pen(lineSegment.LineColor,5))
            {
                pen.StartCap = lineSegment.StartCap;
                pen.EndCap = lineSegment.EndCap;
                g.DrawLine(pen,new Point(lineSegment.StartPoint.X,lineSegment.StartPoint.Y),
                    new Point(lineSegment.EndPoint.X,lineSegment.EndPoint.Y));
            }
        }
    }
}
