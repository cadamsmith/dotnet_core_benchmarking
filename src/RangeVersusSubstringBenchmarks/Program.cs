
using BenchmarkDotNet.Running;

namespace RangeVersusSubstringBenchmarks;

internal static class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<RangeVersusSubstringBenchmarks>();
    }
}