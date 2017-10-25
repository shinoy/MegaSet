using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraScheduler;
using DevExpress.Skins;



namespace MegaSet
{
    public partial class Form1 : RibbonForm
    {
        private System.Timers.Timer dateTimerTicker = new System.Timers.Timer(500);

        private int editingRow = -1;

        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            dateTimerTicker.Elapsed += dateTimerTicker_Elapsed;
            dateTimerTicker.Start();
          
         
        }

        private void dateTimerTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.dateTimeInfo.Caption = DateTime.Now.ToString();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void openScheduleItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nodeInfoDS.NodeInfo.Rows.Add("row1",true,DateTime.Now,new TimeSpan(3,14,22), 128, nodeInfoDS.NodeInfo.Rows.Count);
            nodeInfoDS.cpbInfo.Rows.Add("上海","0","上海",0);
            nodeInfoDS.cpbInfo.Rows.Add("北京", "0", "北京", 0);
            nodeInfoDS.cpbInfo.Rows.Add("上海_192.168.1.1", "上海", "192.168.1.1", 1);
            nodeInfoDS.cpbInfo.Rows.Add("上海_192.168.1.2", "上海", "192.168.1.2", 1);
            nodeInfoDS.cpbInfo.Rows.Add("北京_10.0.0.1", "北京", "10.0.0.1", 1);
            nodeInfoDS.WriteXml(@"d:\nodeinfo.xml");

            this.gridView1.ShowingEditor += gridView1_ShowingEditor;

            LocationsEditor editorWindow = new LocationsEditor();

            editorWindow.ShowDialog();
        }

        void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            int currentEditRow = (int)this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ID");
            if (editingRow == -1)
            {
                editingRow = currentEditRow;
                e.Cancel = false;
            //    MessageBox.Show("first ID: " + editingRow);
                checkBox1.Checked = true;
            }
            else
            {
                if (currentEditRow == editingRow)
                {
                    e.Cancel = false;
                   // MessageBox.Show("current id: " + currentEditRow.ToString() + " editing row: " + editingRow.ToString());
                    checkBox1.Checked = true;
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                        e.Cancel = true;
                      //  MessageBox.Show("Please update " + editingRow.ToString() + " firstly");
                    }
                    else
                    {
                        e.Cancel = false;
                        editingRow = currentEditRow;
                      //  MessageBox.Show("Change to edit " + currentEditRow.ToString());
                    }
                }
            }

          
        }


       
        private void Form1_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
            UserLookAndFeel.Default.SetSkinStyle("VS2010");
            Skin skin = GridSkins.GetSkin(this.cpbTreeView.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Percent50;

            
           
        }

        void Default_StyleChanged(object sender, EventArgs e)
        {
            // re-enable treeline for treeview 
            Skin skin = GridSkins.GetSkin(this.cpbTreeView.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Percent50;
        }


      
       

       

    }
}