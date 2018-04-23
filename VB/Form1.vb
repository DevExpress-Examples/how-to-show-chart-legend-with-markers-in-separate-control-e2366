Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports System.Collections

Namespace LegendMarkers
	Partial Public Class frmMain
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private legendMarkersTable As New Hashtable()
		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
				Using fakeChart As ChartControl = CType(chart.Clone(), ChartControl)
					fakeChart.Legend.Visible = True
					fakeChart.BorderOptions.Visible = False
					fakeChart.Padding.All = 0
					fakeChart.BackColor = Color.Transparent
					fakeChart.Legend.Border.Visible = False
					fakeChart.Legend.Margins.All = 0
					fakeChart.Legend.Padding.All = 0
					fakeChart.Legend.TextVisible = False
					fakeChart.Legend.BackColor = Color.Transparent
					fakeChart.Legend.VerticalIndent = 0
					For Each series As Series In chart.Series
						Dim bitmap As Bitmap = GetMarkerImage(fakeChart, series)
						legendMarkersTable.Add(series, bitmap)
					Next series
				End Using
			gridControl1.DataSource = chart.Series
		End Sub
		Private Function GetMarkerImage(ByVal chart As ChartControl, ByVal series As Series) As Bitmap
			Dim bitmap As Bitmap = Nothing
			Dim currentSeries As Series = Nothing
			For Each fakeSeries As Series In chart.Series
				If fakeSeries.Name = series.Name Then
					currentSeries = fakeSeries
					fakeSeries.ShowInLegend = True
				Else
					fakeSeries.ShowInLegend = False
				End If
			Next fakeSeries
			If currentSeries IsNot Nothing Then
				Dim diagram As XYDiagram2D = TryCast(chart.Diagram, XYDiagram2D)
				If diagram IsNot Nothing Then
					diagram.DefaultPane.Visible = False
				End If
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


		Private Sub chart_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chart.ObjectSelected
			If e.HitInfo.InSeries Then
				gridView1.FocusedRowHandle = gridView1.GetRowHandle(chart.Series.IndexOf((CType(e.Object, Series))))

			End If
		End Sub

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.IsGetData AndAlso e.Column Is gridColumn2 Then

				e.Value = legendMarkersTable((CType(e.Row, Series)))
			End If
		End Sub

		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
			chart.SetObjectSelection(gridView1.GetRow(e.FocusedRowHandle))
		End Sub
	End Class
End Namespace