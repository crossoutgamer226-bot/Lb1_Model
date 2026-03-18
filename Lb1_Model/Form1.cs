using System;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lb1_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void chartHistogram_Click(object sender, EventArgs e)
        {
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxK.Text, out double k))
                k = 1.5;

            if (!double.TryParse(textBoxLambda0.Text, out double lambda0))
                lambda0 = 0.7;

            if (!int.TryParse(textBoxN.Text, out int N))
                N = 10000;

            if (!int.TryParse(textBoxBins.Text, out int bins))
                bins = 20;

            double[] sample = WeibullAnalyzer.GenerateWeibullSample(N, k, lambda0);

            var stats = WeibullAnalyzer.GetStatistics(sample);
            labelMeanValue.Text = stats.mean.ToString("F5");
            labelVarianceValue.Text = stats.variance.ToString("F5");
            labelStdValue.Text = stats.std.ToString("F5");

            Array.Sort(sample);
            double D = WeibullAnalyzer.KolmogorovD(sample, x => WeibullAnalyzer.WeibullCDF(x, k, lambda0));
            double lambda = D * Math.Sqrt(N);
            double lambdaCritical = 1.36;

            labelDValue.Text = D.ToString("F5");
            labelLambdaValue.Text = lambda.ToString("F5");

            labelConclusion.Text = (lambda < lambdaCritical)
                ? "H0 не отвергается (распределение согласуется)."
                : "H0 отвергается (распределение не согласуется).";

            var binsData = HistogramHelper.BuildHistogram(sample, bins);

            var sb = new StringBuilder();
            foreach (var bin in binsData)
            {
                sb.AppendLine(
                    $"[{bin.Left:F3}; {bin.Right:F3}]  f_exp = {bin.Density:F5}  (count = {bin.Count})");
            }
            textBoxHistogram.Text = sb.ToString();

            DrawHistogramChart(binsData, k, lambda0);

            RunResearch(k, lambda0);
        }

        private void DrawHistogramChart(HistogramBin[] binsData, double k, double lambda0)
        {
            chartHistogram.Series.Clear();
            chartHistogram.ChartAreas.Clear();

            var area = new ChartArea("area");
            area.AxisX.Title = "x";
            area.AxisY.Title = "f(x)";
            area.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            area.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartHistogram.ChartAreas.Add(area);

            var series = new Series("hist");
            series.ChartType = SeriesChartType.Column;
            series.Color = System.Drawing.Color.SteelBlue;
            series.BorderColor = System.Drawing.Color.Black;
            series.BorderWidth = 1;

            foreach (var bin in binsData)
            {
                double center = (bin.Left + bin.Right) / 2.0;
                series.Points.AddXY(center, bin.Density);
            }

            chartHistogram.Series.Add(series);

            double minX = binsData[0].Left;
            double maxX = binsData[binsData.Length - 1].Right;

            DrawTheoreticalDensity(k, lambda0, minX, maxX);
        }

        private void DrawTheoreticalDensity(double k, double lambda0, double minX, double maxX)
        {
            var series = new Series("theory");
            series.ChartType = SeriesChartType.Line;
            series.Color = System.Drawing.Color.Red;
            series.BorderWidth = 2;

            int points = 200;
            double step = (maxX - minX) / points;

            for (int i = 0; i <= points; i++)
            {
                double x = minX + i * step;
                double f = lambda0 * k * Math.Pow(x, k - 1) * Math.Exp(-lambda0 * Math.Pow(x, k));
                series.Points.AddXY(x, f);
            }

            chartHistogram.Series.Add(series);
        }

        private void RunResearch(double k, double lambda0)
        {
            var sb = new StringBuilder();

            sb.AppendLine("=== Влияние объема выборки N ===");

            int[] Ns = { 500, 2000, 10000, 50000 };

            foreach (int nTest in Ns)
            {
                double[] s = WeibullAnalyzer.GenerateWeibullSample(nTest, k, lambda0);
                Array.Sort(s);
                double dTest = WeibullAnalyzer.KolmogorovD(s, x => WeibullAnalyzer.WeibullCDF(x, k, lambda0));
                double lambdaTest = dTest * Math.Sqrt(nTest);

                sb.AppendLine($"N = {nTest,6}: D = {dTest:F5}, λ = {lambdaTest:F5}");
            }

            sb.AppendLine();
            sb.AppendLine("=== Влияние числа интервалов bins ===");

            double[] sample = WeibullAnalyzer.GenerateWeibullSample(10000, k, lambda0);
            int[] binsArray = { 10, 20, 30, 40 };

            foreach (int b in binsArray)
            {
                sb.AppendLine($"\nbins = {b}:");

                var hData = HistogramHelper.BuildHistogram(sample, b);

                foreach (var bin in hData)
                {
                    sb.AppendLine(
                        $"[{bin.Left:F3}; {bin.Right:F3}]  f_exp = {bin.Density:F5}  (count = {bin.Count})");
                }
            }

            textBoxResearch.Text = sb.ToString();
        }

        private void labelMean_Click(object sender, EventArgs e) { }
        private void textBoxResearch_TextChanged(object sender, EventArgs e) { }
        private void textBoxHistogram_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBoxK_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBoxLambda0_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBoxN_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBoxBins_TextChanged(object sender, EventArgs e) { }
        private void labelVariance_Click(object sender, EventArgs e) { }
        private void labelStd_Click(object sender, EventArgs e) { }
        private void labelD_Click(object sender, EventArgs e) { }
        private void labelLambda_Click(object sender, EventArgs e) { }
    }
}
