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
using System.Net;
using System.Net.Sockets;



namespace MegaSet
{
    

    public partial class Form1 : RibbonForm
    {
        private System.Timers.Timer dateTimerTicker = new System.Timers.Timer(500);
        private string configFileName = @".\Configuration.mgs";
        private string currentNodeIp =string.Empty;

        private ProtocalParserCLS protocalAgent = new ProtocalParserCLS();

        delegate void MyDataUpdateCallBack(object sender, ProtocalParseEventArg e);

       // ProtocalParserCLS endpointConnecter = new ProtocalParserCLS();

    

        private int editingRow = -1;

        public Form1()
        {
           
                InitializeComponent();
                InitSkinGallery();
                dateTimerTicker.Elapsed += dateTimerTicker_Elapsed;
                dateTimerTicker.Start();
                protocalAgent.DataArrived += protocalAgent_DataArrived;
                this.protocalAgent.Connect();
         
        }



        void protocalAgent_DataArrived(object sender, ProtocalParseEventArg e)
        {
            if (this.InvokeRequired)
            {
                MyDataUpdateCallBack showMessageforViewCallback = protocalAgent_DataArrived;
                this.Invoke(showMessageforViewCallback, new object[] { sender,e });
            }
            else
            {
                switch (e.Data.TypeName)
                {
                    case CPBProtolType.Power:


                        PowerFrameType frame = (PowerFrameType)e.Data.Content;


                        string typeName = "Others";
                        string powerGroup = typeName + frame.PowerGroup;

                    

                        if (frame.PowerGroup.Equals("00"))
                        {
                            typeName = "Camera";
                            powerGroup = "Camera0";
                        }
                        if (frame.PowerGroup.Equals("01"))
                        {
                            typeName = "Camera";
                            powerGroup = "Camera1";
                        }
                        if (frame.PowerGroup.Equals("02"))
                        {
                            typeName = "CPB";
                            powerGroup = "CPB0";
                        }
                        if (frame.PowerGroup.Equals("03"))
                        {
                            typeName = "CPB";
                            powerGroup = "CPB1";
                        }



                        if (frame.StartTime.StartsWith("*"))
                        {
                            try
                            {
                                nodeInfoDS.NodeTimeInfo.Rows.Add(powerGroup, frame.Status, null, null, frame.Duration, typeName, e.Data.IPAddress);
                            }
                            catch (ConstraintException ex)
                            {
                                DataRow row = nodeInfoDS.NodeTimeInfo.Select(String.Format(" IP = '{0}' and GroupName = '{1}'", e.Data.IPAddress, powerGroup))[0];

                                row["Status"] = frame.Status;
                                row["StartTime"] = DBNull.Value;
                                row["EndTime"] = DBNull.Value;
                                row["Duration"] = frame.Duration;
                                row["TypeName"] = typeName;
                            }

                        }
                        else
                        {
                            DateTime startTime = DateTime.Parse(String.Format("{0} {1}", DateTime.Now.ToLongDateString(), frame.StartTime));
                            DateTime endTime = startTime.AddSeconds(Double.Parse(frame.Duration));

                            try
                            {
                                
                                nodeInfoDS.NodeTimeInfo.Rows.Add(powerGroup, frame.Status, startTime , endTime, frame.Duration, typeName, e.Data.IPAddress);
                            }
                            catch (ConstraintException ex)
                            {
                                DataRow row = nodeInfoDS.NodeTimeInfo.Select(String.Format(" IP = '{0}' and GroupName = '{1}'", e.Data.IPAddress, powerGroup))[0];

                                row["Status"] = frame.Status;
                                row["StartTime"] = startTime;
                                row["EndTime"] = endTime;
                                row["Duration"] = frame.Duration;
                                row["TypeName"] = typeName;
                            }
                        
                        }
                       
                        
                                        

                            //}
                            //else
                            //{
                            //    if (frame.DayTime.StartsWith("*"))
                            //    {
                            //        startTime = DateTime.Parse(String.Format("1000-01-01 {0}", frame.StartTime));
                            //        endTime = startTime.AddSeconds(double.Parse(frame.Duration));
                            //        try
                            //        {
                            //            nodeInfoDS.NodeTimeInfo.Rows.Add(powerGroup, frame.Status, startTime, endTime, frame.Duration, typeName, e.Data.IPAddress, true);
                            //        }
                            //        catch (ConstraintException ex)
                            //        {
                            //            DataRow row = nodeInfoDS.NodeTimeInfo.Select(String.Format(" IP = '{0}' and GroupName = '{1}'", e.Data.IPAddress, powerGroup))[0];

                            //            row["Status"] = frame.Status;
                            //            row["StartTime"] = startTime;
                            //            row["EndTime"] = endTime;
                            //            row["Duration"] = frame.Duration;
                            //            row["TypeName"] = typeName;
                            //            row["Repeat"] = true;

                            //        }

                            //    }
                            //    else
                            //    {
                            //        startTime = DateTime.Parse(String.Format("20{0} {1}", frame.DayTime, frame.StartTime));
                            //        endTime = startTime.AddSeconds(double.Parse(frame.Duration));
                            //        try
                            //        {
                            //            nodeInfoDS.NodeTimeInfo.Rows.Add(powerGroup, frame.Status, startTime, endTime, frame.Duration, typeName, e.Data.IPAddress, false);
                            //        }
                            //        catch (ConstraintException ex)
                            //        {
                            //            DataRow row = nodeInfoDS.NodeTimeInfo.Select(String.Format(" IP = '{0}' and GroupName = '{1}'", e.Data.IPAddress, powerGroup))[0];
                            //            row["Status"] = frame.Status;
                            //            row["StartTime"] = startTime;
                            //            row["EndTime"] = endTime;
                            //            row["Duration"] = frame.Duration;
                            //            row["TypeName"] = typeName;
                            //            row["Repeat"] = false;

                            //        }


                        break;
                } // end of case
            }


           
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
            //nodeInfoDS.WriteXml(@"d:\nodeinfo.xml");
            //nodeInfoDS.NodeInfo.Rows.Add("row1", true, DateTime.Now, DateTime.Now, DateTime.Now, "Camera");
            //nodeInfoDS.NodeInfo.Rows.Add("row1", false, DateTime.Now,DateTime.Now, DateTime.Now, "CPB");
            //nodeInfoDS.cpbInfo.Rows.Add("上海","0","上海",0);
            //nodeInfoDS.cpbInfo.Rows.Add("北京", "0", "北京", 0);
            //nodeInfoDS.cpbInfo.Rows.Add("上海_192.168.1.1", "上海", "202.202.202.202(区域五个字)", 1);
            //nodeInfoDS.cpbInfo.Rows.Add("上海_192.168.1.2", "上海", "202.202.202.202(区域五个字)", 1);
            //nodeInfoDS.cpbInfo.Rows.Add("北京_10.0.0.1", "北京", "1.1.1.1()", 1);
            //foreach(NodeInfoDS.cpbInfoRow row in nodeInfoDS.cpbInfo.Select("ID = '192.168.1.1'"))
            //{
            //    MessageBox.Show(row.Address);
            //}

            //nodeInfoDS.NodeTimeInfo.Rows.Add("group3", false, null, null, null, "caemra", "192.192.192.192");
            //nodeInfoDS.NodeTimeInfo.Rows.Add("group2", false, null, null, null, "caemra", "192.168.222.222");


            //this.endpointConnecter.SendCMD("get power", "192.168.1.100");
        
           
            DebugForm debugForm1 = new DebugForm(nodeInfoDS);

            debugForm1.ShowDialog();
        }

