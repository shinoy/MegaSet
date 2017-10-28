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
            this.datetimeInfo.Caption = DateTime.Now.ToString();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void openScheduleItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.Filter = "MegaSet配置(*.mgs)|*.mgs|所有文件(*.*)|*.*";
          
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.nodeInfoDS.ReadXml(openFile.FileName);
                }
                catch( System.Security.SecurityException)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("没有权限访问该文件");
                }
                catch(Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("错误的配置文件");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nodeInfoDS.WriteXml(@"d:\nodeinfo.xml");
            nodeInfoDS.NodeInfo.Rows.Add("row1", true, DateTime.Now, DateTime.Now, DateTime.Now, "Camera");
            nodeInfoDS.NodeInfo.Rows.Add("row1", false, DateTime.Now,DateTime.Now, DateTime.Now, "CPB");
            nodeInfoDS.cpbInfo.Rows.Add("上海","0","上海",0);
            nodeInfoDS.cpbInfo.Rows.Add("北京", "0", "北京", 0);
            nodeInfoDS.cpbInfo.Rows.Add("上海_192.168.1.1", "上海", "202.202.202.202(区域五个字)", 1);
            nodeInfoDS.cpbInfo.Rows.Add("上海_192.168.1.2", "上海", "202.202.202.202(区域五个字)", 1);
            nodeInfoDS.cpbInfo.Rows.Add("北京_10.0.0.1", "北京", "1.1.1.1()", 1);
            

            this.gridView1.ShowingEditor += gridView1_ShowingEditor;

           
        }

        void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
        //    int currentEditRow = (int)this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ID");
        //    if (editingRow == -1)
        //    {
        //        editingRow = currentEditRow;
        //        e.Cancel = false;
        //    //    MessageBox.Show("first ID: " + editingRow);
        //        checkBox1.Checked = true;
        //    }
        //    else
        //    {
        //        if (currentEditRow == editingRow)
        //        {
        //            e.Cancel = false;
        //           // MessageBox.Show("current id: " + currentEditRow.ToString() + " editing row: " + editingRow.ToString());
        //            checkBox1.Checked = true;
        //        }
        //        else
        //        {
        //            if (checkBox1.Checked)
        //            {
        //                e.Cancel = true;
        //              //  MessageBox.Show("Please update " + editingRow.ToString() + " firstly");
        //            }
        //            else
        //            {
        //                e.Cancel = false;
        //                editingRow = currentEditRow;
        //              //  MessageBox.Show("Change to edit " + currentEditRow.ToString());
        //            }
        //        }
            //}

          
        }


       
        private void Form1_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
            UserLookAndFeel.Default.SetSkinStyle("VS2010");
            Skin skin = GridSkins.GetSkin(this.cpbTreeView.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Percent50;
            try
            {
                this.nodeInfoDS.ReadXml(@".\Configuration.mgs");
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("配置文件读取失败，生成新的配置文件");
                this.nodeInfoDS.WriteXml(@".\Configuration.mgs");
            }

            this.cpbTreeView.NodeChanged += cpbTreeView_NodeChanged;
           
           
        }

        void Default_StyleChanged(object sender, EventArgs e)
        {
            // re-enable treeline for treeview 
            Skin skin = GridSkins.GetSkin(this.cpbTreeView.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Percent50;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
          //  if (selectedNode != null)
             
            cpbTreeView.DeleteNode(cpbTreeView.FocusedNode);
        }

       
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            LocationsEditor locationEditor = new LocationsEditor(this.nodeInfoDS);
            locationEditor.StartPosition = FormStartPosition.CenterParent;
            locationEditor.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            EndPointEditorForm endPointForm = new EndPointEditorForm(this.nodeInfoDS);
            endPointForm.StartPosition = FormStartPosition.CenterParent;
            endPointForm.ShowDialog();
        }

        private void saveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDiag = new SaveFileDialog();
            saveFileDiag.SupportMultiDottedExtensions = false;
            saveFileDiag.DefaultExt = "mgs";
            saveFileDiag.AddExtension = true;
            saveFileDiag.Filter ="MegaSet配置(*.mgs)|*.mgs";
            if (saveFileDiag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.nodeInfoDS.WriteXml(saveFileDiag.FileName);
                }
                catch (System.Security.SecurityException ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("当前目录权限不足，无法保持配置");
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("未知错误，请保存截图上报错误信息\n"+ ex.Message);
                }

            }

       
            
            
        }


      
       

       

    }
}