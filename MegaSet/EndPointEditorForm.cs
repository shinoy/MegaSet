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

        public EndPointEditorForm(NodeInfoDS dataset)
        {
            myDataset = dataset;
            InitializeComponent();
        }

        private void EndPointEditorForm_Load(object sender, EventArgs e)
        {

            foreach (NodeInfoDS.cpbInfoRow row in myDataset.cpbInfo.Rows)
            {
                if(row.ParentID == "0")
                {
                    DevExpress.XtraBars.BarButtonItem item = new DevExpress.XtraBars.BarButtonItem();
                    item.Caption = row.ID;
                    popupMenu1.AddItem(item);
                    item.ItemClick += item_ItemClick;
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
                DevExpress.XtraEditors.XtraMessageBox.Show("请选择站点名称，新节点将加入选择的站点");
                return;
            }
            if (textEdit1.Text.Length > 5)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("节点备注信息最多允许5个字符，请修改");
                return;
            }
            string currentIpAddress = spinEdit1.Value.ToString()+"."+spinEdit2.Value.ToString()+"."+spinEdit3.Value.ToString()+"."+spinEdit4.Value.ToString();
            string endPointTip = "(" + this.textEdit1.Text + ")";
            try
            {
                myDataset.cpbInfo.Rows.Add(currentIpAddress, this.dropDownButton1.Text, currentIpAddress + endPointTip, 1);
            }
            catch (System.Data.ConstraintException ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("该节点已经存在于"+this.dropDownButton1.Text+",请确认后重新添加");
                
            }
        }

       

       
    }
}
