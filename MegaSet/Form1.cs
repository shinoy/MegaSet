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
           // schedulerControl.Start = System.DateTime.Now;
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

    }
}