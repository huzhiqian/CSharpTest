using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatePatternTest2
{
    public partial class Form1 : Form
    {
        private MachineContext machineContext=null;
        private System.Threading.Thread thread=null;
        public Form1()
        {
            InitializeComponent();
            machineContext = new MachineContext();
            thread = new System.Threading.Thread(MachineActionFunc);
            thread.IsBackground = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            machineContext.InfoControl = this.lst_Info;
            thread.Start();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            var startState = new ConcreteState.StartState();
            startState.DisplayAction = SetInfo;
            machineContext.SetState(startState,MachineStateConstant.Running);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stopState = new ConcreteState.StopState();
            machineContext.SetState(stopState,MachineStateConstant.Stop);

        }

        private void MachineActionFunc()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(2);
                if (machineContext !=null)
                {
                    machineContext.DoAction();
                }
            }
        }

        private void SetInfo(string info)
        {
            lst_Info.Invoke(new Action(() =>
            {
                if (lst_Info.Items.Count > 100)
                    lst_Info.Items.RemoveAt(0);

                lst_Info.Items.Add(string.Format($"{DateTime.Now.ToString("mm:ss.fff")}  {info}"));
            }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resetState =new ConcreteState.ResetState();
            machineContext.SetState(resetState,MachineStateConstant.UnReset);
        }
    }
}
