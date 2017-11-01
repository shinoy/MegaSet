using DevExpress.XtraTreeList.Nodes;
using System.Data;
using System;

namespace MegaSet
{
    partial class Form1
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int editingRow = -1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            this.nodeInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.nodeInfoDSBindingSource = new System.Windows.Forms.BindingSource();
            this.nodeInfoDS = new MegaSet.NodeInfoDS();
            this.repositoryItemTimeSpanEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.openFileBtn = new DevExpress.XtraBars.BarButtonItem();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.datetimeInfo = new DevExpress.XtraBars.BarStaticItem();
            this.updateInfoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.addUserBtn = new DevExpress.XtraBars.BarButtonItem();
            this.helpBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.cancelInfoChangeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection();
            this.fileRibbonPage1 = new DevExpress.XtraScheduler.UI.FileRibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSkins = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.CPBbar = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.cpbTreeView = new DevExpress.XtraTreeList.TreeList();
            this.AddressName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cpbInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection();
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage();
            this.schedulerSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nodeTimeInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.TimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.DurationColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeSpanEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gaugeControl5 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge5 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent6 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.dispNodeInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gaugeControl4 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gaugeControl3 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge4 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent5 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TimeGauge = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge3 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent4 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.DisableRowStateHelper = new MegaSet.RowStateHelper();
            this.ChangedRowStateHelper = new MegaSet.RowStateHelper();
            this.button1 = new System.Windows.Forms.Button();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.nodeInfoBindingSource1 = new System.Windows.Forms.BindingSource();
            this.digitalBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbTreeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).BeginInit();
            this.schedulerSplitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeTimeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispNodeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gaugeControl2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).BeginInit();
            this.SuspendLayout();
            // 
            // nodeInfoBindingSource
            // 
            this.nodeInfoBindingSource.DataMember = "NodeInfo";
            this.nodeInfoBindingSource.DataSource = this.nodeInfoDSBindingSource;
            // 
            // nodeInfoDSBindingSource
            // 
            this.nodeInfoDSBindingSource.DataSource = this.nodeInfoDS;
            this.nodeInfoDSBindingSource.Position = 0;
            // 
            // nodeInfoDS
            // 
            this.nodeInfoDS.DataSetName = "NodeInfoDS";
            this.nodeInfoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemTimeSpanEdit1
            // 
            this.repositoryItemTimeSpanEdit1.AllowEditDays = false;
            this.repositoryItemTimeSpanEdit1.AutoHeight = false;
            this.repositoryItemTimeSpanEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeSpanEdit1.LookAndFeel.SkinName = "VS2010";
            this.repositoryItemTimeSpanEdit1.Mask.EditMask = "HH:mm:ss";
            this.repositoryItemTimeSpanEdit1.Name = "repositoryItemTimeSpanEdit1";
            // 
            // ribbonControl
            // 
            this.ribbonControl.AllowKeyTips = false;
            this.ribbonControl.AllowMinimizeRibbon = false;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbonControl.ApplicationIcon")));
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.iHelp,
            this.iAbout,
            this.rgbiSkins,
            this.openFileBtn,
            this.saveBtn,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.datetimeInfo,
            this.updateInfoBtn,
            this.barButtonGroup1,
            this.addUserBtn,
            this.helpBtn,
            this.barButtonItem7,
            this.cancelInfoChangeBtn});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 7;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.ribbonPageSkins});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(1071, 147);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iHelp);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(15, "document_save_2_256px_539656_easyicon.net.png");
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Help";
            this.iHelp.Description = "Start the program help system.";
            this.iHelp.Hint = "Start the program help system";
            this.iHelp.Id = 22;
            this.iHelp.ImageIndex = 7;
            this.iHelp.LargeImageIndex = 7;
            this.iHelp.Name = "iHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "About";
            this.iAbout.Description = "V2.0";
            this.iAbout.Id = 24;
            this.iAbout.ImageIndex = 8;
            this.iAbout.LargeImageIndex = 8;
            this.iAbout.Name = "iAbout";
            this.iAbout.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Caption = "导入站点";
            this.openFileBtn.Id = 3;
            this.openFileBtn.LargeImageIndex = 2;
            this.openFileBtn.Name = "openFileBtn";
            toolTipItem1.Text = "从备份的配置文件导入所有节点信息";
            superToolTip1.Items.Add(toolTipItem1);
            this.openFileBtn.SuperTip = superToolTip1;
            this.openFileBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.openScheduleItem1_ItemClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Caption = "导出站点";
            this.saveBtn.Id = 1;
            this.saveBtn.LargeImageIndex = 8;
            this.saveBtn.Name = "saveBtn";
            toolTipItem2.Text = "备份所有节点信息";
            superToolTip2.Items.Add(toolTipItem2);
            this.saveBtn.SuperTip = superToolTip2;
            this.saveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBtn_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "添加子节点";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeImageIndex = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            toolTipItem3.Text = "添加节点信息，节点描述不超过5个字符";
            superToolTip3.Items.Add(toolTipItem3);
            this.barButtonItem1.SuperTip = superToolTip3;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "删除节点";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.LargeImageIndex = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            toolTipItem4.Text = "删除当前选中的地区或节点";
            superToolTip4.Items.Add(toolTipItem4);
            this.barButtonItem2.SuperTip = superToolTip4;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "添加根节点";
            this.barButtonItem3.Id = 1;
            this.barButtonItem3.LargeImageIndex = 0;
            this.barButtonItem3.Name = "barButtonItem3";
            toolTipItem5.Text = "添加地区名称，最长不超过10个字符";
            superToolTip5.Items.Add(toolTipItem5);
            this.barButtonItem3.SuperTip = superToolTip5;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "管理密码";
            this.barButtonItem4.Id = 2;
            this.barButtonItem4.LargeImageIndex = 1;
            this.barButtonItem4.Name = "barButtonItem4";
            toolTipItem6.Text = "修改软件登陆密码";
            superToolTip6.Items.Add(toolTipItem6);
            this.barButtonItem4.SuperTip = superToolTip6;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "默认设置";
            this.barButtonItem5.Id = 3;
            this.barButtonItem5.LargeImageIndex = 11;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // datetimeInfo
            // 
            this.datetimeInfo.Caption = "barStaticItem1";
            this.datetimeInfo.Id = 4;
            this.datetimeInfo.Name = "datetimeInfo";
            this.datetimeInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // updateInfoBtn
            // 
            this.updateInfoBtn.Caption = "更新定时表";
            this.updateInfoBtn.Enabled = false;
            this.updateInfoBtn.Id = 5;
            this.updateInfoBtn.LargeImageIndex = 3;
            this.updateInfoBtn.Name = "updateInfoBtn";
            toolTipItem7.Text = "更新当前节点的定时表";
            superToolTip7.Items.Add(toolTipItem7);
            this.updateInfoBtn.SuperTip = superToolTip7;
            this.updateInfoBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonGroup1.Id = 1;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // addUserBtn
            // 
            this.addUserBtn.Caption = "用户管理";
            this.addUserBtn.Id = 2;
            this.addUserBtn.LargeImageIndex = 11;
            this.addUserBtn.Name = "addUserBtn";
            toolTipItem8.Text = "管理用户信息";
            superToolTip8.Items.Add(toolTipItem8);
            this.addUserBtn.SuperTip = superToolTip8;
            this.addUserBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addUserBtn_ItemClick);
            // 
            // helpBtn
            // 
            this.helpBtn.Caption = "帮助";
            this.helpBtn.Id = 4;
            this.helpBtn.LargeImageIndex = 12;
            this.helpBtn.Name = "helpBtn";
            toolTipItem9.Text = "显示帮助信息";
            superToolTip9.Items.Add(toolTipItem9);
            this.helpBtn.SuperTip = superToolTip9;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "修改节点";
            this.barButtonItem7.Id = 5;
            this.barButtonItem7.LargeImageIndex = 13;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // cancelInfoChangeBtn
            // 
            this.cancelInfoChangeBtn.Caption = "取消更改";
            this.cancelInfoChangeBtn.Enabled = false;
            this.cancelInfoChangeBtn.Id = 6;
            this.cancelInfoChangeBtn.LargeImageIndex = 14;
            this.cancelInfoChangeBtn.Name = "cancelInfoChangeBtn";
            this.cancelInfoChangeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelInfoChangeBtn_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "region3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "change_password_128px_1077753_easyicon.net.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "document_save_3232.net.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Software_Update_3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "document_export_more_3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "document_import_3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "point_add_3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "delete_3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "export_3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "add_user3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "delete_user3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "usermgmt3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(12, "help3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(13, "modify3232.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(14, "cancel3232.png");
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Appearance.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileRibbonPage1.Appearance.Options.UseFont = true;
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            this.fileRibbonPage1.Text = "功能";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.openFileBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.saveBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "配置信息";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup2.ItemLinks.Add(this.updateInfoBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.cancelInfoChangeBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "节点管理";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.addUserBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.helpBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "软件管理";
            // 
            // ribbonPageSkins
            // 
            this.ribbonPageSkins.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.skinsRibbonPageGroup});
            this.ribbonPageSkins.Name = "ribbonPageSkins";
            this.ribbonPageSkins.Text = "皮肤";
            // 
            // skinsRibbonPageGroup
            // 
            this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
            this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
            this.skinsRibbonPageGroup.ShowCaptionButton = false;
            this.skinsRibbonPageGroup.Text = "皮肤";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.datetimeInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 694);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1071, 31);
            // 
            // CPBbar
            // 
            this.CPBbar.Caption = "站点信息";
            this.CPBbar.ControlContainer = this.navBarGroupControlContainer1;
            this.CPBbar.Expanded = true;
            this.CPBbar.GroupClientHeight = 461;
            this.CPBbar.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.CPBbar.LargeImageIndex = 2;
            this.CPBbar.Name = "CPBbar";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.cpbTreeView);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(240, 461);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // cpbTreeView
            // 
            this.cpbTreeView.AllowDrop = true;
            this.cpbTreeView.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver;
            this.cpbTreeView.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cpbTreeView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.cpbTreeView.Appearance.FocusedCell.Options.UseFont = true;
            this.cpbTreeView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.AddressName});
            this.cpbTreeView.DataSource = this.cpbInfoBindingSource;
            this.cpbTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpbTreeView.ImageIndexFieldName = "NodeImage";
            this.cpbTreeView.Location = new System.Drawing.Point(0, 0);
            this.cpbTreeView.Name = "cpbTreeView";
            this.cpbTreeView.OptionsBehavior.Editable = false;
            this.cpbTreeView.OptionsView.ShowColumns = false;
            this.cpbTreeView.OptionsView.ShowHorzLines = false;
            this.cpbTreeView.OptionsView.ShowIndicator = false;
            this.cpbTreeView.OptionsView.ShowVertLines = false;
            this.cpbTreeView.RootValue = "0";
            this.cpbTreeView.SelectImageList = this.navbarImageCollection;
            this.cpbTreeView.Size = new System.Drawing.Size(240, 461);
            this.cpbTreeView.TabIndex = 0;
            // 
            // AddressName
            // 
            this.AddressName.Caption = "Address";
            this.AddressName.FieldName = "Address";
            this.AddressName.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.AddressName.MinWidth = 52;
            this.AddressName.Name = "AddressName";
            this.AddressName.Visible = true;
            this.AddressName.VisibleIndex = 0;
            // 
            // cpbInfoBindingSource
            // 
            this.cpbInfoBindingSource.DataMember = "cpbInfo";
            this.cpbInfoBindingSource.DataSource = this.nodeInfoDSBindingSource;
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollection.Images.SetKeyName(0, "Network_Earth_icon_256px_1073230_easyicon.net.png");
            this.navbarImageCollection.Images.SetKeyName(1, "pcb1616.png");
            this.navbarImageCollection.Images.SetKeyName(2, "good1616.png");
            this.navbarImageCollection.Images.SetKeyName(3, "break1616.png");
            this.navbarImageCollection.Images.SetKeyName(4, "break.png");
            this.navbarImageCollection.Images.SetKeyName(5, "good1616.png");
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollectionLarge.Images.SetKeyName(0, "camera3232.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(1, "Company3232.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(2, "pcb32x32.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(3, "break3232.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(4, "good3232.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(5, "break.png");
            // 
            // schedulerSplitContainerControl
            // 
            this.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.schedulerSplitContainerControl.IsSplitterFixed = true;
            this.schedulerSplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl";
            this.schedulerSplitContainerControl.Panel1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerSplitContainerControl.Panel1.Appearance.Options.UseFont = true;
            this.schedulerSplitContainerControl.Panel1.Controls.Add(this.gridSplitContainer1);
            this.schedulerSplitContainerControl.Panel1.Text = "Panel1";
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.panelControl5);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.panelControl4);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.panelControl3);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.groupControl3);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.groupControl1);
            this.schedulerSplitContainerControl.Panel2.Text = "Panel2";
            this.schedulerSplitContainerControl.Size = new System.Drawing.Size(826, 547);
            this.schedulerSplitContainerControl.SplitterPosition = 450;
            this.schedulerSplitContainerControl.TabIndex = 2;
            this.schedulerSplitContainerControl.Text = "splitContainerControl1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(371, 547);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nodeTimeInfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeSpanEdit2,
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemTimeEdit1});
            this.gridControl1.Size = new System.Drawing.Size(371, 547);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nodeTimeInfoBindingSource
            // 
            this.nodeTimeInfoBindingSource.DataMember = "NodeTimeInfo";
            this.nodeTimeInfoBindingSource.DataSource = this.nodeInfoDSBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.StatusColumn,
            this.DateColumn,
            this.TimeColumn,
            this.DurationColumn,
            this.gridColumn2,
            this.GroupID,
            this.typeColumn});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsHint.ShowColumnHeaderHints = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 40;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.typeColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "组别";
            this.gridColumn1.FieldName = "GroupName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Caption = "状态";
            this.StatusColumn.FieldName = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Visible = true;
            this.StatusColumn.VisibleIndex = 1;
            this.StatusColumn.Width = 40;
            // 
            // DateColumn
            // 
            this.DateColumn.Caption = "日期";
            this.DateColumn.ColumnEdit = this.repositoryItemDateEdit1;
            this.DateColumn.FieldName = "StartTime";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.OptionsColumn.AllowEdit = false;
            this.DateColumn.Visible = true;
            this.DateColumn.VisibleIndex = 2;
            this.DateColumn.Width = 110;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "yy-mm-dd";
            this.repositoryItemDateEdit1.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // TimeColumn
            // 
            this.TimeColumn.Caption = "起始时间";
            this.TimeColumn.ColumnEdit = this.repositoryItemTimeEdit1;
            this.TimeColumn.DisplayFormat.FormatString = "hh:mm:ss";
            this.TimeColumn.FieldName = "StartTime";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.Visible = true;
            this.TimeColumn.VisibleIndex = 3;
            this.TimeColumn.Width = 110;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.DisplayFormat.FormatString = "hh:mm:ss";
            this.repositoryItemTimeEdit1.EditFormat.FormatString = "hh:mm:ss";
            this.repositoryItemTimeEdit1.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.repositoryItemTimeEdit1.Mask.IgnoreMaskBlank = false;
            this.repositoryItemTimeEdit1.Mask.PlaceHolder = '*';
            this.repositoryItemTimeEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            this.repositoryItemTimeEdit1.NullText = "--:--:--";
            this.repositoryItemTimeEdit1.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            // 
            // DurationColumn
            // 
            this.DurationColumn.Caption = "中止时间";
            this.DurationColumn.ColumnEdit = this.repositoryItemTimeEdit1;
            this.DurationColumn.DisplayFormat.FormatString = "hh:mm:ss";
            this.DurationColumn.FieldName = "EndTime";
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.Visible = true;
            this.DurationColumn.VisibleIndex = 4;
            this.DurationColumn.Width = 118;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IP";
            this.gridColumn2.FieldName = "IP";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // GroupID
            // 
            this.GroupID.Caption = "gridColumn3";
            this.GroupID.FieldName = "GroupID";
            this.GroupID.Name = "GroupID";
            // 
            // typeColumn
            // 
            this.typeColumn.Caption = "类型";
            this.typeColumn.FieldName = "TypeName";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Visible = true;
            this.typeColumn.VisibleIndex = 5;
            // 
            // repositoryItemTimeSpanEdit2
            // 
            this.repositoryItemTimeSpanEdit2.AllowEditDays = false;
            this.repositoryItemTimeSpanEdit2.AutoHeight = false;
            this.repositoryItemTimeSpanEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeSpanEdit2.Mask.EditMask = "HH:mm:ss";
            this.repositoryItemTimeSpanEdit2.Name = "repositoryItemTimeSpanEdit2";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.groupControl5);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(302, 336);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(148, 211);
            this.panelControl5.TabIndex = 27;
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl5.Appearance.Options.UseFont = true;
            this.groupControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl5.CaptionImage = global::MegaSet.Properties.Resources.ver3232;
            this.groupControl5.Controls.Add(this.simpleButton12);
            this.groupControl5.Controls.Add(this.simpleButton11);
            this.groupControl5.Controls.Add(this.panel5);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(2, 2);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(144, 207);
            this.groupControl5.TabIndex = 27;
            this.groupControl5.Text = "版本/控制";
            // 
            // simpleButton12
            // 
            this.simpleButton12.Location = new System.Drawing.Point(39, 143);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(67, 21);
            this.simpleButton12.TabIndex = 19;
            this.simpleButton12.Text = "重启";
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Location = new System.Drawing.Point(39, 112);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(67, 21);
            this.simpleButton11.TabIndex = 18;
            this.simpleButton11.Text = "刷新";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gaugeControl5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(2, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 57);
            this.panel5.TabIndex = 17;
            // 
            // gaugeControl5
            // 
            this.gaugeControl5.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl5.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge5});
            this.gaugeControl5.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl5.Name = "gaugeControl5";
            this.gaugeControl5.Size = new System.Drawing.Size(140, 57);
            this.gaugeControl5.TabIndex = 17;
            // 
            // digitalGauge5
            // 
            this.digitalGauge5.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E3E5EA");
            this.digitalGauge5.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#59616F");
            this.digitalGauge5.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent6});
            this.digitalGauge5.Bounds = new System.Drawing.Rectangle(6, 6, 128, 45);
            this.digitalGauge5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dispNodeInfoBindingSource, "Version", true));
            this.digitalGauge5.DigitCount = 3;
            this.digitalGauge5.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalGauge5.Name = "digitalGauge5";
            this.digitalGauge5.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGauge5.Text = "_._._";
            // 
            // digitalBackgroundLayerComponent6
            // 
            this.digitalBackgroundLayerComponent6.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(164.825F, 106.075F);
            this.digitalBackgroundLayerComponent6.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style18;
            this.digitalBackgroundLayerComponent6.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent6.ZOrder = 1000;
            // 
            // dispNodeInfoBindingSource
            // 
            this.dispNodeInfoBindingSource.DataMember = "DispNodeInfo";
            this.dispNodeInfoBindingSource.DataSource = this.nodeInfoDSBindingSource;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.groupControl4);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.Location = new System.Drawing.Point(149, 336);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(153, 211);
            this.panelControl4.TabIndex = 26;
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.AutoSize = true;
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl4.CaptionImage = global::MegaSet.Properties.Resources.thermograph3232;
            this.groupControl4.Controls.Add(this.simpleButton10);
            this.groupControl4.Controls.Add(this.panel1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(2, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(149, 207);
            this.groupControl4.TabIndex = 26;
            this.groupControl4.Text = "温度(C)";
            // 
            // simpleButton10
            // 
            this.simpleButton10.Location = new System.Drawing.Point(41, 126);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(67, 21);
            this.simpleButton10.TabIndex = 15;
            this.simpleButton10.Text = "刷新";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gaugeControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 64);
            this.panel1.TabIndex = 1;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(145, 64);
            this.gaugeControl1.TabIndex = 0;
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FFF5000");
            this.digitalGauge1.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF5000");
            this.digitalGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.digitalGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 133, 52);
            this.digitalGauge1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dispNodeInfoBindingSource, "Temp", true));
            this.digitalGauge1.DigitCount = 3;
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Text = "__._";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(163.8875F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "bg1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(0, 336);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(149, 211);
            this.panelControl3.TabIndex = 25;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl2.CaptionImage = global::MegaSet.Properties.Resources.voltage3232;
            this.groupControl2.Controls.Add(this.panel2);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(145, 207);
            this.groupControl2.TabIndex = 25;
            this.groupControl2.Text = "电压（伏）";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gaugeControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 62);
            this.panel2.TabIndex = 3;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.Controls.Add(this.panel3);
            this.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl2.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(141, 62);
            this.gaugeControl2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gaugeControl4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 64);
            this.panel3.TabIndex = 23;
            // 
            // gaugeControl4
            // 
            this.gaugeControl4.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl4.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge2});
            this.gaugeControl4.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl4.Name = "gaugeControl4";
            this.gaugeControl4.Size = new System.Drawing.Size(141, 64);
            this.gaugeControl4.TabIndex = 0;
            // 
            // digitalGauge2
            // 
            this.digitalGauge2.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FFF5000");
            this.digitalGauge2.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF5000");
            this.digitalGauge2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent3});
            this.digitalGauge2.Bounds = new System.Drawing.Rectangle(6, 6, 129, 52);
            this.digitalGauge2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dispNodeInfoBindingSource, "Voltage", true));
            this.digitalGauge2.DigitCount = 3;
            this.digitalGauge2.Name = "digitalGauge2";
            this.digitalGauge2.Text = "__._";
            // 
            // digitalBackgroundLayerComponent3
            // 
            this.digitalBackgroundLayerComponent3.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(163.8875F, 99.9625F);
            this.digitalBackgroundLayerComponent3.Name = "bg1";
            this.digitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3;
            this.digitalBackgroundLayerComponent3.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(40, 126);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(67, 21);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "刷新";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl3.CaptionImage = global::MegaSet.Properties.Resources.gps3232;
            this.groupControl3.Controls.Add(this.simpleButton8);
            this.groupControl3.Controls.Add(this.panelControl2);
            this.groupControl3.Controls.Add(this.simpleButton9);
            this.groupControl3.Controls.Add(this.checkEdit1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 168);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(450, 168);
            this.groupControl3.TabIndex = 24;
            this.groupControl3.Text = "GPS时间";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(266, 120);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(93, 30);
            this.simpleButton8.TabIndex = 24;
            this.simpleButton8.Text = "校准时间";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.gaugeControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(446, 73);
            this.panelControl2.TabIndex = 6;
            // 
            // gaugeControl3
            // 
            this.gaugeControl3.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl3.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge4});
            this.gaugeControl3.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl3.Name = "gaugeControl3";
            this.gaugeControl3.Size = new System.Drawing.Size(446, 73);
            this.gaugeControl3.TabIndex = 23;
            // 
            // digitalGauge4
            // 
            this.digitalGauge4.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#233342");
            this.digitalGauge4.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#39A7CE");
            this.digitalGauge4.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent5});
            this.digitalGauge4.Bounds = new System.Drawing.Rectangle(6, 6, 434, 61);
            this.digitalGauge4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dispNodeInfoBindingSource, "GPSTime", true));
            this.digitalGauge4.DigitCount = 15;
            this.digitalGauge4.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalGauge4.Name = "digitalGauge4";
            this.digitalGauge4.Text = "2017-11-22 21:23:33";
            // 
            // digitalBackgroundLayerComponent5
            // 
            this.digitalBackgroundLayerComponent5.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(714.1251F, 106.075F);
            this.digitalBackgroundLayerComponent5.Name = "bg1";
            this.digitalBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style19;
            this.digitalBackgroundLayerComponent5.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent5.ZOrder = 1000;
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(156, 120);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(93, 30);
            this.simpleButton9.TabIndex = 10;
            this.simpleButton9.Text = "获取GPS时间";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(15, 123);
            this.checkEdit1.MenuManager = this.ribbonControl;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "GPS开启";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style16;
            this.checkEdit1.Size = new System.Drawing.Size(86, 22);
            this.checkEdit1.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.timeEdit1);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(450, 168);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "当前节点时间";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(330, 118);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(93, 30);
            this.simpleButton3.TabIndex = 24;
            this.simpleButton3.Text = "刷新时间";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.TimeGauge);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(446, 73);
            this.panelControl1.TabIndex = 6;
            // 
            // TimeGauge
            // 
            this.TimeGauge.BackColor = System.Drawing.Color.Transparent;
            this.TimeGauge.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TimeGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeGauge.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge3});
            this.TimeGauge.Location = new System.Drawing.Point(0, 0);
            this.TimeGauge.Name = "TimeGauge";
            this.TimeGauge.Size = new System.Drawing.Size(446, 73);
            this.TimeGauge.TabIndex = 23;
            // 
            // digitalGauge3
            // 
            this.digitalGauge3.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF");
            this.digitalGauge3.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke");
            this.digitalGauge3.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent4});
            this.digitalGauge3.Bounds = new System.Drawing.Rectangle(6, 6, 434, 61);
            this.digitalGauge3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dispNodeInfoBindingSource, "DateTime", true));
            this.digitalGauge3.DigitCount = 15;
            this.digitalGauge3.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalGauge3.Name = "digitalGauge3";
            this.digitalGauge3.Text = "__-__-__ __:__:__";
            // 
            // digitalBackgroundLayerComponent4
            // 
            this.digitalBackgroundLayerComponent4.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(714.1251F, 106.075F);
            this.digitalBackgroundLayerComponent4.Name = "bg1";
            this.digitalBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style10;
            this.digitalBackgroundLayerComponent4.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent4.ZOrder = 1000;
            // 
            // timeEdit1
            // 
            this.timeEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeEdit1.EditValue = new System.DateTime(2017, 10, 28, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(21, 118);
            this.timeEdit1.MenuManager = this.ribbonControl;
            this.timeEdit1.MinimumSize = new System.Drawing.Size(0, 30);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.timeEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.timeEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.timeEdit1.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.timeEdit1.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.timeEdit1.ShowToolTips = false;
            this.timeEdit1.Size = new System.Drawing.Size(160, 22);
            this.timeEdit1.TabIndex = 22;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(207, 118);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 30);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "设置时间";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DisableRowStateHelper
            // 
            this.DisableRowStateHelper.AppearanceDisabledRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DisableRowStateHelper.AppearanceDisabledRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisableRowStateHelper.AppearanceDisabledRow.ForeColor = System.Drawing.Color.Gray;
            this.DisableRowStateHelper.AppearanceDisabledRow.Options.UseBackColor = true;
            this.DisableRowStateHelper.AppearanceDisabledRow.Options.UseFont = true;
            this.DisableRowStateHelper.AppearanceDisabledRow.Options.UseForeColor = true;
            this.DisableRowStateHelper.GridView = this.gridView1;
            this.DisableRowStateHelper.ReadonlyRow = true;
            // 
            // ChangedRowStateHelper
            // 
            this.ChangedRowStateHelper.AppearanceDisabledRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangedRowStateHelper.AppearanceDisabledRow.ForeColor = System.Drawing.Color.Red;
            this.ChangedRowStateHelper.AppearanceDisabledRow.Options.UseBackColor = true;
            this.ChangedRowStateHelper.AppearanceDisabledRow.Options.UseFont = true;
            this.ChangedRowStateHelper.AppearanceDisabledRow.Options.UseForeColor = true;
            this.ChangedRowStateHelper.GridView = this.gridView1;
            this.ChangedRowStateHelper.ReadonlyRow = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.CPBbar;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.CPBbar});
            this.navBarControl1.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 240;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(240, 547);
            this.navBarControl1.SmallImages = this.navbarImageCollection;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 147);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.schedulerSplitContainerControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1071, 547);
            this.splitContainerControl.SplitterPosition = 240;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // nodeInfoBindingSource1
            // 
            this.nodeInfoBindingSource1.DataMember = "NodeInfo";
            this.nodeInfoBindingSource1.DataSource = this.nodeInfoDSBindingSource;
            // 
            // digitalBackgroundLayerComponent2
            // 
            this.digitalBackgroundLayerComponent2.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(211.85F, 99.9625F);
            this.digitalBackgroundLayerComponent2.Name = "bg1";
            this.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3;
            this.digitalBackgroundLayerComponent2.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 725);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MegaSet V2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpbTreeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).EndInit();
            this.schedulerSplitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeTimeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispNodeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gaugeControl2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {

            if (! this.cancelInfoChangeBtn.Enabled)
            {
                isEdited = false; // user leave previous row without any change, so we think the edit mode cancelled; if value changed, we disable the other rows already, so keep in edit mode to persist backup table
            }

            //  **********  TBD currently we don't use this.******
         
            //if (isEdited != true)
            //{
            //    return;
            //}
            //if (System.Windows.Forms.MessageBox.Show("当前定时信息已经改变，'确定'更新到节点或'取消'取消更改", "定时信息更改", System.Windows.Forms.MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //{
            //    System.Windows.Forms.MessageBox.Show("提交");
            //}
            //else
            //{
            //    e.Allow = false;
            //    nodeInfoDS.NodeTimeInfo.Rows.Remove(this.nodeInfoDS.NodeTimeInfo.Select(string.Format("IP = '{0}' and GroupName = '{1}'", backupTable.Rows[0]["IP"], backupTable.Rows[0]["GroupName"]))[0]);
            //    this.nodeInfoDS.NodeTimeInfo.ImportRow(backupTable.Rows[0]);
            //}
           
        }

    
        void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
         
            int currentRowIndex = gridView1.GetDataSourceRowIndex(e.RowHandle);

            int totalIndex = this.gridView1.RowCount;

            for (int index = 0; index < totalIndex; index++)
            {
                if (index != currentRowIndex)
                {
                    this.DisableRowStateHelper.DisabledRows.Add(index);
                }
                else
                {
                    this.ChangedRowStateHelper.DisabledRows.Add(index);
                    editingRow = index;
                }
            }
            this.nodeInfoDS.NodeTimeInfo.AcceptChanges();
            this.gridView1.UpdateSummary();

           
            //this.gridView1.UpdateSummary();

            //if (e.Column.FieldName != "StartTime" && e.Column.FieldName != "EndTime")
            //    return;

            //NodeInfoDS.NodeTimeInfoRow row = nodeInfoDS.NodeTimeInfo.Select(String.Format("GroupName = '{0}'",e.Column.))
                
                
            //    (NodeInfoDS.NodeTimeInfoRow)( this.gridView1.GetRow(e.RowHandle));


            //if (row != null && !row.IsStartTimeNull() && !row.IsEndTimeNull())
            //{
                
            //    row.StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, row.StartTime.Hour, row.StartTime.Minute, row.StartTime.Second);

            //    DateTime newTime = new DateTime(row.StartTime.Year, row.StartTime.Month, row.StartTime.Day, row.EndTime.Hour, row.EndTime.Minute, row.EndTime.Second);
            //    if (newTime.CompareTo(row.StartTime) <= 0)
            //    {
            //        row.EndTime = row.StartTime.AddMinutes(1);
            //    }
            //    else
            //    {
            //        row.EndTime = newTime;
            //    }

            //    TimeSpan interval = row.EndTime - row.StartTime;
            //    row.Duration = ((Int32)interval.TotalSeconds).ToString();
            //}
            
          

        }

        
        void cpbTreeView_NodeChanged(object sender, DevExpress.XtraTreeList.NodeChangedEventArgs e)
        {
            if (e.ChangeType == DevExpress.XtraTreeList.NodeChangeTypeEnum.Add)
            {
                if (e.Node.ParentNode != null)
                {
                    e.Node.ParentNode.ExpandAll();
                }
                if (e.Node.Level == 1)
                {
                  //  System.Windows.Forms.MessageBox.Show(e.Node.GetValue("ID").ToString());
                    nodeInfoDS.NodeInfo.Rows.Add(new object[] { e.Node.GetValue("ID").ToString(), "_", "_", "_", "_", "_" });
                }
                    
            }
            if (e.ChangeType == DevExpress.XtraTreeList.NodeChangeTypeEnum.Remove)
            {
                //foreach (DataRow matchRow in nodeInfoDS.NodeInfo.Select(string.Format("IP = '{0}'", e.Node.GetValue("IP"))))
                //{
                //    nodeInfoDS.NodeInfo.Rows.Remove(matchRow);
                //}
            }

            this.nodeInfoDS.NodeTimeInfo.Clear();
            nodeInfoDS.WriteXml(configFileName);
        }

     
    
        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
        private DevExpress.XtraScheduler.UI.FileRibbonPage fileRibbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem openFileBtn;
        private DevExpress.XtraNavBar.NavBarGroup CPBbar;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private System.Windows.Forms.BindingSource nodeInfoDSBindingSource;
        private NodeInfoDS nodeInfoDS;
        private System.Windows.Forms.BindingSource nodeInfoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.SplitContainerControl schedulerSplitContainerControl;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn StatusColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DurationColumn;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraTreeList.TreeList cpbTreeView;
        private DevExpress.XtraTreeList.Columns.TreeListColumn AddressName;
        private System.Windows.Forms.BindingSource nodeInfoBindingSource1;
        private System.Windows.Forms.BindingSource cpbInfoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        //private DevExpress.XtraGrid.Columns.GridColumn GroupColumn;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl5;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge5;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn typeColumn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarStaticItem datetimeInfo;
        private DevExpress.XtraBars.BarButtonItem updateInfoBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem addUserBtn;
        private DevExpress.XtraBars.BarButtonItem helpBtn;
        private System.Windows.Forms.BindingSource dispNodeInfoBindingSource;
        private System.Windows.Forms.BindingSource nodeTimeInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGauges.Win.GaugeControl TimeGauge;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge3;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl3;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge4;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent5;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl4;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge2;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent3;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private RowStateHelper DisableRowStateHelper;
        private RowStateHelper ChangedRowStateHelper;
        private DevExpress.XtraBars.BarButtonItem cancelInfoChangeBtn;
        private DevExpress.XtraGrid.Columns.GridColumn GroupID;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;

    }
}
