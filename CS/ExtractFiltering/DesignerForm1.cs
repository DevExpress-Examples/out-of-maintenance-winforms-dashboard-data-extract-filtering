
using DevExpress.DashboardCommon;

namespace ExtractFiltering {
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public DesignerForm1() {
            InitializeComponent();
            dashboardDesigner.CreateRibbon();
            dashboardDesigner.LoadDashboard(@"Dashboards\dashboard1.xml");


            DashboardExcelDataSource excelDataSource = new DashboardExcelDataSource() {
                FileName = @"C:\Users\zakhodyaeva\Desktop\winforms-dashboard-data-extract-filtering\CS\ExtractFiltering\Data\SalesPerson2.xlsx",
                SourceOptions = new DevExpress.DataAccess.Excel.ExcelSourceOptions (
                new DevExpress.DataAccess.Excel.ExcelWorksheetSettings() {
                    WorksheetName = "Sheet1",
                })
            };

            DashboardExtractDataSource dataExtract = new DashboardExtractDataSource();
            dataExtract.ExtractSourceOptions.DataSource = excelDataSource;
            dataExtract.FileName = @"C:\Users\zakhodyaeva\Desktop\winforms-dashboard-data-extract-filtering\CS\ExtractFiltering\Data\Extract1.dat"; 

            dashboardDesigner.Dashboard.DataSources.Add(dataExtract);
            dataExtract.UpdateExtractFile();

        }
    }
}
