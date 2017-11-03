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
    public partial class EndPointEditorForm : Form
    {
        private NodeInfoDS myDataset;

        private bool isParentEditable = true;

        private string parentName;

        public EndPointEditorForm(NodeInfoDS dataset)
        {
            myDataset = dataset;
            isParentEditable = true;
            InitializeComponent();
        }

        public EndPointEditorForm(NodeInfoDS dataset, string ParentName)
        {
            myDataset = dataset;
            isParentEditable = false;
            parentName = ParentName;
            InitializeComponent();
        }

        private void EndPointEditorForm_Load(object sender, EventArgs e)
        {
            if (!isParentEditable)
            {
                this.dropDownButton1.Text = parentName;
                this.dropDownButton1.Enabled = false;
            }
            else
            {
                //TBD, 3 level enhence need
                foreach (NodeInfoDS.cpbInfoRow row in myDataset.cpbInfo.Rows)
                {
                    if (row.NodeImage == 6)
                    {
                        DevExpress.XtraBars.BarButtonItem item = new DevExpress.XtraBars.BarButtonItem();
                        item.Caption = row.ID;
                        popupMenu1.AddItem(item);
                        item.ItemClick += item_ItemClick;
                    }

                }
            }

         
        }

        void item_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dropDownButton1.Text = e.Item.Caption;
        }


      
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            if (this.dropDownButton1.Text.Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请选择二级站点名称，新节点将加入选择的站点");
                return;
            }
            if (textEdit1.Text.Length > 15)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("节点备注信息最多允许15个字符，请修改");
                return;
            }
            string currentIpAddress = spinEdit1.Value.ToString()+"."+spinEdit2.Value.ToString()+"."+spinEdit3.Value.ToString()+"."+spinEdit4.Value.ToString();
            string endPointTip = "";
            if (textEdit1.Text.Length != 0)
            {
                endPointTip = "(" + this.textEdit1.Text + ")";
            }

            
            try
            {
                myDataset.cpbInfo.Rows.Add(currentIpAddress, this.dropDownButton1.Text, endPointTip + currentIpAddress, 1);
                this.Close();
            }
            catch (System.Data.ConstraintException ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("该节点IP地址已经存在,请确认后重新添加");
                
            }
           
        }

       

       
    }
}
