using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerializeTest
{

    /// <summary>
    /// 序列化测试
    /// </summary>
    public partial class Form1 : Form
    {
        private SerializeObjInfoCtrl serialize_Bit;
        private SerializeObjInfoCtrl serialize_XML;
        private SerializeObjInfoCtrl serialize_Json;

        public Form1()
        {
            InitializeComponent();
            serialize_Bit = new SerializeObjInfoCtrl();
            serialize_XML = new SerializeObjInfoCtrl();
            serialize_Json = new SerializeObjInfoCtrl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(serialize_Bit);
            serialize_Bit.Dock = DockStyle.Fill;

            groupBox2.Controls.Add(serialize_XML);
            serialize_XML.Dock = DockStyle.Fill;

            groupBox3.Controls.Add(serialize_Json);
            serialize_Json.Dock = DockStyle.Fill;

            InitializeObj();
        }

        /// <summary>
        /// 初始化对象
        /// </summary>
        private void InitializeObj()
        {
            serialize_Bit.imagePath =System.Environment.CurrentDirectory+ @"\Image\image1.png";
            serialize_Bit.filePath = System.Environment.CurrentDirectory + @"\File\File1.ccdq";
            serialize_Bit.serializeType = SerializeTypeEnum.BIT;

            serialize_XML.imagePath = System.Environment.CurrentDirectory + @"\Image\image2.png";
            serialize_XML.filePath = System.Environment.CurrentDirectory + @"\File\File2.ccdq";
            serialize_XML.serializeType = SerializeTypeEnum.XML;

            serialize_Json.imagePath = System.Environment.CurrentDirectory + @"\Image\image3.png";
            serialize_Json.filePath = System.Environment.CurrentDirectory + @"\File\File3.ccdq";
            serialize_Json.serializeType = SerializeTypeEnum.JSON;
        }
    }
}
