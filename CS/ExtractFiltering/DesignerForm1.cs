using DevExpress.DashboardCommon;

namespace ExtractFiltering {
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public DesignerForm1() {
            InitializeComponent();
            dashboardDesigner.CreateRibbon();
            dashboardDesigner.LoadDashboard(@"Dashboards\dashboard1.xml");
            // Creates an origin Excel Data Source.
            DashboardExcelDataSource excelDataSource = new DashboardExcelDataSource() {
                FileName = @"..\..\Data\SalesPerson2.xlsx",
                SourceOptions = new DevExpress.DataAccess.Excel.ExcelSourceOptions (
                new DevExpress.DataAccess.Excel.ExcelWorksheetSettings() {
                    WorksheetName = "Sheet1",
                })
            };
            // Creates a data extract based on the Excel Data Source.
            DashboardExtractDataSource dataExtract = new DashboardExtractDataSource();
            dataExtract.ExtractSourceOptions.DataSource = excelDataSource;
            dataExtract.FileName = @"..\..\Data\Extract1.dat";
            // Includes only "Beverages" rows from the "CategoryName" table to the Extract Data Source.
            dataExtract.ExtractSourceOptions.Filter = "[CategoryName] = 'Beverages'";
            // Limits displayed products from the "Beverages" category to "Chai".
            dataExtract.Filter = "[ProductName] = 'Chai'";
            dataExtract.UpdateExtractFile();
            // Adds the Extract Data Source to the dashboard. 
            dashboardDesigner.Dashboard.DataSources.Add(dataExtract);
        }
    }
}
