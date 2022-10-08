
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkExample;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
internal class DateTimeParserBenchmarks
{
    private const string DateTime = "2019-12-13T16:33:06Z";

    [Benchmark(Baseline = true)]
    public static void GetYearFromDateTime()
    {
        DateTimeParser.GetYearFromDateTime(DateTime);
    }

    [Benchmark]
    public static void GetYearFromDateTimeUsingSplit()
    {
        DateTimeParser.GetYearFromDateTimeUsingSplit(DateTime);
    }
    
    [Benchmark]
    public static void GetYearFromDateTimeUsingRange()
    {
        DateTimeParser.GetYearFromDateTimeUsingRange(DateTime);
    }
    
    [Benchmark]
    public static void GetYearFromDateTimeSpanUsingRange()
    {
        DateTimeParser.GetYearFromDateTimeSpanUsingRange(DateTime);
    }

    [Benchmark]
    public static void GetYearFromDateTimeSpanUsingManualConversion()
    {
        DateTimeParser.GetYearFromDateTimeSpanUsingManualConversion(DateTime);
    }
}
