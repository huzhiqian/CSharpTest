using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            groupBox1.Enabled = false;
            btn_DeleteNode.Enabled = false;

        }


        //创建根节点
        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_RootValue.Text.Trim()))
            {
                MessageBox.Show("根节点值不能为空！");
                return;
            }
            treeView1.Nodes.Add(tbx_RootValue.Text.Trim());
            tbx_RootValue.Text = "";
            groupBox1.Enabled = true;
            btn_DeleteNode.Enabled = true;
        }

        /// <summary>
        /// 创建子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddChildNode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_ChildNodeValue.Text.Trim()))
            {
                MessageBox.Show("子节点值不能为空！");
                return;
            }
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("请选择要添加字节点的根节点！");
                return;
            }
            treeView1.SelectedNode.Nodes.Add(tbx_ChildNodeValue.Text.Trim());
            tbx_ChildNodeValue.Text = "";
            treeView1.ExpandAll();

        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteNode_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            tbx_SelectNodeName.Text = treeView1.SelectedNode.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
