using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBindingTest
{
    public partial class SettingsForm : Form
    {
        private PeopleInfo peopleInfo = null;
        public SettingsForm(IPeopleInfo _peopleInfo)
        {
            InitializeComponent();
            peopleInfo = _peopleInfo as PeopleInfo;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.peopleInfoControl1.DataBindingObj = peopleInfo;
        }
    }
}
