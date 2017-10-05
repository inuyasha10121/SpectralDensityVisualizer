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

namespace SpectralDensityVisualizer
{
    public partial class Form1 : Form
    {
        private List<float> baseSignal = new List<float>();
        private List<float> modSignal = new List<float>();
        private List<float> compositeSignal = new List<float>();

        private void normalizeSignal(List<float> signal, float amp)
        {
            var max = signal.Max();
            var min = signal.Min();
            for(int i = 0; i < signal.Count; ++i)
            {
                signal[i] = ((((signal[i] - min) / (max - min)) * 2.0f) - 1.0f) * amp;
            }
        }

        public Form1()
        {
            InitializeComponent();

            //Setup chart styling/components
            chartSignal.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartSignal.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chartSignal.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartSignal.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartSignal.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartSignal.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartSignal.ChartAreas[0].AxisX.Title = "Time";
            chartSignal.ChartAreas[0].AxisY.Title = "Intensity";

            chartField.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartField.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chartField.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartField.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartField.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartField.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartField.ChartAreas[0].AxisX.Title = "Time";
            chartField.ChartAreas[0].AxisY.Title = "Intensity";

            chartFluctuation.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartFluctuation.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chartFluctuation.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartFluctuation.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartFluctuation.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartFluctuation.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartFluctuation.ChartAreas[0].AxisX.Title = "Time";
            chartFluctuation.ChartAreas[0].AxisY.Title = "Intensity";

            chartAutoCorrelation.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartAutoCorrelation.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chartAutoCorrelation.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartAutoCorrelation.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartAutoCorrelation.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartAutoCorrelation.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartAutoCorrelation.ChartAreas[0].AxisX.Title = "Tc";
            chartAutoCorrelation.ChartAreas[0].AxisY.Title = " ";
        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            //Store some relevant parameters locally
            var signalLength = (int)numSignalLength.Value;
            var tcMax = (int)numTcMax.Value;
            var smoothingFactor = (float)numSmoothingFactor.Value;
            var truncatedBuffer = (int)numTruncBuff.Value;
            var fieldAmplitude = (float)numFieldAmp.Value;

            //Check if we need to repopulate the base random signal
            if(baseSignal.Count() == 0 || checkBoxRepopSeed.Checked)
            {
                var random = new Random();
                baseSignal = new List<float>();
                for(int i = 0; i < (signalLength + truncatedBuffer + 1); ++i)
                {
                    baseSignal.Add(((float)random.NextDouble() * 2.0f) - 1.0f);
                }
                checkBoxRepopSeed.Checked = false;
            }

            //Smooth the signal values using exponential smoothing
            var smoothedSignal = new List<float>(baseSignal);
            for(int i = 1; i < (signalLength + truncatedBuffer + 1); ++i)
            {
                smoothedSignal[i] = (smoothingFactor * smoothedSignal[i]) + ((1 - smoothingFactor) * smoothedSignal[i - 1]);
            }

            //Remove designated truncation buffer space
            smoothedSignal.RemoveRange(0, truncatedBuffer + 1);

            //Normalize signal to be between -1 and 1
            normalizeSignal(smoothedSignal, 1);

            //Generate the modifying field signal
            var modSignal = new List<float>();
            for(int i = 0; i < signalLength; ++i)
            {
                var pointval = 0.0f;
                for(int j = 0; j < dataFieldComps.Rows.Count - 1; ++j)
                {
                    var sigAmp = float.Parse(dataFieldComps.Rows[j].Cells["Amplitude"].Value.ToString());
                    var sigFreq = float.Parse(dataFieldComps.Rows[j].Cells["Frequency"].Value.ToString());
                    if (dataFieldComps.Rows[j].Cells["Type"].Value.ToString().Equals("Sin"))
                    {
                        pointval += sigAmp * (float)Math.Sin(sigFreq * i);
                    }
                    switch(dataFieldComps.Rows[j].Cells["Type"].ToString())
                    {
                        case "Sin":
                            pointval += sigAmp * (float)Math.Sin(sigFreq * i);
                            break;
                        case "Cos":
                            pointval += sigAmp * (float)Math.Cos(sigFreq * i);
                            break;
                        default:
                            pointval += 0.0f;
                            break;
                    }
                }
                modSignal.Add(pointval);
            }

            //Normalize amplitude to desired value
            if (dataFieldComps.Rows.Count != 1)
            {
                normalizeSignal(modSignal, fieldAmplitude);
            }

            //Combine the smoothed signal and the modifying signal
            var combinedSignal = new List<float>();
            for(int i = 0; i < signalLength; ++i)
            {
                combinedSignal.Add(modSignal[i] + smoothedSignal[i]);
            }
            normalizeSignal(combinedSignal, 1.0F);







            //Plot signals
            chartSignal.Series.Clear();
            chartSignal.Series.Add("Signal");
            chartSignal.Series["Signal"].ChartType = SeriesChartType.Line;
            for(int i = 0; i < signalLength; ++i)
            {
                chartSignal.Series["Signal"].Points.AddXY(i, smoothedSignal[i]);
            }

            chartField.Series.Clear();
            chartField.Series.Add("Mod");
            chartField.Series["Mod"].ChartType = SeriesChartType.Line;
            for(int i = 0; i < signalLength; ++i)
            {
                chartField.Series["Mod"].Points.AddXY(i, modSignal[i]);
            }

            chartFluctuation.Series.Clear();
            chartFluctuation.Series.Add("Comp");
            chartFluctuation.Series["Comp"].ChartType = SeriesChartType.Line;
            for (int i = 0; i < signalLength; ++i)
            {
                chartFluctuation.Series["Comp"].Points.AddXY(i, combinedSignal[i]);
            }


            Console.WriteLine("werp");
        }
    }
}
