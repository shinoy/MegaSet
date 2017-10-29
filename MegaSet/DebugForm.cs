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

        public DebugForm(NodeInfoDS dataset)
        {
            myDataset = dataset;
            InitializeComponent();
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
                this.richTextBox1.AppendText(String.Format("GroupName:{0} Status:{1} Date:{2} StartTime:{3} EndTime:{4} TypeName:{5} IP:{6} \n", row["GroupName"], row["Status"], row["Date"], row["StartTime"], row["EndTime"], row["TypeName"], row["IP"]));
            }

            this.richTextBox1.AppendText(" ******************************  DisplayNodeInfo  **********************************  \n");
            foreach (DataRow row in myDataset.DispNodeInfo.Rows)
            {
                this.richTextBox1.AppendText(String.Format("GroupName:{0} Status:{1} Date:{2} StartTime:{3} EndTime:{4} TypeName:{5} IP:{6} \n", row["GroupName"], row["Status"], row["Date"], row["StartTime"], row["EndTime"], row["TypeName"], row["IP"]));
            }
        }
    }
}
