using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private int insertCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent & ColumnHeaderAutoResizeStyle.HeaderSize);

            ListViewItem item = new ListViewItem();
            item.UseItemStyleForSubItems = false;
            item.Text = DateTime.Now.ToString("HH:mm:ss.fff");
            item.SubItems.Add("Info");
            item.SubItems.Add(textBox1.Text);
            item.SubItems[1].BackColor = Color.Green;
            listView1.Items.Add(item);
            insertCount++;
            if (insertCount == 1)
                AutoResizeColumnWidth(listView1);
            else
                AutoResizeColumnWidth(listView1, item);
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();
            listView1.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 1)
            {
                listView1.BeginUpdate();
                listView1.Items.RemoveAt(0);
                listView1.EndUpdate();

            }
        }

        private void AutoResizeColumnWidth(ListView lv, ListViewItem item)
        {
            int maxWidth = 0;
            int width = 0;
            Graphics graphics = lv.CreateGraphics();
            Font font = lv.Font;

            int count = lv.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                string str = lv.Columns[i].Text;
                maxWidth = lv.Columns[i].Width;
                width = (int)graphics.MeasureString(str, font).Width;
                if (width > maxWidth)
                {
                    lv.Columns[i].Width = width;
                }
            }
        }


        private void AutoResizeColumnWidth(ListView lv)
        {
            int count = lv.Columns.Count;
            int maxWidth = 0;

            Graphics graphics = lv.CreateGraphics();
            Font font = lv.Font;
            ListView.ListViewItemCollection items = lv.Items;

            string str;
            int width;
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);//先自适应列头宽度
            for (int i = 0; i < count; i++)
            {
                str = lv.Columns[i].Text;
                maxWidth = lv.Columns[i].Width;

                foreach (ListViewItem item in items)
                {
                    str = item.SubItems[i].Text;
                    width = (int)graphics.MeasureString(str, font).Width;
                    if (width > maxWidth)
                    {
                        maxWidth = width;
                    }
                }
                lv.Columns[i].Width = maxWidth;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitListview();
        }

        /// <summary>
        /// 初始化ListView
        /// </summary>
        private void InitListview()
        {
            //移除ListView中现有列
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new Action(() =>
                {
                    listView1.Columns.Clear();
                    //添加新的列
                    ListviewAddNewColumns();
                }));
            }
            else
            {
                listView1.Columns.Clear();
                //添加新的列
                ListviewAddNewColumns();
            }
        }

        private void ListviewAddNewColumns()
        {
            listView1.Columns.Add("Time", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Level", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Info", 120, HorizontalAlignment.Left);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