        void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView1.FocusedColumn.Caption == "日期")
            {
                    bool repeated = (bool)gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Repeat");
                    
                    if (repeated == true)
                    {
                        e.Cancel = true;
                    }
             
               
            }

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
            //DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;

            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
            UserLookAndFeel.Default.SetSkinStyle("VS2010");
            Skin skin = GridSkins.GetSkin(this.cpbTreeView.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.cpbTreeView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Percent50;
            try
            {
                this.nodeInfoDS.ReadXml(configFileName);
                updateDataSetAfterLoad();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("配置文件读取失败，生成新的配置文件");
                this.nodeInfoDS.Clear();
                this.nodeInfoDS.WriteXml(configFileName);
            }

            this.cpbTreeView.NodeChanged += cpbTreeView_NodeChanged;
            this.nodeInfoDS.NodeTimeInfo.RowChanged += NodeTimeInfo_RowChanged;
         

           // this.gridView1.ShowingEditor += gridView1_ShowingEditor;
           //  this.gridView1.CustomDrawCell += gridView1_CustomDrawCell;
           
        }

        /// <summary>
        /// want to disable date cell in repeat row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                // MessageBox.Show((gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "StartTime").ToString()));
           //    DateTime date = DateTime.Parse((gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "StartTime").ToString()));
                if (e.DisplayText == "_" )
                {
                    e.DisplayText = "*******";
                }
              //  this.gridView1.RefreshRowCell(e.RowHandle, e.Column);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Add NodeInfo table rows if there's no matched with cpbInfo table, confirmed we have one to one pair
        /// </summary>
        public void updateDataSetAfterLoad()
        {
            foreach (NodeInfoDS.cpbInfoRow cpbRow in nodeInfoDS.cpbInfo.Rows)
            {
                if (cpbRow.ParentID == "0")
                {
                    return;
                }
                if (nodeInfoDS.NodeInfo.Select(string.Format("IP = '{0}'",cpbRow.ID)).Length == 0)
                {
                
                    // to add nodeinfo row for orphan tree node 
                    nodeInfoDS.NodeInfo.Rows.Add(new object[] {cpbRow.ID , "_", "_", "_", "_", "_" });
                }
            }
        }

