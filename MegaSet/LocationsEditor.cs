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

        public LocationsEditor(NodeInfoDS dataset)
        {
            locationDataset = dataset;
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
                    this.locationDataset.cpbInfo.Rows.Add(this.textEdit1.Text, "0", this.textEdit1.Text, 0);
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

       
    }
}
