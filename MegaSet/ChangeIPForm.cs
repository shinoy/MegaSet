using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace MegaSet
{
    public partial class ChangeIPForm : Form
    {
        NodeInfoDS myDataset;
        DevExpress.XtraTreeList.Nodes.TreeListNode myNode;

        public ChangeIPForm(NodeInfoDS dataSet, TreeListNode node)
        {
            myDataset = dataSet;
            myNode = node;
            InitializeComponent();
        }

        private void ChangeIPForm_Load(object sender, EventArgs e)
        {
            string myNodeIp = myNode.GetValue("ID").ToString();
            string[] addressSegments = myNodeIp.Split(new char[] { '.' });
            this.spinEdit1.Value = Decimal.Parse(addressSegments[0]);
            this.spinEdit2.Value = Decimal.Parse(addressSegments[1]);
            this.spinEdit3.Value = Decimal.Parse(addressSegments[2]);
            this.spinEdit4.Value = Decimal.Parse(addressSegments[3]);

            //foreach (NodeInfoDS.cpbInfoRow row in myDataset.cpbInfo.Rows)
            //{
            //    if (row.ID == this.richTextBox1.Text && myNode.Level != 2)
            //    {
            //        DevExpress.XtraEditors.XtraMessageBox.Show("名称已经存在，无法修改");
            //        return;
            //    }
            //}
        }

        // change ip button click event
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            string newIP = this.spinEdit1.Value.ToString() + "." + this.spinEdit2.Value.ToString() + "." + this.spinEdit3.Value.ToString() + "." + this.spinEdit4.Value.ToString();
            if (DevExpress.XtraEditors.XtraMessageBox.Show("该操作将更改硬件IP，是否确认更改IP地址为" + newIP, "注意", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

          

            foreach (NodeInfoDS.cpbInfoRow row in myDataset.cpbInfo.Rows)
            {
                if (row.ID == newIP && myNode.Level == 2)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("IP地址已经存在，无法修改");
                    return;
                }
            }


            ChangeNodeIP(newIP);
        }


        private void ChangeNodeIP(string newipAddress)
        {
            try
            {

                if (myNode != null)
                {
                    if (myNode.Level == 2)
                    {

                        DataRow[] rows = myDataset.cpbInfo.Select(string.Format("ID = '{0}'", myNode.GetValue("ID").ToString()));
                        string newAddress = rows[0]["Address"].ToString();
                       // MessageBox.Show(myNode.GetValue("ID").ToString());
                        newAddress = newAddress.Replace(myNode.GetValue("ID").ToString(), newipAddress);
                        //MessageBox.Show(newAddress);
                       
                        rows[0]["Address"] = newAddress;
                        rows[0]["ID"] = newipAddress;
                        DialogResult = System.Windows.Forms.DialogResult.OK;

                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("节点修改出错，请重新选择修改");
                        DialogResult = System.Windows.Forms.DialogResult.Abort;
                    }
                }

               
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("节点修改出错，请重新选择修改");
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

    }
}
