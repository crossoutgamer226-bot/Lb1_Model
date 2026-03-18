namespace Lb1_Model
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxLambda0 = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxBins = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelMean = new System.Windows.Forms.Label();
            this.labelMeanValue = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelVarianceValue = new System.Windows.Forms.Label();
            this.labelStd = new System.Windows.Forms.Label();
            this.labelStdValue = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelDValue = new System.Windows.Forms.Label();
            this.labelLambda = new System.Windows.Forms.Label();
            this.labelLambdaValue = new System.Windows.Forms.Label();
            this.labelConclusion = new System.Windows.Forms.Label();
            this.textBoxHistogram = new System.Windows.Forms.TextBox();
            this.textBoxResearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "k:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "λ0:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "\tN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "bins:";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(125, 28);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 22);
            this.textBoxK.TabIndex = 4;
            this.textBoxK.Text = "1.5";
            // 
            // textBoxLambda0
            // 
            this.textBoxLambda0.Location = new System.Drawing.Point(125, 68);
            this.textBoxLambda0.Name = "textBoxLambda0";
            this.textBoxLambda0.Size = new System.Drawing.Size(100, 22);
            this.textBoxLambda0.TabIndex = 5;
            this.textBoxLambda0.Text = "0.7";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(125, 113);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 6;
            this.textBoxN.Text = "10000";
            // 
            // textBoxBins
            // 
            this.textBoxBins.Location = new System.Drawing.Point(125, 159);
            this.textBoxBins.Name = "textBoxBins";
            this.textBoxBins.Size = new System.Drawing.Size(100, 22);
            this.textBoxBins.TabIndex = 7;
            this.textBoxBins.Text = "20";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(27, 190);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(94, 48);
            this.buttonRun.TabIndex = 8;
            this.buttonRun.Text = "Выполнить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Location = new System.Drawing.Point(24, 258);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(67, 16);
            this.labelMean.TabIndex = 9;
            this.labelMean.Text = "Среднее:";
            // 
            // labelMeanValue
            // 
            this.labelMeanValue.AutoSize = true;
            this.labelMeanValue.Location = new System.Drawing.Point(104, 258);
            this.labelMeanValue.Name = "labelMeanValue";
            this.labelMeanValue.Size = new System.Drawing.Size(0, 16);
            this.labelMeanValue.TabIndex = 10;
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Location = new System.Drawing.Point(18, 290);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(80, 16);
            this.labelVariance.TabIndex = 11;
            this.labelVariance.Text = "Дисперсия:";
            // 
            // labelVarianceValue
            // 
            this.labelVarianceValue.AutoSize = true;
            this.labelVarianceValue.Location = new System.Drawing.Point(104, 290);
            this.labelVarianceValue.Name = "labelVarianceValue";
            this.labelVarianceValue.Size = new System.Drawing.Size(0, 16);
            this.labelVarianceValue.TabIndex = 12;
            // 
            // labelStd
            // 
            this.labelStd.AutoSize = true;
            this.labelStd.Location = new System.Drawing.Point(24, 323);
            this.labelStd.Name = "labelStd";
            this.labelStd.Size = new System.Drawing.Size(37, 16);
            this.labelStd.TabIndex = 13;
            this.labelStd.Text = "СКО:";
            // 
            // labelStdValue
            // 
            this.labelStdValue.AutoSize = true;
            this.labelStdValue.Location = new System.Drawing.Point(67, 323);
            this.labelStdValue.Name = "labelStdValue";
            this.labelStdValue.Size = new System.Drawing.Size(0, 16);
            this.labelStdValue.TabIndex = 14;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(24, 349);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(20, 16);
            this.labelD.TabIndex = 15;
            this.labelD.Text = "D:";
            // 
            // labelDValue
            // 
            this.labelDValue.AutoSize = true;
            this.labelDValue.Location = new System.Drawing.Point(50, 349);
            this.labelDValue.Name = "labelDValue";
            this.labelDValue.Size = new System.Drawing.Size(0, 16);
            this.labelDValue.TabIndex = 16;
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Location = new System.Drawing.Point(24, 379);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(18, 16);
            this.labelLambda.TabIndex = 17;
            this.labelLambda.Text = "λ:";
            // 
            // labelLambdaValue
            // 
            this.labelLambdaValue.AutoSize = true;
            this.labelLambdaValue.Location = new System.Drawing.Point(43, 379);
            this.labelLambdaValue.Name = "labelLambdaValue";
            this.labelLambdaValue.Size = new System.Drawing.Size(0, 16);
            this.labelLambdaValue.TabIndex = 18;
            // 
            // labelConclusion
            // 
            this.labelConclusion.AutoSize = true;
            this.labelConclusion.Location = new System.Drawing.Point(24, 408);
            this.labelConclusion.Name = "labelConclusion";
            this.labelConclusion.Size = new System.Drawing.Size(0, 16);
            this.labelConclusion.TabIndex = 19;
            // 
            // textBoxHistogram
            // 
            this.textBoxHistogram.Location = new System.Drawing.Point(257, 28);
            this.textBoxHistogram.Multiline = true;
            this.textBoxHistogram.Name = "textBoxHistogram";
            this.textBoxHistogram.ReadOnly = true;
            this.textBoxHistogram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHistogram.Size = new System.Drawing.Size(531, 337);
            this.textBoxHistogram.TabIndex = 20;
            this.textBoxHistogram.TextChanged += new System.EventHandler(this.textBoxHistogram_TextChanged);
            // 
            // textBoxResearch
            // 
            this.textBoxResearch.Location = new System.Drawing.Point(463, 371);
            this.textBoxResearch.Multiline = true;
            this.textBoxResearch.Name = "textBoxResearch";
            this.textBoxResearch.ReadOnly = true;
            this.textBoxResearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResearch.Size = new System.Drawing.Size(507, 243);
            this.textBoxResearch.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chartHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend1);
            this.chartHistogram.Location = new System.Drawing.Point(976, 28);
            this.chartHistogram.Name = "chartHistogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHistogram.Series.Add(series1);
            this.chartHistogram.Size = new System.Drawing.Size(593, 586);
            this.chartHistogram.TabIndex = 23;
            this.chartHistogram.Text = "chart1";
            this.chartHistogram.Click += new System.EventHandler(this.chartHistogram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 626);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.textBoxResearch);
            this.Controls.Add(this.textBoxHistogram);
            this.Controls.Add(this.labelConclusion);
            this.Controls.Add(this.labelLambdaValue);
            this.Controls.Add(this.labelLambda);
            this.Controls.Add(this.labelDValue);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelStdValue);
            this.Controls.Add(this.labelStd);
            this.Controls.Add(this.labelVarianceValue);
            this.Controls.Add(this.labelVariance);
            this.Controls.Add(this.labelMeanValue);
            this.Controls.Add(this.labelMean);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxBins);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxLambda0);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.TextBox textBoxLambda0;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxBins;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelMean;
        private System.Windows.Forms.Label labelMeanValue;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Label labelVarianceValue;
        private System.Windows.Forms.Label labelStd;
        private System.Windows.Forms.Label labelStdValue;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelDValue;
        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.Label labelLambdaValue;
        private System.Windows.Forms.Label labelConclusion;
        private System.Windows.Forms.TextBox textBoxHistogram;
        private System.Windows.Forms.TextBox textBoxResearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
    }
}

