namespace SpectralDensityVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numSignalLength = new System.Windows.Forms.NumericUpDown();
            this.numTcMax = new System.Windows.Forms.NumericUpDown();
            this.numSmoothingFactor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numTruncBuff = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numFieldAmp = new System.Windows.Forms.NumericUpDown();
            this.dataFieldComps = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amplitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.checkBoxRepopSeed = new System.Windows.Forms.CheckBox();
            this.tabGraphs = new System.Windows.Forms.TabControl();
            this.tabPageSignals = new System.Windows.Forms.TabPage();
            this.chartFluctuation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartField = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSignal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageAutoCorr = new System.Windows.Forms.TabPage();
            this.chartAutoCorrelation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numSignalMean = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numCompMean = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numCompMeanSq = new System.Windows.Forms.NumericUpDown();
            this.numSignalMeanSq = new System.Windows.Forms.NumericUpDown();
            this.tabPageFFT = new System.Windows.Forms.TabPage();
            this.chartFFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.numFFTZeroFill = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSignalLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTcMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSmoothingFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTruncBuff)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFieldAmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFieldComps)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabGraphs.SuspendLayout();
            this.tabPageSignals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFluctuation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSignal)).BeginInit();
            this.tabPageAutoCorr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAutoCorrelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSignalMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompMeanSq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSignalMeanSq)).BeginInit();
            this.tabPageFFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFFTZeroFill)).BeginInit();
            this.SuspendLayout();
            // 
            // numSignalLength
            // 
            this.numSignalLength.Location = new System.Drawing.Point(108, 21);
            this.numSignalLength.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numSignalLength.Name = "numSignalLength";
            this.numSignalLength.Size = new System.Drawing.Size(120, 20);
            this.numSignalLength.TabIndex = 1;
            this.numSignalLength.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // numTcMax
            // 
            this.numTcMax.Location = new System.Drawing.Point(108, 47);
            this.numTcMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTcMax.Name = "numTcMax";
            this.numTcMax.Size = new System.Drawing.Size(120, 20);
            this.numTcMax.TabIndex = 2;
            this.numTcMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numSmoothingFactor
            // 
            this.numSmoothingFactor.DecimalPlaces = 3;
            this.numSmoothingFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numSmoothingFactor.Location = new System.Drawing.Point(108, 73);
            this.numSmoothingFactor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSmoothingFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numSmoothingFactor.Name = "numSmoothingFactor";
            this.numSmoothingFactor.Size = new System.Drawing.Size(120, 20);
            this.numSmoothingFactor.TabIndex = 3;
            this.numSmoothingFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Signal Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tc Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Smoothing Factor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Truncated Buffer:";
            // 
            // numTruncBuff
            // 
            this.numTruncBuff.Location = new System.Drawing.Point(108, 99);
            this.numTruncBuff.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTruncBuff.Name = "numTruncBuff";
            this.numTruncBuff.Size = new System.Drawing.Size(120, 20);
            this.numTruncBuff.TabIndex = 7;
            this.numTruncBuff.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numFFTZeroFill);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numTruncBuff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numSmoothingFactor);
            this.groupBox1.Controls.Add(this.numTcMax);
            this.groupBox1.Controls.Add(this.numSignalLength);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signal Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Field Amplitude:";
            // 
            // numFieldAmp
            // 
            this.numFieldAmp.DecimalPlaces = 3;
            this.numFieldAmp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numFieldAmp.Location = new System.Drawing.Point(108, 31);
            this.numFieldAmp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFieldAmp.Name = "numFieldAmp";
            this.numFieldAmp.Size = new System.Drawing.Size(120, 20);
            this.numFieldAmp.TabIndex = 10;
            // 
            // dataFieldComps
            // 
            this.dataFieldComps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFieldComps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Amplitude,
            this.Frequency});
            this.dataFieldComps.Location = new System.Drawing.Point(12, 57);
            this.dataFieldComps.Name = "dataFieldComps";
            this.dataFieldComps.Size = new System.Drawing.Size(268, 220);
            this.dataFieldComps.TabIndex = 12;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type:";
            this.Type.Items.AddRange(new object[] {
            "Sin",
            "Cos"});
            this.Type.Name = "Type";
            this.Type.Width = 75;
            // 
            // Amplitude
            // 
            this.Amplitude.HeaderText = "Amp:";
            this.Amplitude.Name = "Amplitude";
            this.Amplitude.Width = 75;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Freq:";
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numFieldAmp);
            this.groupBox2.Controls.Add(this.dataFieldComps);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 288);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field Parameters";
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Location = new System.Drawing.Point(12, 491);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(292, 59);
            this.buttonSimulate.TabIndex = 14;
            this.buttonSimulate.Text = "SIMULATE";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // checkBoxRepopSeed
            // 
            this.checkBoxRepopSeed.AutoSize = true;
            this.checkBoxRepopSeed.Location = new System.Drawing.Point(12, 558);
            this.checkBoxRepopSeed.Name = "checkBoxRepopSeed";
            this.checkBoxRepopSeed.Size = new System.Drawing.Size(147, 17);
            this.checkBoxRepopSeed.TabIndex = 15;
            this.checkBoxRepopSeed.Text = "Repopulate original signal";
            this.checkBoxRepopSeed.UseVisualStyleBackColor = true;
            // 
            // tabGraphs
            // 
            this.tabGraphs.Controls.Add(this.tabPageSignals);
            this.tabGraphs.Controls.Add(this.tabPageAutoCorr);
            this.tabGraphs.Controls.Add(this.tabPageFFT);
            this.tabGraphs.Location = new System.Drawing.Point(365, 21);
            this.tabGraphs.Name = "tabGraphs";
            this.tabGraphs.SelectedIndex = 0;
            this.tabGraphs.Size = new System.Drawing.Size(608, 626);
            this.tabGraphs.TabIndex = 16;
            // 
            // tabPageSignals
            // 
            this.tabPageSignals.Controls.Add(this.chartFluctuation);
            this.tabPageSignals.Controls.Add(this.chartField);
            this.tabPageSignals.Controls.Add(this.chartSignal);
            this.tabPageSignals.Location = new System.Drawing.Point(4, 22);
            this.tabPageSignals.Name = "tabPageSignals";
            this.tabPageSignals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignals.Size = new System.Drawing.Size(600, 600);
            this.tabPageSignals.TabIndex = 0;
            this.tabPageSignals.Text = "Signals";
            this.tabPageSignals.UseVisualStyleBackColor = true;
            // 
            // chartFluctuation
            // 
            this.chartFluctuation.BorderlineColor = System.Drawing.Color.Black;
            this.chartFluctuation.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.Name = "ChartArea1";
            this.chartFluctuation.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartFluctuation.Legends.Add(legend6);
            this.chartFluctuation.Location = new System.Drawing.Point(0, 394);
            this.chartFluctuation.Name = "chartFluctuation";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFluctuation.Series.Add(series6);
            this.chartFluctuation.Size = new System.Drawing.Size(600, 200);
            this.chartFluctuation.TabIndex = 2;
            this.chartFluctuation.Text = "chart3";
            // 
            // chartField
            // 
            this.chartField.BorderlineColor = System.Drawing.Color.Black;
            this.chartField.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea7.Name = "ChartArea1";
            this.chartField.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartField.Legends.Add(legend7);
            this.chartField.Location = new System.Drawing.Point(0, 200);
            this.chartField.Name = "chartField";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartField.Series.Add(series7);
            this.chartField.Size = new System.Drawing.Size(600, 200);
            this.chartField.TabIndex = 1;
            this.chartField.Text = "chart2";
            // 
            // chartSignal
            // 
            this.chartSignal.BorderlineColor = System.Drawing.Color.Black;
            this.chartSignal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea8.Name = "ChartArea1";
            this.chartSignal.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartSignal.Legends.Add(legend8);
            this.chartSignal.Location = new System.Drawing.Point(0, 1);
            this.chartSignal.Name = "chartSignal";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartSignal.Series.Add(series8);
            this.chartSignal.Size = new System.Drawing.Size(600, 200);
            this.chartSignal.TabIndex = 0;
            this.chartSignal.Text = "chart1";
            // 
            // tabPageAutoCorr
            // 
            this.tabPageAutoCorr.Controls.Add(this.chartAutoCorrelation);
            this.tabPageAutoCorr.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutoCorr.Name = "tabPageAutoCorr";
            this.tabPageAutoCorr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutoCorr.Size = new System.Drawing.Size(600, 600);
            this.tabPageAutoCorr.TabIndex = 1;
            this.tabPageAutoCorr.Text = "Autocorrelation";
            this.tabPageAutoCorr.UseVisualStyleBackColor = true;
            // 
            // chartAutoCorrelation
            // 
            chartArea9.Name = "ChartArea1";
            this.chartAutoCorrelation.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartAutoCorrelation.Legends.Add(legend9);
            this.chartAutoCorrelation.Location = new System.Drawing.Point(6, 6);
            this.chartAutoCorrelation.Name = "chartAutoCorrelation";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartAutoCorrelation.Series.Add(series9);
            this.chartAutoCorrelation.Size = new System.Drawing.Size(588, 588);
            this.chartAutoCorrelation.TabIndex = 0;
            this.chartAutoCorrelation.Text = "chart1";
            // 
            // numSignalMean
            // 
            this.numSignalMean.DecimalPlaces = 5;
            this.numSignalMean.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numSignalMean.Location = new System.Drawing.Point(69, 596);
            this.numSignalMean.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSignalMean.Name = "numSignalMean";
            this.numSignalMean.ReadOnly = true;
            this.numSignalMean.Size = new System.Drawing.Size(74, 20);
            this.numSignalMean.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Signal:";
            // 
            // numCompMean
            // 
            this.numCompMean.DecimalPlaces = 5;
            this.numCompMean.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numCompMean.Location = new System.Drawing.Point(69, 622);
            this.numCompMean.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numCompMean.Name = "numCompMean";
            this.numCompMean.ReadOnly = true;
            this.numCompMean.Size = new System.Drawing.Size(74, 20);
            this.numCompMean.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Comp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mean:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 580);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mean Sq:";
            // 
            // numCompMeanSq
            // 
            this.numCompMeanSq.DecimalPlaces = 5;
            this.numCompMeanSq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numCompMeanSq.Location = new System.Drawing.Point(149, 622);
            this.numCompMeanSq.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numCompMeanSq.Name = "numCompMeanSq";
            this.numCompMeanSq.ReadOnly = true;
            this.numCompMeanSq.Size = new System.Drawing.Size(74, 20);
            this.numCompMeanSq.TabIndex = 23;
            // 
            // numSignalMeanSq
            // 
            this.numSignalMeanSq.DecimalPlaces = 5;
            this.numSignalMeanSq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numSignalMeanSq.Location = new System.Drawing.Point(149, 596);
            this.numSignalMeanSq.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSignalMeanSq.Name = "numSignalMeanSq";
            this.numSignalMeanSq.ReadOnly = true;
            this.numSignalMeanSq.Size = new System.Drawing.Size(74, 20);
            this.numSignalMeanSq.TabIndex = 22;
            // 
            // tabPageFFT
            // 
            this.tabPageFFT.Controls.Add(this.chartFFT);
            this.tabPageFFT.Location = new System.Drawing.Point(4, 22);
            this.tabPageFFT.Name = "tabPageFFT";
            this.tabPageFFT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFFT.Size = new System.Drawing.Size(600, 600);
            this.tabPageFFT.TabIndex = 2;
            this.tabPageFFT.Text = "FFT";
            this.tabPageFFT.UseVisualStyleBackColor = true;
            // 
            // chartFFT
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFFT.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartFFT.Legends.Add(legend10);
            this.chartFFT.Location = new System.Drawing.Point(6, 6);
            this.chartFFT.Name = "chartFFT";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartFFT.Series.Add(series10);
            this.chartFFT.Size = new System.Drawing.Size(588, 588);
            this.chartFFT.TabIndex = 1;
            this.chartFFT.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "FFT Zero Fill:";
            // 
            // numFFTZeroFill
            // 
            this.numFFTZeroFill.Location = new System.Drawing.Point(108, 125);
            this.numFFTZeroFill.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFFTZeroFill.Name = "numFFTZeroFill";
            this.numFFTZeroFill.Size = new System.Drawing.Size(120, 20);
            this.numFFTZeroFill.TabIndex = 9;
            this.numFFTZeroFill.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 662);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numCompMeanSq);
            this.Controls.Add(this.numSignalMeanSq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numCompMean);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSignalMean);
            this.Controls.Add(this.tabGraphs);
            this.Controls.Add(this.checkBoxRepopSeed);
            this.Controls.Add(this.buttonSimulate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSignalLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTcMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSmoothingFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTruncBuff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFieldAmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFieldComps)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabGraphs.ResumeLayout(false);
            this.tabPageSignals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFluctuation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSignal)).EndInit();
            this.tabPageAutoCorr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAutoCorrelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSignalMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompMeanSq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSignalMeanSq)).EndInit();
            this.tabPageFFT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFFTZeroFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numSignalLength;
        private System.Windows.Forms.NumericUpDown numTcMax;
        private System.Windows.Forms.NumericUpDown numSmoothingFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTruncBuff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFieldAmp;
        private System.Windows.Forms.DataGridView dataFieldComps;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amplitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.CheckBox checkBoxRepopSeed;
        private System.Windows.Forms.TabControl tabGraphs;
        private System.Windows.Forms.TabPage tabPageSignals;
        private System.Windows.Forms.TabPage tabPageAutoCorr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAutoCorrelation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFluctuation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartField;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSignal;
        private System.Windows.Forms.NumericUpDown numSignalMean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCompMean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numCompMeanSq;
        private System.Windows.Forms.NumericUpDown numSignalMeanSq;
        private System.Windows.Forms.TabPage tabPageFFT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFFT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numFFTZeroFill;
    }
}

