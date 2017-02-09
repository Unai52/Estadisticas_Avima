using DevExpress.Xpo;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.IO;
using System.Linq;
namespace estadisticas_avima
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManagerCarga.ShowWaitForm();
            documentManager1.View.Controller.Dock(dockPanelECAvima);
            dockPanelECAvima.Show();
            pivotGridControlAVIMACompras.DataSource = (from AE in new XPQuery<estadisticas_avima.avima.Avima_PurchaseLine>(sessionGeneral)
                                                       select AE).ToList();
            splashScreenManagerCarga.CloseWaitForm();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PrintTool tool = new PrintTool(Systemba
            //    pivotGridControlEstadisticas);
            //tool.ShowPreview();
            pivotGridControlAVIMACompras.ShowPrintPreview();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManagerCarga.ShowWaitForm();
            documentManager1.View.Controller.Dock(dockPanelEVAvima);
            dockPanelEVAvima.Show();
            pivotGridControlAVIMAVentas.DataSource = (from AV in new XPQuery<estadisticas_avima.avima.AVIMA_Ventas>(sessionGeneral)
                                                       select AV).ToList();
            splashScreenManagerCarga.CloseWaitForm();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControlAVIMAVentas.ShowPrintPreview();

        }
    }
}
