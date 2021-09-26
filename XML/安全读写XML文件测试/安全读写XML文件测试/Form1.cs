using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace 安全读写XML文件测试
{
    public partial class Form1 : Form
    {
        CommonModules.XML.XmlHelper xmlHelper = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CommonModules.Notifier.NotifyListView notifyListView = new CommonModules.Notifier.NotifyListView(this.listViewEx1);
            notifyListView.MaxDisplayCount = 100;
            CommonModules.Notifier.NotifyHelper.NotifyBoard = notifyListView;

            try
            {
                string xmlFileName = "Test.xml";
                xmlHelper = new CommonModules.XML.XmlHelper(xmlFileName);
            }
            catch (Exception ex)
            {
                CommonModules.Notifier.NotifyHelper.Notify( CommonModules.Notifier.NotifyLevel.ERROR,
                    $"打开XML文件出错，错误信息：{ex.Message}",ex);
            }
          
        }

        //读取数据
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlNode node = xmlHelper.GetNode("/Product/ProductInfo");
              string val= node.Attributes["ID"].Value;
                CommonModules.Notifier.NotifyHelper.Notify( CommonModules.Notifier.NotifyLevel.DISPLAY,
                    $"读取到数据：{val}");
            }
            catch (Exception ex)
            {
                CommonModules.Notifier.NotifyHelper.Notify( CommonModules.Notifier.NotifyLevel.ERROR,
                    $"Error:{ex.Message}");
            }
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    string val = textBox1.Text;
                    XmlNode node = xmlHelper.GetNode("/Product/ProductInfo");
                    node.Attributes["ID"].Value = val;
                    xmlHelper.Save();
                }
                catch (Exception ex)
                {
                    CommonModules.Notifier.NotifyHelper.Notify(CommonModules.Notifier.NotifyLevel.ERROR,
                                      $"Error:{ex.Message}");
                }
              
            }
            else {
                MessageBox.Show("数据不能为空!");
            }
        }
    }
}
