using System;
using System.Linq;

public static class WeibullAnalyzer
{
    public static double[] GenerateWeibullSample(int N, double k, double lambda0)
    {
        Random rnd = new Random();
        double[] sample = new double[N];
        for (int i = 0; i < N; i++)
        {
            double u = rnd.NextDouble();
            sample[i] = Math.Pow(-Math.Log(u) / lambda0, 1.0 / k);
        }
        return sample;
    }

    public static double WeibullCDF(double x, double k, double lambda0)
    {
        if (x < 0) return 0.0;
        return 1.0 - Math.Exp(-lambda0 * Math.Pow(x, k));
    }

    public static double KolmogorovD(double[] sample, Func<double, double> cdf)
    {
        int N = sample.Length;
        double D = 0.0;
        for (int i = 0; i < N; i++)
        {
            double Fn = (i + 1.0) / N;
            double F = cdf(sample[i]);
            double diff = Math.Abs(Fn - F);
            if (diff > D) D = diff;
        }
        return D;
    }

    public static (double mean, double variance, double std) GetStatistics(double[] sample)
    {
        double mean = sample.Average();
        double variance = sample.Select(x => (x - mean) * (x - mean)).Average();
        double std = Math.Sqrt(variance);
        return (mean, variance, std);
    }
}
