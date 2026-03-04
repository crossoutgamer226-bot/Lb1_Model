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

        // ====== ДОБАВЛЕНО: пустой обработчик загрузки формы ======
        private void Form1_Load(object sender, EventArgs e)
        {
            // Можно оставить пустым
        }

        // ====== ДОБАВЛЕНО: пустой обработчик клика по Chart ======
        private void chartHistogram_Click(object sender, EventArgs e)
        {
            // Можно оставить пустым
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            // Чтение параметров
            if (!double.TryParse(textBoxK.Text, out double k))
                k = 1.5;

            if (!double.TryParse(textBoxLambda0.Text, out double lambda0))
                lambda0 = 0.7;

            if (!int.TryParse(textBoxN.Text, out int N))
                N = 10000;

            if (!int.TryParse(textBoxBins.Text, out int bins))
                bins = 20;

            // Генерация выборки
            double[] sample = WeibullAnalyzer.GenerateWeibullSample(N, k, lambda0);

            // Статистики
            var stats = WeibullAnalyzer.GetStatistics(sample);
            labelMeanValue.Text = stats.mean.ToString("F5");
            labelVarianceValue.Text = stats.variance.ToString("F5");
            labelStdValue.Text = stats.std.ToString("F5");

            // Критерий Колмогорова
            Array.Sort(sample);
            double D = WeibullAnalyzer.KolmogorovD(sample, x => WeibullAnalyzer.WeibullCDF(x, k, lambda0));
            double lambda = D * Math.Sqrt(N);
            double lambdaCritical = 1.36;

            labelDValue.Text = D.ToString("F5");
            labelLambdaValue.Text = lambda.ToString("F5");

            if (lambda < lambdaCritical)
                labelConclusion.Text = "H0 не отвергается (распределение согласуется).";
            else
                labelConclusion.Text = "H0 отвергается (распределение не согласуется).";

            // --- Данные для гистограммы ---
            var binsData = HistogramHelper.BuildHistogram(sample, bins);

            // --- Текстовая гистограмма (можно удалить, если не нужна) ---
            var sb = new StringBuilder();
            foreach (var bin in binsData)
            {
                sb.AppendLine(
                    $"[{bin.Left:F3}; {bin.Right:F3}]  f_exp = {bin.Density:F5}  (count = {bin.Count})");
            }
            textBoxHistogram.Text = sb.ToString();

            // --- Графическая гистограмма ---
            DrawHistogramChart(binsData);
        }

        private void DrawHistogramChart(HistogramBin[] binsData)
        {
            // Очистить старые данные
            chartHistogram.Series.Clear();
            chartHistogram.ChartAreas.Clear();

            // Область построения
            var area = new ChartArea("area");
            area.AxisX.Title = "x";
            area.AxisY.Title = "f_exp(x)";
            area.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            area.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartHistogram.ChartAreas.Add(area);

            // Серия для столбиков
            var series = new Series("hist");
            series.ChartType = SeriesChartType.Column;
            series.Color = System.Drawing.Color.SteelBlue;
            series.BorderColor = System.Drawing.Color.Black;
            series.BorderWidth = 1;

            // Добавляем точки: центр интервала -> плотность
            foreach (var bin in binsData)
            {
                double center = (bin.Left + bin.Right) / 2.0;
                series.Points.AddXY(center, bin.Density);
            }

            chartHistogram.Series.Add(series);
        }
    }
}
