using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPSendTester
{
    public partial class Form1 : Form
    {
        private UdpClient udpSender = new UdpClient(88);

        System.Threading.Thread receiveThread = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            udpSender.Connect(IPAddress.Parse(this.textBox1.Text), Int32.Parse(this.textBox2.Text));
            byte[] message = Encoding.ASCII.GetBytes(this.richTextBox1.Text);
            udpSender.Send(message, message.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receiveThread = new System.Threading.Thread(ReceiveMessage);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void ReceiveMessage()
        {
            IPEndPoint remoteIpEndPoint = null;
            while (true)
            {
                try
                {

                    byte[] receiveBytes = udpSender.Receive(ref remoteIpEndPoint);

                    string message = Encoding.ASCII.GetString(receiveBytes);
                    //message = "Remote-" + remoteIpEndPoint.Address.ToString() + ":" + remoteIpEndPoint.Port.ToString() + "\n"

                    //          + message + "\n";
                    ShowMessageforView(message);

                }
                catch
                {
                    break;
                }
            }
        }

        delegate void ShowMessageforViewCallBack(string text);
        private void ShowMessageforView(string text)
        {
            if (this.InvokeRequired)
            {
                ShowMessageforViewCallBack showMessageforViewCallback = ShowMessageforView;
                this.Invoke(showMessageforViewCallback, new object[] { text });
            }
            else
            {
                this.richTextBox2.AppendText(text+"\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.richTextBox2.Clear();
        }
    }
}
