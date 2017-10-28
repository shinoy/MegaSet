using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class ProtocalParserCLS
    {
        private List<FrameDataStruct> receiveQueue = new List<FrameDataStruct>();

        public ProtocalParserCLS()
        { 
            
        }
    }
}
