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
    public partial class Form1 : Form
    {
        private PeopleInfo peopleInfo = new PeopleInfo();
        public Form1()
        {
            InitializeComponent();
            this.peopleInfoControl1.DataBindingObj = peopleInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(peopleInfo);
            settingsForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
