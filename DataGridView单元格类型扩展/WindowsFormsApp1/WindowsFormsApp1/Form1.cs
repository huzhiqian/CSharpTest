using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ImageList imageList = new ImageList();
       //DataGridViewTextBoxCell
        public Form1()
        {
            InitializeComponent();
            
            imageList.Images.Add(Properties.Resources.circle_solid_Green);
            imageList.Images.Add(Properties.Resources.circle_solid_Red);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool state = checkBox1.Checked;
           int curIndex= this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[curIndex].Cells[0].Value = state ? imageList.Images[0] : imageList.Images[1];
            this.dataGridView1.Rows[curIndex].Cells[2].Value = 100;
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex == 0) {
                textBox1.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            }
        }
    }
}
