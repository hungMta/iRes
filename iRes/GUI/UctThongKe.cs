using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Title.BUS;
using DevExpress.XtraCharts;

namespace Title.GUI {
    public partial class UctThongKe : UserControl {
        public UctThongKe() {
            InitializeComponent();
        }

        public void LoadData() {
            DataTable dataTable = Bus.GetListEarnMoneyByDay();
            ChartControl chart = new ChartControl(); 

            Series series = new Series("Series1", ViewType.Bar);
            chart.Series.Add(series);

            // Generate a data table and bind the series to it.
            series.DataSource = dataTable;

            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.DateTime;
            series.ArgumentDataMember = "NgayAn";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "TongTien" });

            // Set some properties to get a nice-looking chart.
            ((SideBySideBarSeriesView)series.View).ColorEach = true;
            ((XYDiagram)chart.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Dock the chart into its parent and add it to the current form.
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);
        }

        private void UctThongKe_Load(object sender, EventArgs e) {
            LoadData();
        }
    }
}
