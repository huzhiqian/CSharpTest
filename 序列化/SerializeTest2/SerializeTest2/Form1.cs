using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeTest2
{
    public partial class Form1 : Form
    {
        private MainObject mainObj;

        public Form1()
        {
            InitializeComponent();
            mainObj = new MainObject();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //显示数据
            tbx_main_Int.Text = mainObj.IntValue.ToString();
            tbx_main_Double.Text = mainObj.DoubleValue.ToString();
            tbx_main_String.Text = mainObj.StringValue;

            tbx_Inner_Int.Text = mainObj.myInnerObj.IntValue.ToString();
            tbx_Inner_Double.Text = mainObj.myInnerObj.DoubleValue.ToString();
            tbx_Inner_String.Text = mainObj.myInnerObj.StringValue;

        }


        #region SetValue

        private void tbx_main_Int_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainObj == null) return;
            if (e.KeyCode == Keys.Enter)
            {
                int temp = 0;
                TextBox tbx = sender as TextBox;
                if (int.TryParse(tbx.Text, out temp))
                    mainObj.IntValue = temp;
            }
        }

        private void tbx_main_Double_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainObj == null) return;
            if (e.KeyCode == Keys.Enter)
            {
                double temp = 0;
                TextBox tbx = sender as TextBox;
                if (double.TryParse(tbx.Text, out temp))
                    mainObj.DoubleValue = temp;
            }
        }

        private void tbx_main_String_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainObj == null) return;
            if (e.KeyCode == Keys.Enter)
            {
                TextBox tbx = sender as TextBox;
                mainObj.StringValue = tbx.Text;
            }
        }

        private void tbx_Inner_Int_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainObj == null) return;
            if (e.KeyCode == Keys.Enter)
            {
                int temp = 0;
                TextBox tbx = sender as TextBox;
                if (int.TryParse(tbx.Text, out temp))
                    mainObj.myInnerObj.IntValue = temp;
            }
        }

        private void tbx_Inner_Double_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainObj == null) return;
            if (e.KeyCode == Keys.Enter)
            {
                double temp = 0;
                TextBox tbx = sender as TextBox;
                if (double.TryParse(tbx.Text, out temp))
                    mainObj.myInnerObj.DoubleValue = temp;
            }
        }

        private void tbx_Inner_String_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainObj == null) return;
            if (e.KeyCode == Keys.Enter)
            {
                TextBox tbx = sender as TextBox;
                mainObj.myInnerObj.StringValue = tbx.Text;
            }
        }

        #endregion

        #region 序列化

        public void SerializeObj()
        {
            FileStream fileStream = File.Create(System.Environment.CurrentDirectory +@"\Data\Test.tsd");
            try
            {
                IFormatter formatter = (IFormatter)Activator.CreateInstance
                    (typeof(BinaryFormatter)); //创建格式化器
                formatter.Context = new StreamingContext
                    (StreamingContextStates.File | StreamingContextStates.Persistence);
                formatter.Serialize(fileStream, mainObj);

            }
            finally
            {
                if (fileStream != null)
                {
                    ((IDisposable)fileStream).Dispose();
                }
            }
        }

        #endregion

        #region 反序列化

        private void DeserializeObj()
        {
            FileStream fileStream = File.OpenRead(System.Environment.CurrentDirectory + @"\Data\Test.tsd");
            try
            {
                IFormatter formatter = (IFormatter)Activator.CreateInstance
               (typeof(BinaryFormatter));
                formatter.Context = new StreamingContext
                    (StreamingContextStates.File | StreamingContextStates.Persistence);
                fileStream.Position = 0;
                MainObject obj = (MainObject)formatter.Deserialize(fileStream);
                mainObj =  obj;
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

        #endregion

        private void btn_Deserialize_Click(object sender, EventArgs e)
        {
            DeserializeObj();
            //显示数据
            tbx_main_Int.Text = mainObj.IntValue.ToString();
            tbx_main_Double.Text = mainObj.DoubleValue.ToString();
            tbx_main_String.Text = mainObj.StringValue;

            tbx_Inner_Int.Text = mainObj.myInnerObj.IntValue.ToString();
            tbx_Inner_Double.Text = mainObj.myInnerObj.DoubleValue.ToString();
            tbx_Inner_String.Text = mainObj.myInnerObj.StringValue;

        }

        private void btn_Serialize_Click(object sender, EventArgs e)
        {
            SerializeObj();
        }
    }
}
