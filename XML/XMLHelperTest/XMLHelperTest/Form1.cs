using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using CommonModules;


namespace XMLHelperTest
{
    public partial class Form1 : Form
    {
       private  CommonModules.XML.XmlHelper xmlHelper;
        public Form1()
        {
            InitializeComponent();
            xmlHelper = new CommonModules.XML.XmlHelper("Axis2.cfg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region 节点值操作

        private void button1_Click(object sender, EventArgs e)
        {
            string xPath = tbx_XPath.Text;
            if (!string.IsNullOrEmpty(xPath))
            {
                try
                {
                   string value= xmlHelper.GetValue(xPath);
                    tbx_Value.Text = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 节点属性操作

        private void button2_Click(object sender, EventArgs e)
        {
            string xPath = tbx_XPath.Text;
            string attributeName = tbx_Attribute.Text;
            if (!string.IsNullOrEmpty(xPath) && !string.IsNullOrEmpty(attributeName))
            {
                try
                {
                    string value = xmlHelper.GetAttributeValue(xPath, attributeName);
                    tbx_Value.Text = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            string xPath = tbx_XPath.Text;
            if (!string.IsNullOrEmpty(xPath))
            {
               XmlNode node= xmlHelper.GetNode(xPath);
                Uri baseURI = new Uri(node.BaseURI);
               
                MessageBox.Show(System.IO.Path.GetFullPath(baseURI.AbsolutePath));
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string xPath = tbx_XPath.Text;
            if (string.IsNullOrEmpty(xPath)) return;
            try
            {
                xmlHelper.DeleteNode(xPath);
                xmlHelper.Save();

                MessageBox.Show("删除节点成功！");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Axis2.cfg");
            XmlNode node = doc.SelectSingleNode("/SmartMac/Devices/Device/Signals/Signal[@name='ELP']");
            if (node != null)
            {
                node.ParentNode.RemoveChild(node);
            }
            doc.Save("Axis2.cfg");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XmlElement node = xmlHelper.XMLDoc.CreateElement("Signal");
            XmlAttribute attribute = xmlHelper.XMLDoc.CreateAttribute("name");
            attribute.Value = "ELP";
            node.Attributes.Append(attribute);
            XmlNode xmlNode = xmlHelper.GetNode("/SmartMac/Devices/Device/Signals");
            xmlNode.AppendChild(node);
            xmlHelper.Save();
        }
    }
}
