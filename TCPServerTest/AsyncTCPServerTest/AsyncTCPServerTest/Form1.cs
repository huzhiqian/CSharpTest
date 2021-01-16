using CommonModules.TCP;
using System;
using System.Windows.Forms;

namespace AsyncTCPServerTest
{
    public partial class Form1 : Form
    {
        private CommonModules.TCP.AsyncTCPServer server;
        public Form1()
        {
            InitializeComponent();
            CommonModules.Notifier.NotifyHelper.NotifyBoard = new CommonModules.Notifier.NotifyTextBox(tbx_LofInfo);

            server = new CommonModules.TCP.AsyncTCPServer(3000);
            server.ClientConnected += ClientConnect;
            server.ClientDisconnect += ClientDisconnect;
            server.ServerReceiveDatagram += ReveiceDatagram;
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            server.BeginListen();
        }

        private void ClientConnect(object sender, TcpClientConnectedEventArgs e)
        {
            foreach (var item in server.Connections)
            {
                CommonModules.ControlSafeOPeration.CtrlSafeOperation.InvokeSafeOperation(listBox1, () =>
                {
                    listBox1.Items.Add(string.Format("{0}:{1}", item.Address[0], item.Port));
                });
               
            }
        }

        private void ClientDisconnect(object sender, TCPClientDisConnectedEventArgs  e)
        {
            CommonModules.ControlSafeOPeration.CtrlSafeOperation.InvokeSafeOperation(listBox1, () =>
            {
                listBox1.Items.Clear();
            });
            foreach (var item in server.Connections)
            {
                CommonModules.ControlSafeOPeration.CtrlSafeOperation.InvokeSafeOperation(listBox1, () =>
                {
                    listBox1.Items.Add(string.Format("{0}:{1}", item.Address[0], item.Port));
                });

            }
        }

        private void ReveiceDatagram(object sender, TCPDatagramReceiveEventArgs<byte[]> e)
        {
            CommonModules.ControlSafeOPeration.CtrlSafeOperation.InvokeSafeOperation(textBox2, () =>
            {
                textBox2.AppendText(string.Format("{0}[{1}]:{2}", e.TcpClient.Address[0].ToString(),
                    e.TcpClient.Port, e.TcpClient.Encoding.GetString(e.DataGram)));
                textBox2.AppendText(System.Environment.NewLine);
            });
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox3.Text;
            if (!string.IsNullOrEmpty(str))
            {
                server.Send(server.Connections[0],str);
            }
        }
    }
}
