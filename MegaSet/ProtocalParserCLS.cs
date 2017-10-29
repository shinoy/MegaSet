using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MegaSet
{
    public enum CPBProtolType
    {
        Power
    }

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

        public string DayTime
        {
            get;
            set;
        }

        public string StartTime
        {
            get;
            set;
        }

        public string Duration
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
    public class cpbProtocalDataCls
    {
        CPBProtolType typeName;
        string ipAddress;
        object content;

       public cpbProtocalDataCls(CPBProtolType type, string ip, object obj)
        {
           typeName = type;
           ipAddress = ip;
            content = obj;
        }

       public CPBProtolType TypeName
       {
           get { return typeName; }
       }

       public string IPAddress
       {
           get { return ipAddress; }
       }

       public object Content
       {
           get { return content; }
       }
    }


    public class ProtocalParseEventArg : EventArgs
    {
        public cpbProtocalDataCls Data { get; private set; }


        public ProtocalParseEventArg(cpbProtocalDataCls date)
        {
            Data = date;
        }
    }

    public class ProtocalParserCLS:IDisposable
    {
        private List<cpbProtocalDataCls> receiveQueue = new List<cpbProtocalDataCls>();

        private UdpClient updClient = new UdpClient(88);

        System.Threading.Thread receiveThread = null;

        public event EventHandler<ProtocalParseEventArg> DataArrived;

        private void ProcessProtocal(string ipAddress, string frame)
        {
             string tag = frame.Substring(0, 1);
             if (tag.Equals("8"))
             {
                 string[] strArray = frame.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries);
                 if (strArray.Length == 5)
                 {
                     PowerFrameType group = new PowerFrameType();
                     group.PowerGroup = strArray[0].Substring(strArray[0].Length - 2, 2);
                     group.Status = strArray[1].Equals("ON") ? true : false;
                     group.DayTime = strArray[2];
                     group.StartTime = strArray[3];
                     group.Duration = strArray[4];

                     DataArrived(this, new ProtocalParseEventArg(new cpbProtocalDataCls(CPBProtolType.Power, ipAddress, group)));

                 }
             }

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
                    ProcessProtocal(remoteIpEndPoint.Address.ToString(), message);

                }
                catch (SocketException ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("网络连接异常，请重新运行程序");
                }
            }
        }

        public void Connect()
        {
            receiveThread = new System.Threading.Thread(ReceiveMessage) { IsBackground = true };
            receiveThread.Start();
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
