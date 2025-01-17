<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/422598616/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1040573)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Dashboard for WinForms - Filter the Extract Data Source 

The following example creates a data extract from the Excel data source and shows how to filter the extracted data:

* [ExtractSourceOptions.Filter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ExtractSourceOptions.Filter)

     Specifies the `[CategoryName] = 'Beverages'` expression. This expression allows you to include only rows related to the _Beverages_ category in the created data extract. 

* [DashboardExtractDataSource.Filter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardExtractDataSource.Filter)

    Filters data loaded to a dashboard from the extract data source. The following expressions allows you to display only the _Chai_ product: `[ProductName] = 'Chai'`:

As a result, the Grid dashboard item displays the sales of the _Chai_ product from the _Beverages_ category for each seller:

![extract-filtering-example](images/grid.png)

<!-- default file list -->

## Files to Look At

- [DesignerForm1.cs](./CS/ExtractFiltering/DesignerForm1.cs) (VB: [DesignerForm1.vb](./VB/ExtractFiltering/DesignerForm1.vb))

<!-- default file list end --> 

## Documentation

- [ExtractSourceOptions.Filter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ExtractSourceOptions.Filter)
- [DashboardExtractDataSource.Filter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardExtractDataSource.Filter)
- [Filtering](https://docs.devexpress.com/Dashboard/17636/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/providing-data/extract-data-source/filtering)
- [Extract Data Source](https://docs.devexpress.com/Dashboard/115900/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/providing-data/extract-data-source)

## More Examples

- [Dashboard for WinForms - Dashboard with Extract Data Source](https://github.com/DevExpress-Examples/winforms-dashboard-extract-data-source)
- [Dashboard for WinForms - How to customize the Data Source Wizard and invoke it in the DashboardViewer](https://github.com/DevExpress-Examples/Dashboard-Customize-ExtractDataSource-Wizard)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-data-extract-filtering&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-data-extract-filtering&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
