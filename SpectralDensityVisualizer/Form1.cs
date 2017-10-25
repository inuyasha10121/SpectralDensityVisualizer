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
using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics;

namespace SpectralDensityVisualizer
{
    public partial class Form1 : Form
    {
        private List<float> baseSignal = new List<float>();

        private void normalizeSignal(List<float> signal, float amp)
        {
            var max = signal.Max();
            var min = signal.Min();
            for(int i = 0; i < signal.Count; ++i)
            {
                signal[i] = ((((signal[i] - min) / (max - min)) * 2.0f) - 1.0f) * amp;
            }
        }

        private float getMean(List<float> signal)
        {
            float mean = 0.0f;
            for (int i = 0; i < signal.Count; ++i)
            {
                mean += signal[i];
            }
            return mean / (float)signal.Count;
        }

        private float getMeanSq(List<float> signal)
        {
            float mean = 0.0f;
            for (int i = 0; i < signal.Count; ++i)
            {
                mean += signal[i] * signal[i];
            }
            return mean / (float)signal.Count;
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
            chartSignal.ChartAreas[0].AxisX.Title = "Time (ms)";
            chartSignal.ChartAreas[0].AxisY.Title = "Intensity";

            chartField.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartField.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chartField.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartField.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartField.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartField.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartField.ChartAreas[0].AxisX.Title = "Time (ms)";
            chartField.ChartAreas[0].AxisY.Title = "Intensity";

            chartFluctuation.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartFluctuation.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chartFluctuation.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartFluctuation.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartFluctuation.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartFluctuation.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartFluctuation.ChartAreas[0].AxisX.Title = "Time (ms)";
            chartFluctuation.ChartAreas[0].AxisY.Title = "Intensity";

            chartAutoCorrelation.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartAutoCorrelation.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chartAutoCorrelation.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartAutoCorrelation.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartAutoCorrelation.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartAutoCorrelation.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartAutoCorrelation.ChartAreas[0].AxisX.Title = "Tc";
            chartAutoCorrelation.ChartAreas[0].AxisY.Title = "Intensity";

            chartFFT.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartFFT.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chartFFT.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartFFT.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartFFT.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartFFT.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartFFT.ChartAreas[0].AxisX.Title = "Frequency (Hz)";
            chartFFT.ChartAreas[0].AxisY.Title = "Intensity";
        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            //Store some relevant parameters locally
            var signalLength = (int)numSignalLength.Value;
            var tcMax = (int)numTcMax.Value;
            var smoothingFactor = (float)numSmoothingFactor.Value;
            var truncatedBuffer = (int)numTruncBuff.Value;
            var fieldAmplitude = (float)numFieldAmp.Value;
            var fftZeroFill = (int)numFFTZeroFill.Value;

            //Check if we need to repopulate the base random signal
            if (baseSignal.Count() == 0 || checkBoxRepopSeed.Checked)
            {
                var random = new Random();
                baseSignal = new List<float>();
                for (int i = 0; i < (signalLength + truncatedBuffer + 1); ++i)
                {
                    baseSignal.Add(((float)random.NextDouble() * 2.0f) - 1.0f);
                }
                checkBoxRepopSeed.Checked = false;
            }

            //Smooth the signal values using exponential smoothing
            var smoothedSignal = new List<float>(baseSignal);
            for (int i = 1; i < (signalLength + truncatedBuffer + 1); ++i)
            {
                smoothedSignal[i] = (smoothingFactor * smoothedSignal[i]) + ((1 - smoothingFactor) * smoothedSignal[i - 1]);
            }

            //Remove designated truncation buffer space
            smoothedSignal.RemoveRange(0, truncatedBuffer + 1);

            //Normalize signal to be between -1 and 1
            normalizeSignal(smoothedSignal, 1);

            //Generate the modifying field signal
            var modSignal = new List<float>();
            for (int i = 0; i < signalLength; ++i)
            {
                var pointval = 0.0f;
                for (int j = 0; j < dataFieldComps.Rows.Count - 1; ++j)
                {
                    var sigAmp = float.Parse(dataFieldComps.Rows[j].Cells["Amplitude"].Value.ToString());
                    var sigFreq = float.Parse(dataFieldComps.Rows[j].Cells["Frequency"].Value.ToString());
                    switch (dataFieldComps.Rows[j].Cells["Type"].Value.ToString())
                    {
                        case "Sin":
                            pointval += sigAmp * (float)Math.Sin(sigFreq * ((float)i / 1000.0) * 2.0 * Math.PI);
                            break;
                        case "Cos":
                            pointval += sigAmp * (float)Math.Cos(sigFreq * ((float)i / 1000.0) * 2.0 * Math.PI);
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
            for (int i = 0; i < signalLength; ++i)
            {
                combinedSignal.Add(modSignal[i] + smoothedSignal[i]);
            }
            normalizeSignal(combinedSignal, 1.0F);

            //Get autocorrelation values
            var signalAutos = new List<float>();
            var combAutos = new List<float>();
            for (int tc = 0; tc <= tcMax; ++tc)
            {
                var tempsig = new List<float>();
                var tempcomb = new List<float>();

                for (int i = 0; i < signalLength - tcMax; ++i)
                {
                    tempsig.Add(smoothedSignal[i] * smoothedSignal[i + tc]);
                    tempcomb.Add(combinedSignal[i] * combinedSignal[i + tc]);
                }
                signalAutos.Add(getMean(tempsig));
                combAutos.Add(getMean(tempcomb));
            }

            //Get Fourier Transforms
            var signalComplex = new Complex32[signalLength + fftZeroFill];
            var combComplex = new Complex32[signalLength + fftZeroFill];

            for (int i = 0; i < signalLength; ++i)
            {
                signalComplex[i] = new Complex32(smoothedSignal[i], 0);
                combComplex[i] = new Complex32(combinedSignal[i], 0);
            }

            for (int i = 0; i < fftZeroFill; ++i)
            {
                signalComplex[i + signalLength] = new Complex32(0, 0);
                combComplex[i + signalLength] = new Complex32(0, 0);
            }

            Fourier.Forward(signalComplex, FourierOptions.Matlab);
            Fourier.Forward(combComplex, FourierOptions.Matlab);

            var fftscale = Fourier.FrequencyScale(combComplex.Length, 1000.0);

            //Display signal paramters
            numSignalMean.Value = (decimal)getMean(smoothedSignal);
            numSignalMeanSq.Value = (decimal)getMeanSq(smoothedSignal);
            numCompMean.Value = (decimal)getMean(combinedSignal);
            numCompMeanSq.Value = (decimal)getMeanSq(combinedSignal);

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

            chartAutoCorrelation.Series.Clear();
            chartAutoCorrelation.Series.Add("Original");
            chartAutoCorrelation.Series.Add("Modified");
            chartAutoCorrelation.Series["Original"].ChartType = SeriesChartType.Point;
            chartAutoCorrelation.Series["Modified"].ChartType = SeriesChartType.Point;
            for(int i = 0; i <= tcMax; i++)
            {
                chartAutoCorrelation.Series["Original"].Points.AddXY(i, signalAutos[i]);
                chartAutoCorrelation.Series["Modified"].Points.AddXY(i, combAutos[i]);
            }

            chartFFT.Series.Clear();
            chartFFT.Series.Add("Original");
            chartFFT.Series.Add("Modified");
            chartFFT.Series["Original"].ChartType = SeriesChartType.Line;
            chartFFT.Series["Modified"].ChartType = SeriesChartType.Line;
            for (int i = 0; i < (signalLength + fftZeroFill)/2; i++)
            {
                chartFFT.Series["Original"].Points.AddXY((float)fftscale[i], signalComplex[i].Real);
                chartFFT.Series["Modified"].Points.AddXY((float)fftscale[i], combComplex[i].Real);
            }

        }

        //Taken/slightly modified from: https://stackoverflow.com/questions/10648828/see-values-of-chart-points-when-the-mouse-is-on-points
        Point? prevPosition = null;
        private void chartFFT_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            toolTip1.RemoveAll();
            prevPosition = pos;
            var results = chartFFT.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var label = result.Series.Name;
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 2 &&
                            Math.Abs(pos.Y - pointYPixel) < 2)
                        {
                            toolTip1.Show(label + " (" + prop.XValue + "," + prop.YValues[0] + ")", this.chartFFT,
                                            pos.X, pos.Y - 15);
                        }
                    }
                }
            }

        }
    }
}
