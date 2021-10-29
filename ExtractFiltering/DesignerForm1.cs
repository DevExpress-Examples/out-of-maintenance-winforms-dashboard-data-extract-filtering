
using DevExpress.DashboardCommon;

namespace ExtractFiltering
{
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DesignerForm1()
        {
            InitializeComponent();
            dashboardDesigner.CreateRibbon();
            dashboardDesigner.LoadDashboard(@"Dashboards\dashboard1.xml");

            DashboardExtractDataSource dataExtract = new DashboardExtractDataSource();
            dataExtract.ExtractSourceOptions.DataSource = dashboardDesigner.Dashboard.DataSources[0];
            dataExtract.FileName = @"C:\Users\zakhodyaeva\Desktop\ExtractFiltering\ExtractFiltering\Data\Extract1.dat";
            dataExtract.ExtractSourceOptions.Filter = "[CategoryName] = 'Beverages'";
            dataExtract.Filter = "[ProductName] = 'Chai'";

            Dashboard dashboard = new Dashboard();
            dashboardDesigner.Dashboard = dashboard;
            dashboardDesigner.Dashboard.DataSources.Add(dataExtract);
            dashboardDesigner.Dashboard.SaveToXml(@"Dashboards\Dashboard_Extract.xml");
            dataExtract.UpdateExtractFile();

        }
    }
}
