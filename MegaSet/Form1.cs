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
           
            nodeInfoDS.NodeInfo.Rows.Add("row1",true,DateTime.Now,new TimeSpan(3,14,22), 128);
            
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