using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Runtime.Serialization;
using System.Windows.Forms;


//**********************************************
//文件名：InnerObject1
//命名空间：SerializeTest2
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2019/1/8 16:03:46
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace SerializeTest2
{
    [Serializable]
  public  class InnerObject1:ISerializable
    {

        private int ivalue = 1;
        private double dvalue = 1.0;
        private string svalue = "123";
        private string name = "Test2";

        public InnerObject1(string _name)
        {
            name = _name;
        }

        public InnerObject1(SerializationInfo info, StreamingContext context)
        {
            MessageBox.Show($"{DateTime.Now.ToString("HH:mm:ss.fff")}:Inner_{name} 序列化开始");
            ivalue = info.GetInt32("ivalue");
            dvalue = info.GetDouble("dvalue");
            svalue = info.GetString("svalue");
            name = info.GetString("name");

        }

        public int IntValue
        {
            get { return ivalue; }
            set
            {
                if (value != ivalue)
                {
                    ivalue = value;
                }
            }
        }


        public double DoubleValue
        {
            get { return dvalue; }
            set
            {
                if (dvalue != value)
                {
                    dvalue = value;
                }
            }
        }

        public string StringValue
        {
            get { return svalue; }
            set
            {
                if (svalue != value)
                {
                    svalue = value;
                }
            }
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ivalue", ivalue);
            info.AddValue("dvalue", dvalue);
            info.AddValue("svalue", svalue);
            info.AddValue("name", name);
        }
    }
}
