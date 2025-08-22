Namespace LegendMarkers

    Partial Class frmMain

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1R, New Object() {(CObj((1R))), (CObj((2R)))})
            Dim seriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2R, New Object() {(CObj((2R))), (CObj((3R)))})
            Dim seriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3R, New Object() {(CObj((3R))), (CObj((4R)))})
            Dim overlappedRangeBarSeriesView2 As DevExpress.XtraCharts.OverlappedRangeBarSeriesView = New DevExpress.XtraCharts.OverlappedRangeBarSeriesView()
            Dim series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1R, New Object() {(CObj((2R)))})
            Dim seriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2R, New Object() {(CObj((3R)))})
            Dim seriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3R, New Object() {(CObj((1R)))})
            Dim areaSeriesView2 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint22 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1R, New Object() {(CObj((1R)))})
            Dim seriesPoint23 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2R, New Object() {(CObj((2R)))})
            Dim seriesPoint24 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3R, New Object() {(CObj((3R)))})
            Dim series9 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint25 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1R, New Object() {(CObj((3R)))})
            Dim seriesPoint26 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2R, New Object() {(CObj((1R)))})
            Dim seriesPoint27 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3R, New Object() {(CObj((2R)))})
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series10 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint28 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1R, New Object() {(CObj((1R)))})
            Dim seriesPoint29 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2R, New Object() {(CObj((2R)))})
            Dim seriesPoint30 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3R, New Object() {(CObj((1R)))})
            Dim splineSeriesView2 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.colSeriesName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((overlappedRangeBarSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((areaSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = xyDiagram2
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(22, 23)
            Me.chart.Margin = New System.Windows.Forms.Padding(6)
            Me.chart.Name = "chart"
            Me.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
            series6.Name = "Series 5"
            series6.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint16, seriesPoint17, seriesPoint18})
            series6.SeriesID = 0
            series6.View = overlappedRangeBarSeriesView2
            series7.Name = "Series 2"
            series7.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint19, seriesPoint20, seriesPoint21})
            series7.SeriesID = 1
            series7.View = areaSeriesView2
            series8.Name = "Series 1"
            series8.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint22, seriesPoint23, seriesPoint24})
            series8.SeriesID = 2
            series9.Name = "Series 3"
            series9.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint25, seriesPoint26, seriesPoint27})
            series9.SeriesID = 3
            series9.View = lineSeriesView2
            series10.Name = "Series 4"
            series10.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint28, seriesPoint29, seriesPoint30})
            series10.SeriesID = 4
            series10.View = splineSeriesView2
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series6, series7, series8, series9, series10}
            Me.chart.Size = New System.Drawing.Size(1060, 554)
            Me.chart.TabIndex = 0
            AddHandler Me.chart.ObjectSelected, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chart_ObjectSelected)
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
            Me.gridControl1.Location = New System.Drawing.Point(1094, 23)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(6)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemImageEdit1})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.Size = New System.Drawing.Size(620, 554)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colImage, Me.colSeriesName})
            Me.gridView1.DetailHeight = 673
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsEditForm.PopupEditFormWidth = 1600
            AddHandler Me.gridView1.FocusedRowChanged, New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(AddressOf Me.gridView1_FocusedRowChanged)
            AddHandler Me.gridView1.CustomUnboundColumnData, New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(AddressOf Me.gridView1_CustomUnboundColumnData)
            ' 
            ' colImage
            ' 
            Me.colImage.Caption = "Image"
            Me.colImage.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colImage.FieldName = "Image"
            Me.colImage.MinWidth = 40
            Me.colImage.Name = "colImage"
            Me.colImage.OptionsColumn.AllowEdit = False
            Me.colImage.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
            Me.colImage.Visible = True
            Me.colImage.VisibleIndex = 0
            Me.colImage.Width = 112
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image
            ' 
            ' colSeriesName
            ' 
            Me.colSeriesName.Caption = "Series Name"
            Me.colSeriesName.FieldName = "Name"
            Me.colSeriesName.MinWidth = 40
            Me.colSeriesName.Name = "colSeriesName"
            Me.colSeriesName.OptionsColumn.AllowEdit = False
            Me.colSeriesName.Visible = True
            Me.colSeriesName.VisibleIndex = 1
            Me.colSeriesName.Width = 466
            ' 
            ' repositoryItemImageEdit1
            ' 
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            ' 
            ' frmMain
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(12F, 25F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1738, 600)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.chart)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "frmMain"
            Me.Text = "Legend Markers"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmMain_Load)
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((overlappedRangeBarSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((areaSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colImage As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private colSeriesName As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    End Class
End Namespace
