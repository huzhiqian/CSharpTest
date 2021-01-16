using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "自定义 DataGridView 时间控件列";
            //自定义时间控件单元格。
            CalendarColumn col = new CalendarColumn();
            this.dataGridView1.Columns.Add(col);
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.RowCount = 5;
            int i = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells[0].Value = DateTime.Now;
                row.Cells[1].Value = i.ToString();
                i++;
            }
        }
    }
}