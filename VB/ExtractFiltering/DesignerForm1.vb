Imports DevExpress.DashboardCommon

Namespace ExtractFiltering
	Partial Public Class DesignerForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()
			dashboardDesigner.CreateRibbon()
			dashboardDesigner.LoadDashboard("Dashboards\dashboard1.xml")
			' Creates an origin Excel data source.
			Dim excelDataSource As New DashboardExcelDataSource() With {
				.FileName = "..\..\Data\SalesPerson2.xlsx",
				.SourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(New DevExpress.DataAccess.Excel.ExcelWorksheetSettings() With {.WorksheetName = "Sheet1"})
			}
			' Creates a data extract based on the Excel data source.
			Dim dataExtract As New DashboardExtractDataSource()
			dataExtract.ExtractSourceOptions.DataSource = excelDataSource
			dataExtract.FileName = "..\..\Data\Extract1.dat"
			' Includes only "Beverages" rows from the "CategotyName" table to the Extract data source.
			dataExtract.ExtractSourceOptions.Filter = "[CategoryName] = 'Beverages'"
			' Limits displayed products from the "Beverages" category to "Chai".
			dataExtract.Filter = "[ProductName] = 'Chai'"
			dataExtract.UpdateExtractFile()
			' Adds the Extract data souce to the dashboard. 
			dashboardDesigner.Dashboard.DataSources.Add(dataExtract)
		End Sub
	End Class
End Namespace
