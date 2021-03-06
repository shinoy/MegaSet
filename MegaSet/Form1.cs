﻿using System;
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
using System.IO;



namespace MegaSet
{
    

    public partial class Form1 : RibbonForm
    {
        private System.Timers.Timer systemTimerTicker = new System.Timers.Timer(500);
        private System.Timers.Timer cpbTimeTicker = new System.Timers.Timer(1000);

        private System.Timers.Timer powerTimeoutTicker = new System.Timers.Timer(4000);
        private System.Timers.Timer dateTimeTimeoutTicker = new System.Timers.Timer(4000);
        private System.Timers.Timer tempTimeoutTicker = new System.Timers.Timer(4000);
        private System.Timers.Timer voltageTimeoutTicker = new System.Timers.Timer(4000);
        private System.Timers.Timer versionTimeoutTicker = new System.Timers.Timer(4000);
        private System.Timers.Timer gpsTimeoutTicker = new System.Timers.Timer(5000);


        private string configFileName = System.Environment.CurrentDirectory + @"\Configuration.mgs";
        private string currentNodeIp =string.Empty;
        private bool isEdited = false;
        private string userName = "";
        private int userLevel = -1;
      

        private NodeInfoDS.NodeTimeInfoDataTable backupTable = new NodeInfoDS.NodeTimeInfoDataTable();

        private ProtocalParserCLS protocalAgent;

        delegate void MyDataUpdateCallBack(object sender, ProtocalParseEventArg e);

       // ProtocalParserCLS endpointConnecter = new ProtocalParserCLS();


        public Form1(string user, int level)
        {
            try
            {
                protocalAgent = new ProtocalParserCLS();
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("网络端口打开失败，请确认端口88未被占用,程序异常退出");
                return;
            }
                // initialize timeout ticker 
            powerTimeoutTicker.AutoReset = false;
            powerTimeoutTicker.Elapsed += powerTimeoutTicker_Elapsed;

            dateTimeTimeoutTicker.AutoReset = false;
            dateTimeTimeoutTicker.Elapsed += dateTimeTimeoutTicker_Elapsed;

            tempTimeoutTicker.AutoReset = false;
            tempTimeoutTicker.Elapsed += tempTimeoutTicker_Elapsed;

            voltageTimeoutTicker.AutoReset = false;
            voltageTimeoutTicker.Elapsed += voltageTimeoutTicker_Elapsed;

            versionTimeoutTicker.AutoReset = false;
            versionTimeoutTicker.Elapsed += versionTimeoutTicker_Elapsed;

            gpsTimeoutTicker.AutoReset = false;
            gpsTimeoutTicker.Elapsed += gpsTimeoutTicker_Elapsed;
                
                userName = user;
                userLevel = level;
                InitializeComponent();
                InitSkinGallery();
                systemTimerTicker.Elapsed += dateTimerTicker_Elapsed;
                systemTimerTicker.Start();
                protocalAgent.DataArrived += protocalAgent_DataArrived;
                this.protocalAgent.Connect();
                backupTable.Rows.Add();
                
         
        }

        void gpsTimeoutTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("GPS信息超时,请确认节点网络连接");
        }

