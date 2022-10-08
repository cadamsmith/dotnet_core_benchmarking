
using BenchmarkDotNet.Running;

namespace BenchmarkExample;

internal static class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<DateTimeParserBenchmarks>();
    }
}
