using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectralDensityVisualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartSignal.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartSignal.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartSignal.ChartAreas[0].AxisX.Title = "Time";
            chartSignal.ChartAreas[0].AxisY.Title = "Intensity";

            chartField.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartField.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartField.ChartAreas[0].AxisX.Title = "Time";
            chartField.ChartAreas[0].AxisY.Title = "Intensity";

            chartFluctuation.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartFluctuation.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartFluctuation.ChartAreas[0].AxisX.Title = "Time";
            chartFluctuation.ChartAreas[0].AxisY.Title = "Intensity";

            chartAutoCorrelation.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartAutoCorrelation.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartAutoCorrelation.ChartAreas[0].AxisX.Title = "Tc";
            chartAutoCorrelation.ChartAreas[0].AxisY.Title = "Autocorrelation Value";

        }
    }
}
