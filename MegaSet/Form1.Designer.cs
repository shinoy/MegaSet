using DevExpress.XtraTreeList.Nodes;
using System.Data;

namespace MegaSet
{
    partial class Form1
    {

        private DevExpress.XtraTreeList.Nodes.TreeListNode selectedNode;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
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
            this.nodeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nodeInfoDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nodeInfoDS = new MegaSet.NodeInfoDS();
            this.repositoryItemTimeSpanEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
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
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.addUserBtn = new DevExpress.XtraBars.BarButtonItem();
            this.helpBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
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
            this.cpbInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.schedulerSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dispNodeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.TimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurationColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeSpanEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gaugeControl5 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge5 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent6 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gaugeControl4 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge4 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent5 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gaugeControl3 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge3 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent4 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.button1 = new System.Windows.Forms.Button();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.nodeInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GroupColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.digitalBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispNodeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
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
            this.barButtonItem6,
            this.barButtonGroup1,
            this.addUserBtn,
            this.helpBtn});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 5;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.ribbonPageSkins});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(1143, 149);
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
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "更新定时表";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.LargeImageIndex = 3;
            this.barButtonItem6.Name = "barButtonItem6";
            toolTipItem7.Text = "更新当前节点的定时表";
            superToolTip7.Items.Add(toolTipItem7);
            this.barButtonItem6.SuperTip = superToolTip7;
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 576);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1143, 33);
            // 
            // CPBbar
            // 
            this.CPBbar.Caption = "站点信息";
            this.CPBbar.ControlContainer = this.navBarGroupControlContainer1;
            this.CPBbar.Expanded = true;
            this.CPBbar.GroupClientHeight = 353;
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
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(240, 353);
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
            this.cpbTreeView.Size = new System.Drawing.Size(240, 353);
            this.cpbTreeView.TabIndex = 0;
            this.cpbTreeView.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.cpbTreeView_FocusedNodeChanged);
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
            this.schedulerSplitContainerControl.Panel1.Controls.Add(this.gridControl1);
            this.schedulerSplitContainerControl.Panel1.Text = "Panel1";
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.label3);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.timeEdit1);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.simpleButton7);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.simpleButton6);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.simpleButton5);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.label5);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.panel5);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.simpleButton4);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.simpleButton3);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.simpleButton2);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.checkEdit1);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.simpleButton1);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.label4);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.panel4);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.panel3);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.label2);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.panel2);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.label1);
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.panel1);
            this.schedulerSplitContainerControl.Panel2.Text = "Panel2";
            this.schedulerSplitContainerControl.Size = new System.Drawing.Size(897, 427);
            this.schedulerSplitContainerControl.SplitterPosition = 450;
            this.schedulerSplitContainerControl.TabIndex = 2;
            this.schedulerSplitContainerControl.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dispNodeInfoBindingSource;
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
            this.gridControl1.Size = new System.Drawing.Size(441, 427);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dispNodeInfoBindingSource
            // 
            this.dispNodeInfoBindingSource.DataMember = "DispNodeInfo";
            this.dispNodeInfoBindingSource.DataSource = this.nodeInfoDSBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.StatusColumn,
            this.DateColumn,
            this.TimeColumn,
            this.DurationColumn,
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
            this.gridView1.ViewCaption = "192.168.0.1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "组别";
            this.gridColumn1.FieldName = "GroupName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 73;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Caption = "状态";
            this.StatusColumn.FieldName = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.OptionsColumn.AllowEdit = false;
            this.StatusColumn.Visible = true;
            this.StatusColumn.VisibleIndex = 1;
            this.StatusColumn.Width = 61;
            // 
            // DateColumn
            // 
            this.DateColumn.Caption = "日期";
            this.DateColumn.ColumnEdit = this.repositoryItemTimeEdit1;
            this.DateColumn.FieldName = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.OptionsColumn.AllowEdit = false;
            this.DateColumn.Visible = true;
            this.DateColumn.VisibleIndex = 2;
            this.DateColumn.Width = 90;
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
            this.repositoryItemTimeEdit1.NullText = "_";
            this.repositoryItemTimeEdit1.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
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
            this.TimeColumn.Width = 90;
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
            this.DurationColumn.Width = 90;
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
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "当前时间";
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2017, 10, 28, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(268, 29);
            this.timeEdit1.MenuManager = this.ribbonControl;
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.Mask.EditMask = "G";
            this.timeEdit1.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.timeEdit1.Size = new System.Drawing.Size(145, 20);
            this.timeEdit1.TabIndex = 22;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(268, 348);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(145, 60);
            this.simpleButton7.TabIndex = 21;
            this.simpleButton7.Text = "重启";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(292, 271);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(97, 23);
            this.simpleButton6.TabIndex = 20;
            this.simpleButton6.Text = "刷新温度";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(292, 305);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(97, 23);
            this.simpleButton5.TabIndex = 19;
            this.simpleButton5.Text = "刷新电压";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "软件版本:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gaugeControl5);
            this.panel5.Location = new System.Drawing.Point(79, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(84, 33);
            this.panel5.TabIndex = 17;
            // 
            // gaugeControl5
            // 
            this.gaugeControl5.AutoLayout = false;
            this.gaugeControl5.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl5.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge5});
            this.gaugeControl5.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl5.Name = "gaugeControl5";
            this.gaugeControl5.Size = new System.Drawing.Size(84, 33);
            this.gaugeControl5.TabIndex = 17;
            // 
            // digitalGauge5
            // 
            this.digitalGauge5.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E3E5EA");
            this.digitalGauge5.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#59616F");
            this.digitalGauge5.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent6});
            this.digitalGauge5.Bounds = new System.Drawing.Rectangle(-8, 1, 72, 30);
            this.digitalGauge5.DigitCount = 3;
            this.digitalGauge5.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalGauge5.Name = "digitalGauge5";
            this.digitalGauge5.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGauge5.Text = "V1.7.2";
            // 
            // digitalBackgroundLayerComponent6
            // 
            this.digitalBackgroundLayerComponent6.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(164.825F, 106.075F);
            this.digitalBackgroundLayerComponent6.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style18;
            this.digitalBackgroundLayerComponent6.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent6.ZOrder = 1000;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(344, 196);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(69, 42);
            this.simpleButton4.TabIndex = 16;
            this.simpleButton4.Text = "校准时间";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(268, 100);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(145, 39);
            this.simpleButton3.TabIndex = 15;
            this.simpleButton3.Text = "刷新时间";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(268, 196);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(70, 42);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "GPS时间";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(292, 163);
            this.checkEdit1.MenuManager = this.ribbonControl;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "GPS开启";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style16;
            this.checkEdit1.Size = new System.Drawing.Size(100, 22);
            this.checkEdit1.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(268, 55);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 39);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "设置时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "GPS时间";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gaugeControl4);
            this.panel4.Location = new System.Drawing.Point(54, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 41);
            this.panel4.TabIndex = 8;
            // 
            // gaugeControl4
            // 
            this.gaugeControl4.AutoLayout = false;
            this.gaugeControl4.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl4.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge4});
            this.gaugeControl4.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl4.Name = "gaugeControl4";
            this.gaugeControl4.Size = new System.Drawing.Size(146, 41);
            this.gaugeControl4.TabIndex = 5;
            // 
            // digitalGauge4
            // 
            this.digitalGauge4.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EAECF1");
            this.digitalGauge4.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#7184BA");
            this.digitalGauge4.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent5});
            this.digitalGauge4.Bounds = new System.Drawing.Rectangle(-6, -2, 157, 41);
            this.digitalGauge4.DigitCount = 6;
            this.digitalGauge4.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalGauge4.Name = "digitalGauge4";
            this.digitalGauge4.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGauge4.Text = "92:11:12";
            // 
            // digitalBackgroundLayerComponent5
            // 
            this.digitalBackgroundLayerComponent5.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(303.65F, 106.075F);
            this.digitalBackgroundLayerComponent5.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style16;
            this.digitalBackgroundLayerComponent5.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent5.ZOrder = 1000;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gaugeControl3);
            this.panel3.Location = new System.Drawing.Point(26, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 71);
            this.panel3.TabIndex = 6;
            // 
            // gaugeControl3
            // 
            this.gaugeControl3.AutoLayout = false;
            this.gaugeControl3.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl3.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge3});
            this.gaugeControl3.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl3.Name = "gaugeControl3";
            this.gaugeControl3.Size = new System.Drawing.Size(214, 71);
            this.gaugeControl3.TabIndex = 5;
            // 
            // digitalGauge3
            // 
            this.digitalGauge3.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#404040");
            this.digitalGauge3.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFFFFA");
            this.digitalGauge3.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent4});
            this.digitalGauge3.Bounds = new System.Drawing.Rectangle(-2, 1, 210, 72);
            this.digitalGauge3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nodeInfoBindingSource, "DateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "G"));
            this.digitalGauge3.DigitCount = 10;
            this.digitalGauge3.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalGauge3.Name = "digitalGauge3";
            this.digitalGauge3.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGauge3.Text = "92:11:12";
            // 
            // digitalBackgroundLayerComponent4
            // 
            this.digitalBackgroundLayerComponent4.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(488.75F, 106.075F);
            this.digitalBackgroundLayerComponent4.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style10;
            this.digitalBackgroundLayerComponent4.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent4.ZOrder = 1000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "当前温度";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gaugeControl2);
            this.panel2.Location = new System.Drawing.Point(145, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 56);
            this.panel2.TabIndex = 3;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.AutoLayout = false;
            this.gaugeControl2.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge2});
            this.gaugeControl2.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(99, 56);
            this.gaugeControl2.TabIndex = 0;
            // 
            // digitalGauge2
            // 
            this.digitalGauge2.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FFF5000");
            this.digitalGauge2.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF5000");
            this.digitalGauge2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent3});
            this.digitalGauge2.Bounds = new System.Drawing.Rectangle(7, 6, 86, 44);
            this.digitalGauge2.DigitCount = 3;
            this.digitalGauge2.Name = "digitalGauge2";
            this.digitalGauge2.Text = "13.5";
            // 
            // digitalBackgroundLayerComponent3
            // 
            this.digitalBackgroundLayerComponent3.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(163.8875F, 99.9625F);
            this.digitalBackgroundLayerComponent3.Name = "bg1";
            this.digitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style10;
            this.digitalBackgroundLayerComponent3.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前电压";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gaugeControl1);
            this.panel1.Location = new System.Drawing.Point(26, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 56);
            this.panel1.TabIndex = 1;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(113, 56);
            this.gaugeControl1.TabIndex = 0;
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FFF5000");
            this.digitalGauge1.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF5000");
            this.digitalGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.digitalGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 101, 44);
            this.digitalGauge1.DigitCount = 3;
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Text = "31.5";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(163.8875F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "bg1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
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
            this.navBarControl1.Size = new System.Drawing.Size(240, 427);
            this.navBarControl1.SmallImages = this.navbarImageCollection;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 149);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.schedulerSplitContainerControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1143, 427);
            this.splitContainerControl.SplitterPosition = 240;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // nodeInfoBindingSource1
            // 
            this.nodeInfoBindingSource1.DataMember = "NodeInfo";
            this.nodeInfoBindingSource1.DataSource = this.nodeInfoDSBindingSource;
            // 
            // GroupColumn
            // 
            this.GroupColumn.Caption = "组别";
            this.GroupColumn.FieldName = "GroupName";
            this.GroupColumn.Name = "GroupColumn";
            this.GroupColumn.Width = 85;
            // 
            // digitalBackgroundLayerComponent2
            // 
            this.digitalBackgroundLayerComponent2.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(211.85F, 99.9625F);
            this.digitalBackgroundLayerComponent2.Name = "bg1";
            this.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3;
            this.digitalBackgroundLayerComponent2.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(927, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 18);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 609);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MegaSet V2.0";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispNodeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nodeInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

            nodeInfoDS.DispNodeInfo.Clear();
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
        private DevExpress.XtraGrid.Columns.GridColumn GroupColumn;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl3;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge3;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge2;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl4;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge4;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl5;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge5;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent6;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn typeColumn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarStaticItem datetimeInfo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem addUserBtn;
        private DevExpress.XtraBars.BarButtonItem helpBtn;
        private System.Windows.Forms.BindingSource dispNodeInfoBindingSource;

    }
}
