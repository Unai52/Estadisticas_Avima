using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.XtraSplashScreen;

namespace estadisticas_avima
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //estadisticas_avima.AVIMA.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists);
            SplashScreenManager.ShowForm(typeof(SplashScreenRemaned));
            estadisticas_avima.avima.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }
    }
}
