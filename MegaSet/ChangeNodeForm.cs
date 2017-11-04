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
    public partial class ChangeNodeForm : Form
    {
        NodeInfoDS myDataset;
        DevExpress.XtraTreeList.Nodes.TreeListNode myNode;

        public ChangeNodeForm(NodeInfoDS dataSet, TreeListNode node )
        {
            myNode = node;
            myDataset = dataSet;
            InitializeComponent();
        }


        private void ChangeNodeDesp(string newDespStr)
        {
            try
            {
               
                if (myNode != null)
                {

                    string dataID = myNode.GetValue("ID").ToString();

                    /// for level 0/1 node, just change ID/Address and ParentID
                    if (myNode.Level < 2)
                    {
                        foreach (NodeInfoDS.cpbInfoRow row in myDataset.cpbInfo.Rows)
                        {
                            if (row.ID == dataID)
                            {
                                row.ID = newDespStr;
                                row.Address = newDespStr;
                            }

                            // link child to new named node
                            if (row.ParentID == dataID)
                            {
                                row.ParentID = newDespStr;
                            }
                        }

                    }
                    if (myNode.Level == 2)
                    {
                        DataRow[] rows = myDataset.cpbInfo.Select(string.Format("ID = '{0}'", dataID));
                        rows[0]["Address"] = String.Format("({0}){1}",newDespStr, dataID);
                    }
                }

                DevExpress.XtraEditors.XtraMessageBox.Show("修改成功！");
                DialogResult = System.Windows.Forms.DialogResult.OK;
           

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("修改失败，失败原因："+ex.Message);
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }

           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length < 1 || richTextBox1.Text.Length > 15)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("描述长度不符合要求，不可为空或者大于15个字符");
            }
            else
            {

                foreach (NodeInfoDS.cpbInfoRow row in myDataset.cpbInfo.Rows)
                {
                    if (row.ID == this.richTextBox1.Text && myNode.Level != 2)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("名称已经存在，无法修改");
                        return;
                    }
                }

                ChangeNodeDesp(this.richTextBox1.Text);
      
            }
        }

        private void ChangeNodeForm_Load(object sender, EventArgs e)
        {
            this.richTextBox1.MaxLength = 15;
            try
            {
                if (this.myNode.Level == 2)
                {
                    string addressStr = myNode.GetValue("Address").ToString();
                    string idStr = myNode.GetValue("ID").ToString();
                    if (addressStr.StartsWith("("))
                    {
                        addressStr = addressStr.Substring(1, addressStr.Length - idStr.Length-2);
                    }
                    else
                    {
                        addressStr = "";
                    }
                    
                    this.richTextBox1.Text = addressStr;
                }
                else
                {
                    this.richTextBox1.Text = myNode.GetValue("ID").ToString();
                }
                
            }
            catch (Exception ex)
            { 
                
            }
        }
    }
}
