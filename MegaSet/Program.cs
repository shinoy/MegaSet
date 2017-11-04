using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace MegaSet
{
    static class Program
    {
        private static string userName;
        private static int userLevel;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            LogonForm logon = new LogonForm();
            logon.StartPosition = FormStartPosition.CenterScreen;
            logon.ShowDialog();
            if (logon.DialogResult == DialogResult.OK)
            {
                userName = logon.LogOnUser;
                userLevel = int.Parse(logon.LogOnLevel);
                
                logon.Close();
                Application.Run(new Form1(userName,userLevel));
            }
            else
            {
                logon.Close();
            }
            
        }
    }
}