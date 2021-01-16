using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using HalconDotNet;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Diagnostics;

namespace SerializeTest
{
    public partial class SerializeObjInfoCtrl : UserControl
    {
        public string filePath;
        public string imagePath;
        public SerializeTest.SerializeTypeEnum serializeType = SerializeTypeEnum.BIT;
        public CImageInfo myImageObj;
        public SerializeObjInfoCtrl()
        {
            InitializeComponent();

        }


        /// <summary>
        /// 序列化保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SerializeSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                ShowListInfo("序列化路径为空！");
                return;
            }
            ShowListInfo("开始执行序列化");
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            switch (serializeType)
            {
                case SerializeTypeEnum.BIT:
                    BinarySerialize();
                    break;
                case SerializeTypeEnum.XML:
                    SoapSerialize();
                    break;
                case SerializeTypeEnum.JSON:
                    JsonSerialize();
                    break;
                default:
                    break;
            }
            sw.Stop();
            ShowListInfo("序列化完成，耗时：" + sw.ElapsedMilliseconds.ToString());
        }

        /// <summary>
        /// 反序列化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeserializeLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath) == false)
            {
                ShowListInfo("文件不存在，将创建默认实例！");
                CreateDefaultInstance();
                ShowInstanceInfo();
                return;
            }
            ShowListInfo("开始执行反序列化");
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            if (myImageObj != null)
                myImageObj = null;
            switch (serializeType)
            {
                case SerializeTypeEnum.BIT:
                    BinaryDeserialize();
                    break;
                case SerializeTypeEnum.XML:
                    SoapDeserialize();
                    break;
                case SerializeTypeEnum.JSON:

                    break;
                default:
                    break;
            }

            // BinaryDeserialize();
            sw.Stop();
            ShowListInfo("序列化完成，耗时：" + sw.ElapsedMilliseconds.ToString());
            ShowInstanceInfo();
        }

        /// <summary>
        /// 创建默认实例
        /// </summary>
        private void CreateDefaultInstance()
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                ShowListInfo("图片路径为空！");
                return;
            }
            if (File.Exists(imagePath) == false)
            {
                ShowListInfo("图片路径不存在！");
                return;
            }
            myImageObj = new CImageInfo();
            myImageObj.CreateTime = DateTime.Now.ToString("hh:MM:ss.fff");
            myImageObj.ImageID = 0;
            myImageObj.ImageName = "TestImage";
            myImageObj.SerializeType = SerializeTypeEnum.BIT;
            Rectangle rect = hWindowControl1.ImagePart;
            HTuple imagefilepath = imagePath;
            HOperatorSet.ReadImage(out myImageObj.ho_Image, imagefilepath);
           
            HTuple width, height;
            HOperatorSet.GetImageSize(myImageObj.ho_Image, out width, out height);
            rect.X = 0;
            rect.Y = 0;
            rect.Width = width.I;
            rect.Height = height.I;
            hWindowControl1.ImagePart = rect;
        }

        private void ShowListInfo(string info)
        {
            lst_Info.Invoke(new Action(() =>
            {
                StringBuilder sb = new StringBuilder(DateTime.Now.ToString("hh:MM:ss.fff"));
                sb.Append(" :").Append(info);
                lst_Info.Items.Add(sb.ToString());
                lst_Info.SelectedItem = sb.ToString();

                if (lst_Info.Items.Count > 100)
                {
                    lst_Info.Items.RemoveAt(0);
                }
            }));
        }

        /// <summary>
        /// 显示实例信息
        /// </summary>
        private void ShowInstanceInfo()
        {
            try
            {
                //显示图片
                HTuple width, height;
                HOperatorSet.GetImageSize(myImageObj.ho_Image, out width, out height);
                Rectangle rect = hWindowControl1.ImagePart;
                rect.X = 0;
                rect.Y = 0;
                rect.Width = width.I;
                rect.Height = height.I;
                hWindowControl1.ImagePart = rect;
                HOperatorSet.DispObj(myImageObj.ho_Image, hWindowControl1.HalconWindow);
            }
            catch (HalconException hex)
            {
                Console.WriteLine(hex.ToString());
                throw hex;
            }
            tbx_ImageName.Invoke(new Action(() =>
            {
                tbx_ImageName.Text = myImageObj.ImageName;
            }));

            tbx_ImageID.Invoke(new Action(() =>
            {
                tbx_ImageID.Text = myImageObj.ImageID.ToString();
            }));

            tbx_CreateTime.Invoke(new Action(() =>
            {
                tbx_CreateTime.Text = myImageObj.CreateTime;
            }));

            tbx_SerializeType.Invoke(new Action(() =>
            {
                switch (myImageObj.SerializeType)
                {
                    case SerializeTypeEnum.BIT:
                        tbx_SerializeType.Text = "Bit";
                        break;
                    case SerializeTypeEnum.XML:
                        tbx_SerializeType.Text = "XML";
                        break;
                    case SerializeTypeEnum.JSON:
                        tbx_SerializeType.Text = "Json";
                        break;
                    default:
                        tbx_SerializeType.Text = "Bit";
                        break;
                }
            }));
            tbx_HTuple.Invoke(new Action(()=>
            {
                tbx_HTuple.Text = myImageObj.MyValue.ToString();
            }));

        }

        private void tbx_ImageName_Leave(object sender, EventArgs e)
        {
            if (myImageObj == null)
            {
                ShowListInfo("对象为初始化，无法修改");
                return;
            }
            myImageObj.ImageName = tbx_ImageName.Text;
        }

        private void tbx_ImageID_Leave(object sender, EventArgs e)
        {
            if (myImageObj == null)
            {
                ShowListInfo("对象为初始化，无法修改");
                return;
            }
            myImageObj.ImageID = Convert.ToInt32(tbx_ImageID.Text);
        }

        private void tbx_CreateTime_Leave(object sender, EventArgs e)
        {
            if (myImageObj == null)
            {
                ShowListInfo("对象为初始化，无法修改");
                return;
            }
            myImageObj.CreateTime = tbx_CreateTime.Text;
        }

        private void tbx_SerializeType_Leave(object sender, EventArgs e)
        {
            if (myImageObj == null)
            {
                ShowListInfo("对象为初始化，无法修改");
                return;
            }
            switch (tbx_SerializeType.Text)
            {
                case "Bit":
                    myImageObj.SerializeType = SerializeTypeEnum.BIT;
                    break;
                case "XML":
                    myImageObj.SerializeType = SerializeTypeEnum.XML;
                    break;
                case "Json":
                    myImageObj.SerializeType = SerializeTypeEnum.JSON;
                    break;
                default:
                    myImageObj.SerializeType = SerializeTypeEnum.BIT;
                    break;
            }
        }

        /********************************三种格式的序列化********************************************/
        /// <summary>
        /// 二进制序列化器
        /// </summary>
        private void BinarySerialize()
        {
            FileStream fileStream = File.Create(filePath);
            try
            {
                IFormatter formatter = (IFormatter)Activator.CreateInstance
                    (typeof(BinaryFormatter)); //创建格式化器
                formatter.Context = new StreamingContext
                    (StreamingContextStates.File | StreamingContextStates.Persistence);
                formatter.Serialize(fileStream, myImageObj);

            }
            finally
            {
                if (fileStream != null)
                {
                    ((IDisposable)fileStream).Dispose();
                }
            }
        }
        /// <summary>
        /// 二进制反序列化器
        /// </summary>
        private void BinaryDeserialize()
        {
            FileStream fileStream = File.OpenRead(filePath);
            try
            {
                IFormatter formatter = (IFormatter)Activator.CreateInstance
               (typeof(BinaryFormatter));
                formatter.Context = new StreamingContext
                    (StreamingContextStates.File | StreamingContextStates.Persistence);
                fileStream.Position = 0;
                myImageObj = (CImageInfo)formatter.Deserialize(fileStream);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                    fileStream = null;
                }
            }
        }
        /// <summary>
        /// Soap序列化器
        /// </summary>
        private void SoapSerialize()
        {
            FileStream fileStream = File.Create(filePath);
            try
            {
                IFormatter formatter = (IFormatter)Activator.CreateInstance
                    (typeof(SoapFormatter));
                formatter.Context = new StreamingContext
                    (StreamingContextStates.File | StreamingContextStates.Persistence);
                formatter.Serialize(fileStream, myImageObj);
            }
            finally
            {
                if (fileStream != null)
                {
                    ((IDisposable)fileStream).Dispose();
                }
            }

        }
        /// <summary>
        /// Soap反序列化器
        /// </summary>
        private void SoapDeserialize()
        {
            FileStream fileStream = File.OpenRead(filePath);
            try
            {
                IFormatter formatter = (IFormatter)Activator.CreateInstance(typeof(SoapFormatter));
                fileStream.Position = 0;
                myImageObj = (CImageInfo)formatter.Deserialize(fileStream);
            }
            finally
            {
                if (fileStream != null)
                {
                    ((IDisposable)fileStream).Dispose();
                }
            }

        }
        /// <summary>
        /// Json序列化器
        /// </summary>
        private void JsonSerialize()
        {

        }

        /// <summary>
        /// Json反序列化器
        /// </summary>
        private void JsonDeserialize()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "创驰文件(*.ccdq)|*.ccdq";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                MessageBox.Show(filePath);
            }

            saveFileDialog.Dispose();
        }

        private void tbx_HTuple_Leave(object sender, EventArgs e)
        {
            if (myImageObj != null)
            {
                double val=0;
                if (double.TryParse(tbx_HTuple.Text, out val))
                {
                    myImageObj.MyValue = val;
                }
            }
        }

        private void tbx_HTuple_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (myImageObj != null)
                {
                    double val = 0;
                    if (double.TryParse(tbx_HTuple.Text, out val))
                    {
                        myImageObj.MyValue = val;
                    }
                }
            }
        }
    }
}
