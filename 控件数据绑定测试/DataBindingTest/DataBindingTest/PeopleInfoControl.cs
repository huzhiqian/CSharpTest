using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBindingTest
{
    public partial class PeopleInfoControl : UserControl
    {
        public PeopleInfoControl()
        {
            InitializeComponent();
        }


        public IPeopleInfo DataBindingObj
        {
            set {
                this.tbx_Name.DataBindings.Add("Text",value,"Name");
                this.tbx_Age.DataBindings.Add("Text", value, "Age",true, DataSourceUpdateMode.OnValidation,null, "0岁");
                this.cmb_Sex.DataBindings.Add("Text",value,"Sex");
                this.tbx_Address.DataBindings.Add("Text", value, "Address");
            }
        }

       
    }
}