        void versionTimeoutTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("当前版本获取超时");
        }

        void voltageTimeoutTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("当前电压获取超时");
        }

        void tempTimeoutTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("当前温度获取超时");
        }

        void dateTimeTimeoutTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("当前时间获取超时");
        }

        void powerTimeoutTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("定时表获取超时,请确认节点网络连接");
        }



        private bool isInTimeRange(DateTime startTimeIn, string durationStr, DateTime myTime)
        {
            DateTime startTime = startTimeIn;
            DateTime endTime = startTime.AddMinutes(Double.Parse(durationStr));

            try
            {
                DateTime currentTime = myTime;
                DateTime compareTime1 = new DateTime(startTime.Year, startTime.Month, startTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);
                DateTime compareTime2 = new DateTime(endTime.Year, endTime.Month, endTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);

                if (startTime.Day != endTime.Day)
                {
                    if ((startTime < compareTime1) || (compareTime2 < endTime))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if ((startTime < compareTime1) && (compareTime2 < endTime))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
                            
        }

        private void RefreshTimeTargetStatus()
        { 
             DateTime currentTime;
             try
             {
                 currentTime = DateTime.Parse(this.digitalGauge3.Text);
                 foreach (NodeInfoDS.NodeTimeInfoRow row in nodeInfoDS.NodeTimeInfo.Rows)
                 {

                     if (row.IsStartTimeNull() || row.Duration.StartsWith("*") || row.Status == false)
                     {
                         row.IsTarget = false;
                     }
                     else
                     {
                         row.IsTarget = isInTimeRange(row.StartTime, row.Duration, currentTime);
                     }
                    
                 }
             }
             catch (Exception ex)
             {
                 return;
             }
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
                // currently only receive one node info
                if (e.Data.IPAddress != currentNodeIp)
                {
                    return;
                }
                switch (e.Data.TypeName)
                {
                    case CPBProtolType.Power:
                        this.powerTimeoutTicker.Stop();
                        PowerFrameType frame = (PowerFrameType)e.Data.Content;                    
                        int groupID = int.Parse(frame.PowerGroup);
                        int groupName;
                        string typeName;
                     //   MessageBox.Show(String.Format("{0}",groupID));

                        if (frame.PowerGroup.Equals("00") || frame.PowerGroup.Equals("01"))
                        {
                            typeName = "1-摄像头";
                            groupName = groupID;
                        }
                        else
                        {

                            if (frame.PowerGroup.Equals("02") || frame.PowerGroup.Equals("03"))
                            {
                                typeName = "2-通道板";
                                groupName = groupID - 2;
                            }
                            else
                            {
                                typeName = "3-其他设备";
                                groupName = groupID - 4;
                            }
                        }


                        if (frame.StartTime.StartsWith("*"))
                        {
                            try
                            {
                                nodeInfoDS.NodeTimeInfo.Rows.Add(groupName, frame.Status, null, null, frame.Duration, typeName, e.Data.IPAddress, groupID,false);
                            }
                            catch (ConstraintException ex)
                            {
                                DataRow row = nodeInfoDS.NodeTimeInfo.Select(String.Format(" IP = '{0}' and GroupID = '{1}'", e.Data.IPAddress, groupID))[0];

                                row["Status"] = frame.Status;
                                row["StartTime"] = DBNull.Value;
                                row["EndTime"] = DBNull.Value;
                                row["Duration"] = frame.Duration;
                                row["TypeName"] = typeName;
                                row["GroupName"] = groupName;
                                row["IsTarget"] = false; 
                            }

                        }
                        else
                        {
                            DateTime startTime = DateTime.Parse(String.Format("{0} {1}", DateTime.Now.ToLongDateString(), frame.StartTime));
                            DateTime endTime = startTime.AddMinutes(Double.Parse(frame.Duration));
                            bool compareResult = false;

                            try
                            {
                                DateTime currentTime = DateTime.Parse(this.digitalGauge3.Text);
                                DateTime compareTime1 = new DateTime(startTime.Year, startTime.Month, startTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);
                                DateTime compareTime2 = new DateTime(endTime.Year, endTime.Month, endTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);

                                if (startTime.Day != endTime.Day)
                                {
                                    if ((startTime < compareTime1) || (compareTime2 < endTime))
                                    {
                                        compareResult = true;
                                    }
                                }
                                else
                                {
                                    if ((startTime < compareTime1) && (compareTime2 < endTime))
                                    {
                                        compareResult = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            { 
                                // not set istarget if error
                            }
                            


                            try
                            {
                                
                                nodeInfoDS.NodeTimeInfo.Rows.Add(groupName, frame.Status, startTime , endTime, frame.Duration, typeName, e.Data.IPAddress,groupID,compareResult);
                            }
                            catch (ConstraintException ex)
                            {
                                DataRow row = nodeInfoDS.NodeTimeInfo.Select(String.Format(" IP = '{0}' and GroupID = '{1}'", e.Data.IPAddress, groupID))[0];

                                row["Status"] = frame.Status;
                                row["StartTime"] = startTime;
                                row["EndTime"] = endTime;
                                row["Duration"] = frame.Duration;
                                row["TypeName"] = typeName;
                                row["GroupName"] = groupName;
                                row["IsTarget"] = compareResult; 
                            }
                        
                        }

                        if (!isEdited)
                        {
                            this.gridView1.MoveFirst();
                        }         
                        break;

                    case CPBProtolType.Date:
                        this.dateTimeTimeoutTicker.Stop();
                        this.cpbTimeTicker.Stop();
                        this.nodeInfoDS.DispNodeInfo[0]["DateTime"] = e.Data.Content.ToString();
                        this.cpbTimeTicker.Start();
                        RefreshTimeTargetStatus();
                        if (!isEdited)
                        {
                            this.gridView1.MoveFirst();
                        }
                       
                        break;

                    case CPBProtolType.Temp:
                        this.tempTimeoutTicker.Stop();
                        this.nodeInfoDS.DispNodeInfo[0]["Temp"] = e.Data.Content.ToString();
                        break;
                    case CPBProtolType.Version:
                        this.versionTimeoutTicker.Stop();
                        this.nodeInfoDS.DispNodeInfo[0]["Version"] = e.Data.Content.ToString();

                        try
                        {
                            if (Double.Parse(e.Data.Content.ToString().Substring(0, 3)) >= 1.8)
                            {

                                if (this.checkEdit1.Checked == false)
                                {
                                    this.checkEdit1.Checked = true;
                                }
                                this.checkEdit1.Enabled = false;
                            }
                        }
                        catch (Exception ex)
                        { 
                           
                        }
                       
                        break;

                    case CPBProtolType.Valtage:
                        this.voltageTimeoutTicker.Stop();
                        this.nodeInfoDS.DispNodeInfo[0]["Voltage"] = e.Data.Content.ToString();
                        break;
                    case CPBProtolType.GPSErr:
                        this.gpsTimeoutTicker.Stop();
                        this.nodeInfoDS.DispNodeInfo[0]["GPSTime"] = "ERROR";
                        break;
                    case CPBProtolType.GPSTime:
                        this.gpsTimeoutTicker.Stop();
                        this.nodeInfoDS.DispNodeInfo[0]["GPSTime"] = e.Data.Content.ToString();
                        break;

                    default:
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

                this.cpbTreeView.NodeChanged -= cpbTreeView_NodeChanged;

                try
                {
                    this.nodeInfoDS.Clear();
                    this.nodeInfoDS.ReadXml(openFile.FileName);
                    this.nodeInfoDS.DispNodeInfo.Clear();
                    this.nodeInfoDS.NodeTimeInfo.Clear();
                    this.nodeInfoDS.DispNodeInfo.Rows.Add();
                }
                catch( System.Security.SecurityException)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("没有权限访问该文件");
                    this.nodeInfoDS.ReadXml(configFileName);
                    updateDataSetAfterLoad();
                    
                }
                catch(Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("错误的配置文件");
                    this.nodeInfoDS.Clear();
                    this.nodeInfoDS.ReadXml(configFileName);
                    updateDataSetAfterLoad();
                }

                this.cpbTreeView.NodeChanged += cpbTreeView_NodeChanged;
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


           // nodeInfoDS.NodeTimeInfo.Rows.Add(1, true, null, null, "******", "caemra", "192.168.1.1", (int)1);

            DebugForm debugForm1 = new DebugForm(nodeInfoDS);

            debugForm1.ShowDialog();
        }

        void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
                // here we save entire old row which is be editing, only need to save once because only can edit one row at a time  
                // this.cmpValueBefore = gridView1.FocusedValue.ToString();
            if (isEdited == false)
            {
                int rowGroupID =  int.Parse( this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "GroupID").ToString());
                NodeInfoDS.NodeTimeInfoRow temp = (NodeInfoDS.NodeTimeInfoRow)this.nodeInfoDS.NodeTimeInfo.Select(String.Format("GroupID = '{0}'", rowGroupID))[0];


                // change to use duration instead of endTime, we don't process endTime
                //if (temp.IsEndTimeNull())
                //{
                //    backupTable.Rows[0]["EndTime"] = DBNull.Value;
                //}
                //else
                //{
                //    backupTable.Rows[0]["EndTime"] = temp.EndTime;
                //}



                if (temp.IsStartTimeNull())
                {
                    backupTable.Rows[0]["StartTime"] = DBNull.Value;
                }
                else
                {
                    backupTable.Rows[0]["StartTime"] = temp.StartTime;
                }
                backupTable.Rows[0]["Duration"] = temp.Duration;
                backupTable.Rows[0]["GroupName"] = temp.GroupName;
                backupTable.Rows[0]["IP"] = temp.IP;
              
                backupTable.Rows[0]["Status"] = temp.Status;
                backupTable.Rows[0]["TypeName"] = temp.TypeName;
                backupTable.Rows[0]["GroupID"] = temp.GroupID;
                backupTable.Rows[0]["IsTarget"] = temp.IsTarget;
                isEdited = true;
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
                this.nodeInfoDS.DispNodeInfo.Clear();
                this.nodeInfoDS.NodeTimeInfo.Clear();
                this.nodeInfoDS.DispNodeInfo.Rows.Add();
              
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("配置文件读取失败，生成新的配置文件");
                this.nodeInfoDS.Clear();
                this.nodeInfoDS.WriteXml(configFileName);
            }

            this.nodeInfoDS.DispNodeInfo.Rows.Add(null, null, null, null, null);
          

            this.cpbTreeView.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.cpbTreeView_FocusedNodeChanged);
            this.cpbTreeView.NodeChanged += cpbTreeView_NodeChanged;
            this.cpbTreeView.MouseClick +=cpbTreeView_MouseClick;
            this.nodeInfoDS.NodeTimeInfo.RowChanged += NodeTimeInfo_RowChanged;
            this.gridView1.CellValueChanged += gridView1_CellValueChanged;
            this.gridView1.ShowingEditor += gridView1_ShowingEditor;
            this.gridView1.BeforeLeaveRow += gridView1_BeforeLeaveRow;
            this.cpbTimeTicker.Elapsed += cpbTimeTicker_Elapsed;

            if (this.userLevel != 0)
            {
                this.addUserBtn.Enabled = false;
            }
           
           
        }

        void cpbTimeTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (nodeInfoDS.DispNodeInfo.Rows.Count < 1)
            {
                return;
            }
            try
            {
                DateTime tempTime = DateTime.Parse(nodeInfoDS.DispNodeInfo.Rows[0]["DateTime"].ToString());
                tempTime = tempTime.AddSeconds(1);
                nodeInfoDS.DispNodeInfo.Rows[0]["DateTime"] = tempTime.ToString("yyyy-MM-dd HH:mm:ss");
            
            }
            catch(Exception ex)
            {
                return;
                // eat it
            }
             
            
           
        }

 
 

        /// <summary>
        /// want to disable date cell in repeat row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // TBD, we don't use this now
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
                if (cpbRow.NodeImage != 1)
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


          //  MessageBox.Show("row changed");

            // enable update and cancel button ;
         
               
 

            // Here we check start and end time, to sync correct time and save 
            if (e.Action != DataRowAction.Delete && e.Action != DataRowAction.Add)
            {
                
                this.nodeInfoDS.NodeTimeInfo.RowChanged -= NodeTimeInfo_RowChanged;

                if (isEdited)
                {
                    this.updateInfoBtn.Enabled = true;
                    this.cancelInfoChangeBtn.Enabled = true;
              
                }
               


                /*
                    NodeInfoDS.NodeTimeInfoRow row = (NodeInfoDS.NodeTimeInfoRow)e.Row;

                 
                    if (row != null && !row.IsStartTimeNull() && !row.IsEndTimeNull())
                    {
                        row.StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, row.StartTime.Hour, row.StartTime.Minute, row.StartTime.Second);

                        DateTime newTime = new DateTime(row.StartTime.Year, row.StartTime.Month, row.StartTime.Day, row.EndTime.Hour, row.EndTime.Minute, row.EndTime.Second);
                        if (newTime.CompareTo(row.StartTime) <= 0)
                        {
                            if ((row.StartTime.Hour == 23) && (row.StartTime.Minute == 59))
                            {
                                row.EndTime = row.StartTime;
                            }
                            else
                            {
                                row.EndTime = row.StartTime.AddMinutes(1);
                            }
                           
                        }
                        else
                        {
                            row.EndTime = newTime;
                        }

                        TimeSpan interval = row.EndTime - row.StartTime;
                        row.Duration = ((Int32)interval.TotalSeconds).ToString();
                    }
                    this.nodeInfoDS.NodeTimeInfo.AcceptChanges();
                */
                   
                this.nodeInfoDS.NodeTimeInfo.RowChanged += NodeTimeInfo_RowChanged;
            }
            
            
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
            if (cpbTreeView.FocusedNode == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前未选中任何节点");
                return;
            }
            if (DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("确定删除节点?"), "警告", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }


            DevExpress.XtraTreeList.Nodes.TreeListNode deleteNode = cpbTreeView.FocusedNode;
            if (deleteNode.ParentNode != null)
            {
                cpbTreeView.SetFocusedNode(deleteNode.ParentNode);
            }
            cpbTreeView.DeleteNode(deleteNode);
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
            this.gridView1.CloseEditor();
            if (editingRow > nodeInfoDS.NodeTimeInfo.Rows.Count - 1 || editingRow < 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("修改失败，请取消修改后重新设置");
                return;
            }
            NodeInfoDS.NodeTimeInfoRow sendRow = (NodeInfoDS.NodeTimeInfoRow)nodeInfoDS.NodeTimeInfo.Rows[editingRow];
            uint durationTemp;
            bool parseResult = uint.TryParse(sendRow.Duration, out durationTemp);
           // MessageBox.Show(uint.Parse(sendRow.Duration).ToString());
           // MessageBox.Show(sendRow["Status"].ToString());
            if ((sendRow.IsStartTimeNull() || !parseResult) && sendRow.Status )
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("节点定时信息不完整，请返回修改");
                return;
            }

            isEdited = false;
            this.updateInfoBtn.Enabled = false;
            this.cancelInfoChangeBtn.Enabled = false;

            // get row data = update cpb
            //nodeInfoDS.NodeTimeInfo.Rows[editingRow]["StartTime"] = originalRow.StartTime;


            //nodeInfoDS.NodeTimeInfo.Rows[editingRow]["Duration"] = backupTable.Rows[0]["Duration"];

            //nodeInfoDS.NodeTimeInfo.Rows[editingRow]["GroupName"] = backupTable.Rows[0]["GroupName"];
            //nodeInfoDS.NodeTimeInfo.Rows[editingRow]["IP"] = backupTable.Rows[0]["IP"];

            //nodeInfoDS.NodeTimeInfo.Rows[editingRow]["Status"] = backupTable.Rows[0]["Status"];
            //nodeInfoDS.NodeTimeInfo.Rows[editingRow]["TypeName"] = backupTable.Rows[0]["TypeName"];
            //nodeInfoDS.NodeTimeInfo.Rows[editingRow]["GroupID"] = backupTable.Rows[0]["GroupID"];
            this.gridView1.CloseEditor();
          
            //MessageBox.Show(nodeInfoDS.NodeTimeInfo.Rows[editingRow]["Status"].ToString());

           

            if (!(bool)nodeInfoDS.NodeTimeInfo.Rows[editingRow]["Status"])
            {
                protocalAgent.SendCMD(string.Format("power off {0}", nodeInfoDS.NodeTimeInfo.Rows[editingRow]["GroupID"].ToString()), currentNodeIp);
            }
            else
            {
               
                    //TimeSpan powerDuration = sendRow.EndTime - sendRow.StartTime;
                    

                    string command = string.Format("power on {0} {1} {2}", nodeInfoDS.NodeTimeInfo.Rows[editingRow]["GroupID"].ToString(), sendRow.StartTime.ToString("HHmmss"), durationTemp.ToString());
                    protocalAgent.SendCMD(command ,currentNodeIp);
               
                    
            }




            this.nodeInfoDS.NodeTimeInfo.AcceptChanges();
            this.ChangedRowStateHelper.DisabledRows.Clear();
            this.DisableRowStateHelper.DisabledRows.Clear();
        }

        private void cpbTreeView_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
          
            // if focus on endpoint node, we save the ip address and refresh cpb infomation
            if (e.Node != null && (System.Windows.Forms.Control.MouseButtons != System.Windows.Forms.MouseButtons.Right))
            {
                string newIP = e.Node.GetValue("ID").ToString();
               // MessageBox.Show(newIP);
               
                if ((e.Node.Level == 2 )&& (newIP != currentNodeIp))
                {
                    if (MessageBox.Show(string.Format("确定要切换到{0}么？", newIP), "警告", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.cpbTreeView.SetFocusedNode(e.OldNode);
                        return;
                    }

                    //stop current time increasing.
                    this.cpbTimeTicker.Stop();

                    currentNodeIp = newIP;
                    isEdited = false;
                    editingRow = -1;
                   
                    this.updateInfoBtn.Enabled = false;
                    this.cancelInfoChangeBtn.Enabled = false;
                    
                    this.DisableRowStateHelper.DisabledRows.Clear();
                    this.ChangedRowStateHelper.DisabledRows.Clear();

                  

                    this.nodeInfoDS.DispNodeInfo.Rows[0]["Temp"] = "__._";
                    this.nodeInfoDS.DispNodeInfo.Rows[0]["Voltage"] = "__._";
                    this.nodeInfoDS.DispNodeInfo.Rows[0]["GPSTime"] = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
                    this.nodeInfoDS.DispNodeInfo.Rows[0]["DateTime"] = "____-__-__ __:__:__";
                    this.nodeInfoDS.DispNodeInfo.Rows[0]["Version"] = "_._._";

                    this.timeEdit1.Time = DateTime.Now;

                    this.nodeInfoDS.NodeTimeInfo.Rows.Clear();

            
                    if (currentNodeIp != string.Empty)
                    {

                        this.powerTimeoutTicker.Start();
                        this.protocalAgent.SendCMD("get power", currentNodeIp);
                       
                   
                    }
                   
                  
                }
            }
            else
            {
                // we don't change current IP address if focus on other node.
                // currentNodeIp = string.Empty;
            }

          
            
        }

       
        private void addUserBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserMgmtForm userMgmtForm = new UserMgmtForm();
            userMgmtForm.StartPosition = FormStartPosition.CenterParent;
            userMgmtForm.ShowDialog();
        }

        private void cancelInfoChangeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            isEdited = false;

            this.cancelInfoChangeBtn.Enabled = false;
            this.updateInfoBtn.Enabled = false;



            if (editingRow > -1)
            {
                NodeInfoDS.NodeTimeInfoRow originalRow = (NodeInfoDS.NodeTimeInfoRow)backupTable.Rows[0];
                if (originalRow.IsStartTimeNull())
                {
                    nodeInfoDS.NodeTimeInfo.Rows[editingRow]["StartTime"] = DBNull.Value;
                }
                else
                {
                    nodeInfoDS.NodeTimeInfo.Rows[editingRow]["StartTime"] = originalRow.StartTime;
                }

                // Use duration instead of endtime
                //if (originalRow.IsEndTimeNull())
                //{
                //    nodeInfoDS.NodeTimeInfo.Rows[editingRow]["EndTime"] = DBNull.Value;
                //}
                //else
                //{
                //    nodeInfoDS.NodeTimeInfo.Rows[editingRow]["EndTime"] = originalRow.EndTime;
                //}


               

                nodeInfoDS.NodeTimeInfo.Rows[editingRow]["Duration"] = backupTable.Rows[0]["Duration"];

                nodeInfoDS.NodeTimeInfo.Rows[editingRow]["GroupName"] = backupTable.Rows[0]["GroupName"];
                nodeInfoDS.NodeTimeInfo.Rows[editingRow]["IP"] = backupTable.Rows[0]["IP"];

                nodeInfoDS.NodeTimeInfo.Rows[editingRow]["Status"] = backupTable.Rows[0]["Status"];
                nodeInfoDS.NodeTimeInfo.Rows[editingRow]["TypeName"] = backupTable.Rows[0]["TypeName"];
                nodeInfoDS.NodeTimeInfo.Rows[editingRow]["GroupID"] = backupTable.Rows[0]["GroupID"];
                nodeInfoDS.NodeTimeInfo.Rows[editingRow]["IsTarget"] = backupTable.Rows[0]["IsTarget"];

            }

            this.nodeInfoDS.NodeTimeInfo.AcceptChanges();
            this.ChangedRowStateHelper.DisabledRows.Clear();
            this.DisableRowStateHelper.DisabledRows.Clear();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (currentNodeIp != string.Empty)
            {
                this.dateTimeTimeoutTicker.Start();
                protocalAgent.SendCMD("get time",currentNodeIp);
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前没有选中任何通道板节点，请选择节点后更新信息");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (currentNodeIp != string.Empty)
            {
                this.voltageTimeoutTicker.Start();
                protocalAgent.SendCMD("get voltage", currentNodeIp);
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前没有选中任何通道板节点，请选择节点后更新信息");
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (currentNodeIp != string.Empty)
            {
                this.tempTimeoutTicker.Start();
                protocalAgent.SendCMD("get temp", currentNodeIp);
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前没有选中任何通道板节点，请选择节点后更新信息");
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (currentNodeIp != string.Empty)
            {
                this.versionTimeoutTicker.Start();
                protocalAgent.SendCMD("get version", currentNodeIp);
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前没有选中任何通道板节点，请选择节点后更新信息");
            }
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            if (currentNodeIp != string.Empty)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("确定重启节点{0}?", currentNodeIp), "警告", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    protocalAgent.SendCMD("reset", currentNodeIp);
                }

            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前没有选中任何节点，请选择节点后操作");
            }

          
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            PasswordChangeForm passwordForm = new PasswordChangeForm(this.userName);
            passwordForm.StartPosition = FormStartPosition.CenterParent;
            passwordForm.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.cpbTreeView.FocusedNode == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前没有选中任何节点");
                return;
            }
           
              
            
            bool isExpanded = this.cpbTreeView.FocusedNode.Expanded;
            ChangeNodeForm changeForm = new ChangeNodeForm(this.nodeInfoDS, this.cpbTreeView.FocusedNode);
            changeForm.StartPosition = FormStartPosition.CenterParent;
            this.cpbTreeView.NodeChanged -= cpbTreeView_NodeChanged;
            changeForm.ShowDialog();

            this.cpbTreeView.NodeChanged += cpbTreeView_NodeChanged;

            //restore the expanded status
            if (isExpanded)
            {
                this.cpbTreeView.FocusedNode.ExpandAll();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("设置时间后是否重启节点？"), "警告", MessageBoxButtons.YesNoCancel);

            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            try
            {
                if (currentNodeIp != string.Empty)
                {
                    DateTime timeSet = DateTime.Parse(this.timeEdit1.Text);
                    string str = timeSet.ToString("HHmmssyyMMdd");
                  //  MessageBox.Show(string.Format("set time {0}", str));
                    if (result == System.Windows.Forms.DialogResult.No)
                    {
                        this.dateTimeTimeoutTicker.Start();
                    }
                    protocalAgent.SendCMD(string.Format("set time {0}", str), currentNodeIp);
                   

                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("当前没有选中任何节点，请选择节点后操作");
                }

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("设置时间失败，请确认设置时间值有效");
            }

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (currentNodeIp != string.Empty)
                {
                        protocalAgent.SendCMD("reset", currentNodeIp);
                }
            }
            
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.nodeInfoDS.NodeTimeInfo.Rows.Clear();
           // this.nodeInfoDS.DispNodeInfo.Rows.Clear();
            this.nodeInfoDS.WriteXml(configFileName);
        }

        private void rightAdditem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.cpbTreeView.FocusedNode.Level == 0)
            {
                LocationsEditor locationEditor = new LocationsEditor(this.nodeInfoDS, false, cpbTreeView.FocusedNode.GetValue("ID").ToString());

                //  MessageBox.Show(cpbTreeView.FocusedNode.GetValue("ID").ToString());
                locationEditor.StartPosition = FormStartPosition.CenterParent;
                locationEditor.ShowDialog();

            }
            else
            if(this.cpbTreeView.FocusedNode.Level == 1)
            {
                EndPointEditorForm endPointForm = new EndPointEditorForm(this.nodeInfoDS, cpbTreeView.FocusedNode.GetValue("ID").ToString());
                endPointForm.StartPosition = FormStartPosition.CenterParent;
                endPointForm.ShowDialog();
            }
           
        }

        private void rightChangeItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isExpanded = this.cpbTreeView.FocusedNode.Expanded;
            ChangeNodeForm changeForm = new ChangeNodeForm(this.nodeInfoDS, this.cpbTreeView.FocusedNode);
            changeForm.StartPosition = FormStartPosition.CenterParent;
            this.cpbTreeView.NodeChanged -= cpbTreeView_NodeChanged;
             changeForm.ShowDialog();
            
            this.cpbTreeView.NodeChanged += cpbTreeView_NodeChanged;

            //restore the expanded status
            if (isExpanded)
            {
                this.cpbTreeView.FocusedNode.ExpandAll();
            }
        }

        private void rightDelItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            cpbTreeView.DeleteNode(cpbTreeView.FocusedNode);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkEdit1.Checked)
            {
                if (string.IsNullOrEmpty(currentNodeIp))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("请先选择需要开启GPS的通道板节点");
                    checkEdit1.CheckedChanged -= checkEdit1_CheckedChanged;
                    checkEdit1.Checked = false;
                    checkEdit1.CheckedChanged += checkEdit1_CheckedChanged;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("应保证GPS模块上电至少一分钟且间隔不应过短(3s)，确保时间准确！");
                    protocalAgent.SendCMD("set gps on", currentNodeIp);
                    DevExpress.XtraEditors.XtraMessageBox.Show("GPS开启");
                }
                
            }
            else
            {
                if (string.IsNullOrEmpty(currentNodeIp))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("请先选择需要关闭GPS的通道板节点");
                    checkEdit1.CheckedChanged -= checkEdit1_CheckedChanged;
                    checkEdit1.Checked = true;
                    checkEdit1.CheckedChanged += checkEdit1_CheckedChanged;
                }
                else
                {
                    protocalAgent.SendCMD("set gps off", currentNodeIp);
                    DevExpress.XtraEditors.XtraMessageBox.Show("GPS关闭");
                }
            
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(currentNodeIp))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请先选择需要获取GPS时间的通道板节点");
            }
            else
            {
                protocalAgent.SendCMD("get gps",currentNodeIp);
                gpsTimeoutTicker.Start();
               
            }
           
        }

        private void timeEdit1_Click(object sender, EventArgs e)
        {
            if (this.timeEdit1.IsPopupOpen == false)
            {
                this.timeEdit1.ShowPopup();
            }
        }

        private void rightRefreshItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            if ( this.cpbTreeView.FocusedNode != null )
            {
                string newIP =  this.cpbTreeView.FocusedNode.GetValue("ID").ToString();
                // MessageBox.Show(newIP);

                if ( newIP != currentNodeIp)
                {
                    if (MessageBox.Show(string.Format("确定要切换到{0}么？", newIP), "警告", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                    {
                        // if cancel, we do nothing
                        return;
                    }

                    //stop current time increasing.
                    this.cpbTimeTicker.Stop();

                    currentNodeIp = newIP;
                    isEdited = false;
                    editingRow = -1;

                    this.updateInfoBtn.Enabled = false;
                    this.cancelInfoChangeBtn.Enabled = false;

                    this.DisableRowStateHelper.DisabledRows.Clear();
                    this.ChangedRowStateHelper.DisabledRows.Clear();

                    this.nodeInfoDS.DispNodeInfo.Rows[0]["Temp"] = "__._";
                    this.nodeInfoDS.DispNodeInfo.Rows[0]["Voltage"] = "__._";
                    this.nodeInfoDS.DispNodeInfo.Rows[0]["GPSTime"] = "____-__-__ __:__:__";
                    this.nodeInfoDS.DispNodeInfo.Rows[0]["DateTime"] = "____-__-__ __:__:__";
                    this.nodeInfoDS.DispNodeInfo.Rows[0]["Version"] = "_._._";

                    this.nodeInfoDS.NodeTimeInfo.Rows.Clear();

                    this.timeEdit1.Time = DateTime.Now;


                    if (currentNodeIp != string.Empty)
                    {

                        this.powerTimeoutTicker.Start();
                        this.protocalAgent.SendCMD("get power", currentNodeIp);
                        
                     
                    
                    }
                }
                else
                {

                     isEdited = false;
                     editingRow = -1;

                     this.updateInfoBtn.Enabled = false;
                     this.cancelInfoChangeBtn.Enabled = false;

                     this.DisableRowStateHelper.DisabledRows.Clear();
                     this.ChangedRowStateHelper.DisabledRows.Clear();

                     this.nodeInfoDS.NodeTimeInfo.Rows.Clear();


                    if (currentNodeIp != string.Empty)
                    {
                        this.powerTimeoutTicker.Start();
                        this.protocalAgent.SendCMD("get power", currentNodeIp);
                        
                     
                    }
                    
                }

            }
                   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            nodeInfoDS.NodeTimeInfo.Rows.Add(1, false, null, null, "11", "test1", "192.168.1.100", 1, true);
            nodeInfoDS.NodeTimeInfo.Rows.Add(2, false, null, null, "11", "3d", "192.168.1.100", 1, false);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (currentNodeIp != string.Empty)
            {
                this.protocalAgent.SendCMD("set rtc2utc", currentNodeIp);
                this.protocalAgent.SendCMD("get time", currentNodeIp);
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请选择节点后操作");
            }

        }

        private void helpBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help.ShowHelp(this, @".\help.chm", HelpNavigator.KeywordIndex, "MegaSet V2帮助文档");
           
        }

        private void rightIPchangeItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isExpanded = this.cpbTreeView.FocusedNode.Expanded;
            ChangeIPForm changeForm = new ChangeIPForm(this.nodeInfoDS, this.cpbTreeView.FocusedNode);
            changeForm.StartPosition = FormStartPosition.CenterParent;
            this.cpbTreeView.NodeChanged -= cpbTreeView_NodeChanged;
            if (changeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.protocalAgent.SendCMD("set ip " + this.cpbTreeView.FocusedNode.GetValue("ID").ToString(), currentNodeIp);
                currentNodeIp = this.cpbTreeView.FocusedNode.GetValue("ID").ToString();
                DevExpress.XtraEditors.XtraMessageBox.Show("修改成功！请等待硬件重启后即可使用新IP地址访问");
                this.cpbTreeView.Refresh();
            }

            this.cpbTreeView.NodeChanged += cpbTreeView_NodeChanged;

            //restore the expanded status
            if (isExpanded)
            {
                this.cpbTreeView.FocusedNode.ExpandAll();
            }
        }

        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LicenseForm licenseWin = new LicenseForm();
            licenseWin.StartPosition = FormStartPosition.CenterParent;
            licenseWin.ShowDialog();
        }

      
       
       

    }
}