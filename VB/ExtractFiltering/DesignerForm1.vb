Imports DevExpress.DashboardCommon

Namespace ExtractFiltering
	Partial Public Class DesignerForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()
			dashboardDesigner.CreateRibbon()
			dashboardDesigner.LoadDashboard("Dashboards\dashboard1.xml")
			' Creates an origin Excel Data Source.
			Dim excelDataSource As New DashboardExcelDataSource() With {
				.FileName = "..\..\Data\SalesPerson2.xlsx",
				.SourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(New DevExpress.DataAccess.Excel.ExcelWorksheetSettings() With {.WorksheetName = "Sheet1"})
			}
			' Creates a data extract based on the Excel Data Source.
			Dim dataExtract As New DashboardExtractDataSource()
			dataExtract.ExtractSourceOptions.DataSource = excelDataSource
			dataExtract.FileName = "..\..\Data\Extract1.dat"
			' Includes only "Beverages" rows from the "CategoryName" table to the Extract Data Source.
			dataExtract.ExtractSourceOptions.Filter = "[CategoryName] = 'Beverages'"
			' Limits displayed products from the "Beverages" category to "Chai".
			dataExtract.Filter = "[ProductName] = 'Chai'"
			dataExtract.UpdateExtractFile()
			' Adds the Extract Data Source to the dashboard.
			dashboardDesigner.Dashboard.DataSources.Add(dataExtract)
		End Sub
	End Class
End Namespace
