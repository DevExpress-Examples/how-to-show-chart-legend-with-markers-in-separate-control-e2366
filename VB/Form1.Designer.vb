Imports Microsoft.VisualBasic
Imports System
Namespace LegendMarkers
	Partial Public Class frmMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim rangeBarSeriesLabel1 As New DevExpress.XtraCharts.RangeBarSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(1)), (CObj(2))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(2)), (CObj(3))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(3)), (CObj(4))})
			Dim overlappedRangeBarSeriesView1 As New DevExpress.XtraCharts.OverlappedRangeBarSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(2))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(3))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(1))})
			Dim areaSeriesView1 As New DevExpress.XtraCharts.AreaSeriesView()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(1))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(2))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(3))})
			Dim series4 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(3))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(1))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(2))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series5 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(1))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(2))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(1))})
			Dim splineSeriesView1 As New DevExpress.XtraCharts.SplineSeriesView()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(rangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(overlappedRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chart
			' 
			Me.chart.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Legend.Visible = False
			Me.chart.Location = New System.Drawing.Point(11, 12)
			Me.chart.Name = "chart"
			Me.chart.RuntimeSelection = True
			series1.Label = rangeBarSeriesLabel1
			series1.Name = "Series 5"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3})
			series1.View = overlappedRangeBarSeriesView1
			pointSeriesLabel1.LineVisible = True
			series2.Label = pointSeriesLabel1
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint4, seriesPoint5, seriesPoint6})
			series2.View = areaSeriesView1
			sideBySideBarSeriesLabel1.LineVisible = True
			series3.Label = sideBySideBarSeriesLabel1
			series3.Name = "Series 1"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint7, seriesPoint8, seriesPoint9})
			pointSeriesLabel2.LineVisible = True
			series4.Label = pointSeriesLabel2
			series4.Name = "Series 3"
			series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint10, seriesPoint11, seriesPoint12})
			series4.View = lineSeriesView1
			pointSeriesLabel3.LineVisible = True
			series5.Label = pointSeriesLabel3
			series5.Name = "Series 4"
			series5.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint13, seriesPoint14, seriesPoint15})
			series5.View = splineSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3, series4, series5}
			sideBySideBarSeriesLabel2.LineVisible = True
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chart.Size = New System.Drawing.Size(529, 288)
			Me.chart.TabIndex = 0
'			Me.chart.ObjectSelected += New DevExpress.XtraCharts.HotTrackEventHandler(Me.chart_ObjectSelected);
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(547, 12)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemImageEdit1})
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(310, 288)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn2, Me.gridColumn1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
'			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged);
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Image"
			Me.gridColumn2.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.gridColumn2.FieldName = "gridColumn2"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.OptionsColumn.AllowEdit = False
			Me.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Object
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 0
			Me.gridColumn2.Width = 56
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Series Name"
			Me.gridColumn1.FieldName = "Name"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.OptionsColumn.AllowEdit = False
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 1
			Me.gridColumn1.Width = 233
			' 
			' repositoryItemImageEdit1
			' 
			Me.repositoryItemImageEdit1.AutoHeight = False
			Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
			' 
			' frmMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(869, 312)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.chart)
			Me.Name = "frmMain"
			Me.Text = "Legend Markers"
'			Me.Load += New System.EventHandler(Me.frmMain_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(overlappedRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As DevExpress.XtraCharts.ChartControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
	End Class
End Namespace

