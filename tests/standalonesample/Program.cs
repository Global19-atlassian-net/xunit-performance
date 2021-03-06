// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Xunit.Performance;
using Microsoft.Xunit.Performance.Api;
using System.Reflection;

public class Program
{
    private static void Main(string[] args)
    {
        using (XunitPerformanceHarness p = new XunitPerformanceHarness(args))
        {
            string entryAssemblyPath = Assembly.GetEntryAssembly().Location;
            p.RunBenchmarks(entryAssemblyPath);
        }
    }

    [Benchmark(InnerIterationCount = 10000)]
    public void TestBenchmark()
    {
        foreach (BenchmarkIteration iter in Benchmark.Iterations)
        {
            using (iter.StartMeasurement())
            {
                for (int i = 0; i < Benchmark.InnerIterationCount; i++)
                {
                    string.Format("{0}{1}{2}{3}", "a", "b", "c", "d");
                }
            }
        }
    }

    [Benchmark(InnerIterationCount = 10000)]
    public void TestBenchmark1()
    {
        foreach (BenchmarkIteration iter in Benchmark.Iterations)
        {
            using (iter.StartMeasurement())
            {
                for (int i = 0; i < Benchmark.InnerIterationCount; i++)
                {
                    string.Format("{0}{1}{2}{3}", "a", "b", "c", "d");
                }
            }
        }
    }

    [Benchmark(InnerIterationCount = 10000)]
    public void TestBenchmark2()
    {
        foreach (BenchmarkIteration iter in Benchmark.Iterations)
        {
            using (iter.StartMeasurement())
            {
                for (int i = 0; i < Benchmark.InnerIterationCount; i++)
                {
                    string.Format("{0}{1}{2}{3}", "a", "b", "c", "d");
                }
            }
        }
    }
}
