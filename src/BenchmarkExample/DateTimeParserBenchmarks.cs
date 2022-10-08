using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkExample;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateTimeParserBenchmarks
{
    private const string DateTime = "2019-12-13T16:33:06Z";
    private static readonly DateTimeParser Parser = new ();

    [Benchmark(Baseline = true)]
    public void GetYearFromDateTime()
    {
        Parser.GetYearFromDateTime(DateTime);
    }

    [Benchmark]
    public void GetYearFromDateTimeUsingSplit()
    {
        Parser.GetYearFromDateTimeUsingSplit(DateTime);
    }
    
    [Benchmark]
    public void GetYearFromDateTimeUsingRange()
    {
        Parser.GetYearFromDateTimeUsingRange(DateTime);
    }
    
    [Benchmark]
    public void GetYearFromDateTimeSpanUsingRange()
    {
        Parser.GetYearFromDateTimeSpanUsingRange(DateTime);
    }

    [Benchmark]
    public void GetYearFromDateTimeSpanUsingManualConversion()
    {
        Parser.GetYearFromDateTimeSpanUsingManualConversion(DateTime);
    }
}