        void NodeTimeInfo_RowChanged(object sender, DataRowChangeEventArgs e)
        {   
            if (e.Action != DataRowAction.Delete)
            {
                
                this.nodeInfoDS.NodeTimeInfo.RowChanged -= NodeTimeInfo_RowChanged;
              
                    NodeInfoDS.NodeTimeInfoRow row = (NodeInfoDS.NodeTimeInfoRow)e.Row;

                 
                    if (row != null && !row.IsStartTimeNull() && !row.IsEndTimeNull())
                    {
                        row.StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, row.StartTime.Hour, row.StartTime.Minute, row.StartTime.Second);

                        DateTime newTime = new DateTime(row.StartTime.Year, row.StartTime.Month, row.StartTime.Day, row.EndTime.Hour, row.EndTime.Minute, row.EndTime.Second);
                        if (newTime.CompareTo(row.StartTime) <= 0)
                        {
                            row.EndTime = row.StartTime.AddMinutes(1);
                        }
                        else
                        {
                            row.EndTime = newTime;
                        }

                        TimeSpan interval = row.EndTime - row.StartTime;
                        row.Duration = ((Int32)interval.TotalSeconds).ToString();
                    }

                this.nodeInfoDS.NodeTimeInfo.RowChanged += NodeTimeInfo_RowChanged;
            }
            //nodeInfoDS.DispNodeInfo.Clear();
            //foreach (DataRow originalRow in this.nodeInfoDS.NodeTimeInfo.Select(string.Format("IP = '{0}'", currentNodeIp.ToString())))
            //{
            //    nodeInfoDS.DispNodeInfo.Rows.Add(originalRow);
            //}
            
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

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
          

           nodeInfoDS.NodeTimeInfo.Rows.Add("group1", false, null, null, null, "cpb", "192.192.192.192");
           nodeInfoDS.NodeTimeInfo.Rows.Add("group2", false, null, null, null, "caemra", "192.192.192.192");

          
        }

        private void cpbTreeView_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Level == 1)
                {
                    currentNodeIp = e.Node.GetValue("ID").ToString();
                }
            }
            else
            {
                currentNodeIp = string.Empty;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.protocalAgent.SendCMD("get power", "192.168.1.100");
        }

      


      
       

       

    }
}