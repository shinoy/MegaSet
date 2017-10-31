using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaSet
{
    public partial class DebugForm : Form
    {
        private NodeInfoDS myDataset;
       // private ProtocalParserCLS agent = new ProtocalParserCLS();

        public DebugForm(NodeInfoDS dataset )
        {
            myDataset = dataset;
           // agent.Connect();
           // agent.DataArrived += agent_DataArrived;
            InitializeComponent();
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
                this.richTextBox1.AppendText(text);
            }
        }

        void agent_DataArrived(object sender, ProtocalParseEventArg e)
        {
            switch (e.Data.TypeName)
            { 
                case CPBProtolType.Power:

                    PowerFrameType frame = (PowerFrameType)e.Data.Content;
                    ShowMessageforView(string.Format("{0} :", e.Data.IPAddress));
                    ShowMessageforView(frame.PowerGroup + " " +
                                            frame.Status.ToString() + " " +
                                            frame.DayTime + " " +
                                            frame.StartTime + " " +
                                            frame.Duration + "\n");

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(" ******************************  cpbInfo  **********************************  \n");
            foreach (DataRow row in myDataset.cpbInfo.Rows)
            { 
               this.richTextBox1.AppendText(String.Format("ID:{0} ParentID:{1} Address:{2} NodeImage{3}\n",row["ID"],row["ParentID"],row["Address"],row["NodeImage"]));
            }

            this.richTextBox1.AppendText(" ******************************  NodeInfo  **********************************  \n");
            foreach (DataRow row in myDataset.NodeInfo.Rows)
            {
                this.richTextBox1.AppendText(String.Format("IP:{0} Temp:{1} DateTime:{2} Voltage:{3} GPSTime:{4} Version:{5} \n", row["IP"], row["Temp"], row["DateTime"], row["Voltage"], row["GPSTime"], row["Version"]));
            }

            this.richTextBox1.AppendText(" ******************************  NodeTimeInfo  **********************************  \n");
            foreach (DataRow row in myDataset.NodeTimeInfo.Rows)
            {
                this.richTextBox1.AppendText(String.Format("GroupName:{0} Status:{1} StartTime:{2}  EndTime:{3}  Duration:{4}  TypeName:{5} IP:{6}  GroupID:{7}\n", row["GroupName"], row["Status"], row["StartTime"], row["EndTime"], row["Duration"], row["TypeName"], row["IP"],row["GroupID"]));
            }

            this.richTextBox1.AppendText(" ******************************  DisplayNodeInfo  **********************************  \n");
            foreach (DataRow row in myDataset.DispNodeInfo.Rows)
            {
                this.richTextBox1.AppendText(String.Format("GroupName:{0} Status:{1} Date:{2} StartTime:{3} EndTime:{4} TypeName:{5} IP:{6} \n", row["GroupName"], row["Status"], row["Date"], row["StartTime"], row["EndTime"], row["TypeName"], row["IP"]));
            }

            //this.richTextBox1.AppendText(" ******************************  backup Table  **********************************  \n");
         
            //    this.richTextBox1.AppendText(String.Format("GroupName:{0} Status:{1} Date:{2} StartTime:{3} EndTime:{4} TypeName:{5} IP:{6} \n", ["GroupName"], row["Status"], row["Date"], row["StartTime"], row["EndTime"], row["TypeName"], row["IP"]));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  agent.SendCMD(this.textBox1.Text, this.textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TestPars(this.textBox1.Text);
        }

        private void TestPars(string frame)
        {
            string tag = frame.Substring(0, 1);
            if (tag.Equals("8"))
            {
                string[] strArray = frame.Split(new char[] { ' ',  }, StringSplitOptions.RemoveEmptyEntries);
                if(strArray.Length == 5)
                {
                 PowerFrameType group = new PowerFrameType();
                 group.PowerGroup = strArray[0].Substring(strArray[0].Length - 2, 2);
                 group.Status = strArray[1].Equals("ON") ? true : false;
                 group.DayTime = strArray[2];
                 group.StartTime = strArray[3];
                 group.Duration = strArray[4];

                 this.richTextBox1.AppendText(group.PowerGroup + "\n" +
                                              group.Status.ToString() + "\n" +
                                              group.DayTime + "\n" +
                                              group.StartTime + "\n" +
                                              group.Duration);
                    
                }

               
               
            }
        }

        private void DebugForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  agent.Dispose();
        }
    }
}
