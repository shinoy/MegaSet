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
    public partial class LocationsEditor : Form
    {
        public NodeInfoDS locationDataset;
        private bool isCheckEnabled;
        private string upLevelNodeName;

        public LocationsEditor(NodeInfoDS dataset)
        {
            locationDataset = dataset;
            isCheckEnabled = true;
            InitializeComponent();
        }

        public LocationsEditor(NodeInfoDS dataset, bool isLevel2, string upLevelName)
        {
            locationDataset = dataset;
            isCheckEnabled = isLevel2;
            upLevelNodeName = upLevelName;
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.textEdit1.Text == "0")
            {
                textEdit1.Text = "";
                DevExpress.XtraEditors.XtraMessageBox.Show("0不能作为站点名称");
            }
            if (this.textEdit1.Text.Length <= 10 && this.textEdit1.Text.Length > 0 )
            {
                try
                {
                    this.locationDataset.cpbInfo.Rows.Add(this.textEdit1.Text, String.IsNullOrEmpty(this.rootLocationDropDownBtn.Text) ? "0" : this.rootLocationDropDownBtn.Text, this.textEdit1.Text, String.IsNullOrEmpty(this.rootLocationDropDownBtn.Text) ? 0 : 6);
                    //MessageBox.Show(this.locationDataset.cpbInfo.Rows[0]["ParentID"].ToString());
                    this.Close();
                }
                catch (System.Data.ConstraintException ex)
                {
                    textEdit1.Text = "";
                    DevExpress.XtraEditors.XtraMessageBox.Show("重复的站点名称已经存在，请确认新站点名称");
                }

            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("站点名称不允许超过10个字符或者为空，请修改");
            }

          
        }

        private void refreshRootList()
        {
            foreach (NodeInfoDS.cpbInfoRow row in locationDataset.cpbInfo.Rows)
            {
                if (row.NodeImage == 0)
                {
                    DevExpress.XtraBars.BarButtonItem item = new DevExpress.XtraBars.BarButtonItem();
                    item.Caption = row.ID;
                    this.rootListPopMenu.AddItem(item);
                    item.ItemClick += item_ItemClick;
                    this.rootLocationDropDownBtn.Text = item.Caption;
                }
            }
            if (this.rootLocationDropDownBtn.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("第一级站点列表为空，请创建后选择");
                this.rootLocationDropDownBtn.Enabled = false;
                this.checkBox1.Checked = false;
            }
        }

        private void cleanUpRootList()
        {
            this.rootLocationDropDownBtn.Text = "";
            this.rootListPopMenu.ClearLinks();
        }

        private void item_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rootLocationDropDownBtn.Text = e.Item.Caption;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.rootLocationDropDownBtn.Enabled = true;
                refreshRootList();
            }
            else
            {
                this.rootLocationDropDownBtn.Enabled = false;
                this.rootLocationDropDownBtn.Text = "";
                cleanUpRootList();
            }
        }

        private void LocationsEditor_Load(object sender, EventArgs e)
        {
            if (isCheckEnabled == false)
            {
                this.checkBox1.Enabled = false;
                this.rootLocationDropDownBtn.Text = upLevelNodeName;
            }
        }

       
    }
}
