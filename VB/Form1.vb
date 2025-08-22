Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports System.Collections

Namespace LegendMarkers

    Public Partial Class frmMain
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private legendMarkersTable As Hashtable = New Hashtable()

        Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            CreateLegendMarkers(chart)
            gridControl1.DataSource = chart.Series
        End Sub

        Private Sub CreateLegendMarkers(ByVal sourceChart As ChartControl)
            Using fakeChart As ChartControl = CType(sourceChart.Clone(), ChartControl)
                fakeChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
                fakeChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
                fakeChart.Padding.All = 0
                fakeChart.BackColor = Color.Transparent
                fakeChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
                fakeChart.Legend.Margins.All = 0
                fakeChart.Legend.Padding.All = 0
                fakeChart.Legend.TextVisible = False
                fakeChart.Legend.BackColor = Color.Transparent
                fakeChart.Legend.VerticalIndent = 0
                For Each series As Series In chart.Series
                    Dim bitmap As Bitmap = GetMarkerImage(fakeChart, series)
                    legendMarkersTable.Add(series, bitmap)
                Next
            End Using
        End Sub

        Private Function GetMarkerImage(ByVal chart As ChartControl, ByVal series As Series) As Bitmap
            Dim bitmap As Bitmap = Nothing
            Dim currentSeries As Series = Nothing
            For Each fakeSeries As Series In chart.Series
                If Equals(fakeSeries.Name, series.Name) Then
                    currentSeries = fakeSeries
                    fakeSeries.ShowInLegend = True
                Else
                    fakeSeries.ShowInLegend = False
                End If
            Next

            If currentSeries IsNot Nothing Then
                Dim diagram As XYDiagram2D = TryCast(chart.Diagram, XYDiagram2D)
                If diagram IsNot Nothing Then diagram.DefaultPane.Visibility = ChartElementVisibility.Hidden
                Dim colorEachView As SeriesViewColorEachSupportBase = TryCast(currentSeries.View, SeriesViewColorEachSupportBase)
                If colorEachView IsNot Nothing AndAlso colorEachView.ColorEach Then
                    chart.Size = New Size(chart.Legend.MarkerSize.Width, chart.Legend.MarkerSize.Height * currentSeries.Points.Count)
                Else
                    chart.Size = chart.Legend.MarkerSize
                End If

                bitmap = New Bitmap(chart.Size.Width, chart.Size.Height)
                chart.DrawToBitmap(bitmap, New Rectangle(Point.Empty, bitmap.Size))
            End If

            Return bitmap
        End Function

        Private Sub chart_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            If e.HitInfo.InSeries Then
                gridView1.FocusedRowHandle = gridView1.GetRowHandle(chart.Series.IndexOf(CType(e.Object, Series)))
            End If
        End Sub

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
            If e.IsGetData AndAlso e.Column Is colImage Then
                e.Value = legendMarkersTable(CType(e.Row, Series))
            End If
        End Sub

        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
            chart.SetObjectSelection(gridView1.GetRow(e.FocusedRowHandle))
        End Sub
    End Class
End Namespace
