using System;
using System.Linq;

public class HistogramBin
{
    public double Left { get; set; }
    public double Right { get; set; }
    public double Density { get; set; }
    public int Count { get; set; }
}

public static class HistogramHelper
{
    public static HistogramBin[] BuildHistogram(double[] sample, int bins)
    {
        double min = sample.Min();
        double max = sample.Max();
        double h = (max - min) / bins;

        int[] counts = new int[bins];

        foreach (var x in sample)
        {
            int bin = (int)((x - min) / h);
            if (bin == bins) bin--;
            counts[bin]++;
        }

        int N = sample.Length;
        HistogramBin[] result = new HistogramBin[bins];

        for (int i = 0; i < bins; i++)
        {
            double left = min + i * h;
            double right = left + h;
            double density = counts[i] / (N * h);

            result[i] = new HistogramBin
            {
                Left = left,
                Right = right,
                Density = density,
                Count = counts[i]
            };
        }

        return result;
    }
}
