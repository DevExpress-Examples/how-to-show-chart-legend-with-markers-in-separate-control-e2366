<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575582/24.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2366)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Chart - Display a Standalone Chart Legend

This example uses a grid as a legend for the Chart control. The grid displays chart series names and legend markers. When you select a row in the grid, the corresponding series is highlighted in the chart, and selecting a series in the chart highlights the corresponding row in the grid. 

![WinForms Chart - Display a Standalone Chart Legend, DevExpress](./chart.png)

## Implementation Details

### Create Legend Markers

The `CreateLegendMarkers` method creates legend marker images by temporarily cloning the `ChartControl`. It stores the generated markers in the `legendMarkersTable` hashtable.

### Bind the Grid to Chart Series

Assign the chart's series collection to the grid's `GridControl.DataSource` property:

```csharp
gridControl1.DataSource = chart.Series;
```

### Display Series Markers in the Grid

Handle the grid's [GridView.CustomUnboundColumnData](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData) event to assign the `legendMarkersTable` to the grid's unbound *Image* column.
    
```csharp
void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
    if (e.IsGetData && e.Column == colImage) {
        e.Value = legendMarkersTable[((Series)e.Row)];
    }
}
```

### Implement Two-Way Interactivity

- Handle the [GridView.FocusedRowChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FocusedRowChanged) event to select the corresponding chart series when a user selects a grid row:

    ```csharp
    void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
        chart.SetObjectSelection(gridView1.GetRow(e.FocusedRowHandle));
    }
    ```
- Handle the [ChartControl.ObjectSelected](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.ObjectSelected) event to focus the corresponding grid row when a user clicks a chart series:

    ```csharp
    void chart_ObjectSelected(object sender, HotTrackEventArgs e) {
        if (e.HitInfo.InSeries) {
            gridView1.FocusedRowHandle = gridView1.GetRowHandle(chart.Series.IndexOf(((Series)e.Object)));
        }
    }
    ```

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))

## Documentation

- [Adding Legends](https://docs.devexpress.com/WindowsForms/115948/controls-and-libraries/chart-control/legends/adding-legends)

## More Examples

- [WinForms Chart - Add an Additional Legend to a Chart](https://github.com/DevExpress-Examples/winforms-chart-add-an-additional-legend-to-a-chart)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-charts-show-chart-legend-with-markers-in-separate-control&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-charts-show-chart-legend-with-markers-in-separate-control&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

