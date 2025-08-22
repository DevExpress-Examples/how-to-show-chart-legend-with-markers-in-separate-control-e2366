namespace LegendMarkers {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint16 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(1D)),
            ((object)(2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint17 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(2D)),
            ((object)(3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint18 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(3D)),
            ((object)(4D))});
            DevExpress.XtraCharts.OverlappedRangeBarSeriesView overlappedRangeBarSeriesView2 = new DevExpress.XtraCharts.OverlappedRangeBarSeriesView();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint19 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint20 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint21 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView2 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint22 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint23 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint24 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(3D))});
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint25 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint26 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint27 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(2D))});
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series10 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint28 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint29 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint30 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colSeriesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(overlappedRangeBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram2;
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(22, 23);
            this.chart.Margin = new System.Windows.Forms.Padding(6);
            this.chart.Name = "chart";
            this.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single;
            series6.Name = "Series 5";
            series6.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint16,
            seriesPoint17,
            seriesPoint18});
            series6.SeriesID = 0;
            series6.View = overlappedRangeBarSeriesView2;
            series7.Name = "Series 2";
            series7.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint19,
            seriesPoint20,
            seriesPoint21});
            series7.SeriesID = 1;
            series7.View = areaSeriesView2;
            series8.Name = "Series 1";
            series8.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint22,
            seriesPoint23,
            seriesPoint24});
            series8.SeriesID = 2;
            series9.Name = "Series 3";
            series9.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint25,
            seriesPoint26,
            seriesPoint27});
            series9.SeriesID = 3;
            series9.View = lineSeriesView2;
            series10.Name = "Series 4";
            series10.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint28,
            seriesPoint29,
            seriesPoint30});
            series10.SeriesID = 4;
            series10.View = splineSeriesView2;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series6,
        series7,
        series8,
        series9,
        series10};
            this.chart.Size = new System.Drawing.Size(1060, 554);
            this.chart.TabIndex = 0;
            this.chart.ObjectSelected += new DevExpress.XtraCharts.HotTrackEventHandler(this.chart_ObjectSelected);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(1094, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(620, 554);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colSeriesName});
            this.gridView1.DetailHeight = 673;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1600;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // colImage
            // 
            this.colImage.Caption = "Image";
            this.colImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImage.FieldName = "Image";
            this.colImage.MinWidth = 40;
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.AllowEdit = false;
            this.colImage.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 112;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            // 
            // colSeriesName
            // 
            this.colSeriesName.Caption = "Series Name";
            this.colSeriesName.FieldName = "Name";
            this.colSeriesName.MinWidth = 40;
            this.colSeriesName.Name = "colSeriesName";
            this.colSeriesName.OptionsColumn.AllowEdit = false;
            this.colSeriesName.Visible = true;
            this.colSeriesName.VisibleIndex = 1;
            this.colSeriesName.Width = 466;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 600);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Legend Markers";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(overlappedRangeBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chart;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriesName;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
    }
}

