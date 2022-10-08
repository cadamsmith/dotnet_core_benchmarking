
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkExample;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateTimeParserBenchmarks
{
    private readonly string _dateTime;

    public DateTimeParserBenchmarks()
    {
        _dateTime = "2019-12-13T16:33:06Z";
    }

    [Benchmark(Baseline = true)]
    public void GetYearFromDateTime()
    {
        DateTimeParser.GetYearFromDateTime(_dateTime);
    }

    [Benchmark]
    public void GetYearFromDateTimeUsingSplit()
    {
        DateTimeParser.GetYearFromDateTimeUsingSplit(_dateTime);
    }
    
    [Benchmark]
    public void GetYearFromDateTimeUsingRange()
    {
        DateTimeParser.GetYearFromDateTimeUsingRange(_dateTime);
    }
    
    [Benchmark]
    public void GetYearFromDateTimeSpanUsingRange()
    {
        DateTimeParser.GetYearFromDateTimeSpanUsingRange(_dateTime);
    }

    [Benchmark]
    public void GetYearFromDateTimeSpanUsingManualConversion()
    {
        DateTimeParser.GetYearFromDateTimeSpanUsingManualConversion(_dateTime);
    }
}
