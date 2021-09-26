using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareSecurityVerification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string str=  Security.sFingerPrint;
            //  MessageBox.Show(str);

            tbx_UUID.Text = Security.UUID();
            tbx_CPUID.Text = Security.CpuId();
            tbx_BIOSID.Text = Security.BiosId();
            tbx_MainBoardID.Text = Security.BaseId();
            tbx_HardDiskID.Text = Security.DiskId();
            tbx_VideoID.Text = Security.VideoId();
            tbx_MacID.Text = Security.MacId();
        }
    }
}
