using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.Collections;

namespace LegendMarkers {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }
        Hashtable legendMarkersTable = new Hashtable();
        void frmMain_Load(object sender, System.EventArgs e) {
                using (ChartControl fakeChart = (ChartControl)chart.Clone()) {
                    fakeChart.Legend.Visible = true;
                    fakeChart.BorderOptions.Visible = false;
                    fakeChart.Padding.All = 0;
                    fakeChart.BackColor = Color.Transparent;
                    fakeChart.Legend.Border.Visible = false;
                    fakeChart.Legend.Margins.All = 0;
                    fakeChart.Legend.Padding.All = 0;
                    fakeChart.Legend.TextVisible = false;
                    fakeChart.Legend.BackColor = Color.Transparent;
                    fakeChart.Legend.VerticalIndent = 0;
                    foreach (Series series in chart.Series)
                    {
                        Bitmap bitmap = GetMarkerImage(fakeChart, series);
                        legendMarkersTable.Add(series, bitmap);
                    }
                }
            gridControl1.DataSource = chart.Series;
        }
        Bitmap GetMarkerImage(ChartControl chart, Series series) {
            Bitmap bitmap = null;
            Series currentSeries = null;
            foreach (Series fakeSeries in chart.Series) {
                if (fakeSeries.Name == series.Name) {
                    currentSeries = fakeSeries;
                    fakeSeries.ShowInLegend = true;
                }
                else
                    fakeSeries.ShowInLegend = false;
            }
            if (currentSeries != null) {
                XYDiagram2D diagram = chart.Diagram as XYDiagram2D;
                if (diagram != null)
                    diagram.DefaultPane.Visible = false;
                SeriesViewColorEachSupportBase colorEachView = currentSeries.View as SeriesViewColorEachSupportBase;
                if (colorEachView != null && colorEachView.ColorEach)
                    chart.Size = new Size(chart.Legend.MarkerSize.Width, chart.Legend.MarkerSize.Height * currentSeries.Points.Count);
                else
                    chart.Size = chart.Legend.MarkerSize;
                bitmap = new Bitmap(chart.Size.Width, chart.Size.Height);
                chart.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            }
            return bitmap;
        }
      

        private void chart_ObjectSelected(object sender, HotTrackEventArgs e)
        {
            if (e.HitInfo.InSeries)
            {
                gridView1.FocusedRowHandle = gridView1.GetRowHandle(chart.Series.IndexOf(((Series)e.Object)));
                
            }
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData && e.Column == gridColumn2)
            {

                e.Value = legendMarkersTable[((Series)e.Row)];
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            chart.SetObjectSelection(gridView1.GetRow(e.FocusedRowHandle));
        }
    }
}