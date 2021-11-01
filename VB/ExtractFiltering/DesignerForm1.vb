Imports DevExpress.DashboardCommon

Namespace ExtractFiltering
	Partial Public Class DesignerForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()
			dashboardDesigner.CreateRibbon()
			dashboardDesigner.LoadDashboard("Dashboards\dashboard1.xml")


			Dim excelDataSource As New DashboardExcelDataSource() With {
				.FileName = "C:\Users\zakhodyaeva\Desktop\winforms-dashboard-data-extract-filtering\CS\ExtractFiltering\Data\SalesPerson2.xlsx",
				.SourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(New DevExpress.DataAccess.Excel.ExcelWorksheetSettings() With {.WorksheetName = "Sheet1"})
			}

			Dim dataExtract As New DashboardExtractDataSource()
			dataExtract.ExtractSourceOptions.DataSource = excelDataSource
			dataExtract.FileName = "C:\Users\zakhodyaeva\Desktop\winforms-dashboard-data-extract-filtering\CS\ExtractFiltering\Data\Extract1.dat"

			dashboardDesigner.Dashboard.DataSources.Add(dataExtract)
			dataExtract.UpdateExtractFile()

		End Sub
	End Class
End Namespace
