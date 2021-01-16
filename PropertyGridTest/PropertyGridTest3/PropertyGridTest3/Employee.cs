using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Design;


//**********************************************
//文件名：Employee
//命名空间：PropertyGridTest3
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/4 16:35:23
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest3
{
   public class Employee:Person
    {
        private Bitmap m_identificationPhoto = null;
        private List<string> m_Companies = new List<string>();
        private Hobbies m_Hobbies = new Hobbies();
        private int m_id = 1;

        private object testValue = new object();
        private List<int> intValues = new List<int>();
        private List<bool> boolValues = new List<bool>();

        private Dictionary<int, int> keyValuePairs= new Dictionary<int, int>();
        #region 构造函数

        public Employee()
        {
       
        }

        #endregion


        #region 属性

     
        [Browsable(true)]
        [CategoryAttribute("员工信息"), DescriptionAttribute("证件照"), ReadOnlyAttribute(false)]
        public Bitmap Photo
        {
            get { return m_identificationPhoto; }
            set { m_identificationPhoto = value; }
        }

        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [Browsable(true)]
        [CategoryAttribute("员工信息"), DescriptionAttribute("曾供职公司"), ReadOnlyAttribute(false)]
        public List<string> Companies
        {
            get { return m_Companies; }
            set { m_Companies = value; }
        }

        [TypeConverter(typeof(HobbiesConverter))]
        [Editor(typeof(HobbiesCtrlEditor),typeof(UITypeEditor))]
        [Browsable(true)]
        [DisplayName("业余爱好")]
        [CategoryAttribute("其他"), DescriptionAttribute("业余爱好"), ReadOnlyAttribute(false)]
        public Hobbies Hobbies
        {
            get { return m_Hobbies; }
            set { m_Hobbies = value; }
        }

        [Browsable(true)]
        [CategoryAttribute("员工信息"), DescriptionAttribute("员工编号"), ReadOnlyAttribute(false)]
        public int ID
        {
            get { return m_id; }
            set { m_id = value; }
        }

        [TypeConverter(typeof(ImageConverter))]
        [Editor(typeof(ImageViewerEditor), typeof(UITypeEditor))]
        [Browsable(true)]
        public object TestValue
        {
            get { return testValue; }
            set { testValue = value; }
        }

        [Browsable(true)]
        public List<int> IntValues
        {
            get { return intValues; }
            set { intValues = value; }
        }

        [Browsable(true)]
        public List<bool> BoolValues
        {
            get { return boolValues; }
            set { boolValues = value; }
        }

        [Browsable(true)]
        public Dictionary<int, int> KeyValuePairs
        {
            get { return keyValuePairs; }
            set { keyValuePairs = value; }
        }
        #endregion

        #region 公共方法



        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }


}
