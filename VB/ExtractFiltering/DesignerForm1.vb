Imports DevExpress.DashboardCommon

Namespace ExtractFiltering
	Partial Public Class DesignerForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()
			dashboardDesigner.CreateRibbon()
			dashboardDesigner.LoadDashboard("Dashboards\dashboard1.xml")


			Dim excelDataSource As New DashboardExcelDataSource() With {
				.FileName = "..\..\Data\SalesPerson2.xlsx",
				.SourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(New DevExpress.DataAccess.Excel.ExcelWorksheetSettings() With {.WorksheetName = "Sheet1"})
			}

			Dim dataExtract As New DashboardExtractDataSource()
			dataExtract.ExtractSourceOptions.DataSource = excelDataSource
			dataExtract.Filter = "[ProductName] = 'Chai'"
			dataExtract.ExtractSourceOptions.Filter = "[CategoryName] = 'Beverages'"
			dataExtract.FileName = "..\..\Data\Extract1.dat"

			dashboardDesigner.Dashboard.DataSources.Add(dataExtract)
			dataExtract.UpdateExtractFile()

		End Sub
	End Class
End Namespace
