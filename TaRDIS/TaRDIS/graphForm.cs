using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TaRDIS
{
    public partial class graphForm : Form
    {
        public graphForm()
        {
            InitializeComponent();
            #region Series definition
            Series cpuUsage = new Series();
            cpuUsage.ChartType = SeriesChartType.FastLine;
            cpuUsage.LegendText = "CPU Usage [%]";
            cpuUsage.Name = "cpu";
            cpuUsage.Color = Color.Red;
            graph.Series.Add(cpuUsage);

            Series ramUsage = new Series();
            ramUsage.ChartType = SeriesChartType.FastLine;
            ramUsage.LegendText = "RAM Usage [%]";
            ramUsage.Name = "ram";
            ramUsage.Color = Color.Blue;
            graph.Series.Add(ramUsage);

            Series hddUsage = new Series();
            hddUsage.ChartType = SeriesChartType.FastLine;
            hddUsage.LegendText = "HDD active time [%]";
            hddUsage.Name = "hdd";
            hddUsage.Color = Color.Magenta;
            graph.Series.Add(hddUsage);

            graph.ChartAreas[0].AxisX.Maximum = 50;
            graph.ChartAreas[0].AxisX.Minimum = 1;
            graph.ChartAreas[0].AxisY.Maximum = 100;
            #endregion
        }

       public void addPoint(int cpuY, int ramY, int hddY)
        {
            if (graph.Series["cpu"].Points.Count() == graph.ChartAreas[0].AxisX.Maximum)
            {
                graph.Series["cpu"].Points.Clear();
                graph.Series["ram"].Points.Clear();
                graph.Series["hdd"].Points.Clear();
            }
            graph.Series["cpu"].Points.AddY(cpuY);
            graph.Series["ram"].Points.AddY(ramY);
            graph.Series["hdd"].Points.AddY(hddY);
        }
    }
}
