using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MegaSet
{

    /// <summary>
    /// 8 - get power 
    /// </summary>
    public class PowerFrameType
    {
        public string PowerGroup
        {
            get;
            set;
        }

        public bool Status
        {
            get;
            set;
        }

        public DateTime DayTime
        {
            get;
            set;
        }

        public DateTime StartTime
        {
            get;
            set;
        }

        public TimeSpan Duration
        {
            get;
            set;
        }

    }


    /// <summary>
    /// 7 - get status
    /// </summary>
    public class StatusFrameType
    {
        public string ChannelID
        {
            get;
            set;
        }

        public bool Status
        {
            get;
            set;
        }

    }

    /// <summary>
    /// 1 - get time 
    /// </summary>
    public class TimeFrameType
    {
        public DateTime Time
        {
            get;
            set;
        }
    }


    /// <summary>
    ///  power on enable/disable response
    /// </summary>
    public class PowerCMDResp
    {
        bool PowerState
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Define the frame struct in Queue for receiving
    /// </summary>
    public struct FrameDataStruct
    {
        string typeName;
        string ipAddress;
        object frameData;
    }

    public class ProtocalParserCLS:IDisposable
    {
        private List<FrameDataStruct> receiveQueue = new List<FrameDataStruct>();

        private UdpClient updClient = new UdpClient(88);

        System.Threading.Thread receiveThread = null;

        public ProtocalParserCLS()
        {
            receiveThread = new System.Threading.Thread(ReceiveMessage) { IsBackground = true };
            receiveThread.Start();
           
        }

        private void ReceiveMessage()
        {
            IPEndPoint remoteIpEndPoint = null;
            while (true)
            {
                try
                {

                    byte[] receiveBytes = updClient.Receive(ref remoteIpEndPoint);

                    string message = Encoding.ASCII.GetString(receiveBytes);
                    System.Windows.Forms.MessageBox.Show(string.Format("{0}:{1}", remoteIpEndPoint.Address, message));
                    // to do

                }
                catch (SocketException ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("网络连接异常，请重新运行程序");
                }
            }
        }

        public void SendCMD(string command, string ipAddress)
        {
            IPEndPoint remote = new IPEndPoint(IPAddress.Parse(ipAddress), 80);

            byte[] message = Encoding.ASCII.GetBytes(command);

            updClient.Send(message, message.Length, remote);
        }

        public void Dispose()
        {
            if (receiveThread != null)
            {
                receiveThread.Abort();
                updClient.Close();
                receiveQueue.Clear();
            }
           

        }
    }
}
