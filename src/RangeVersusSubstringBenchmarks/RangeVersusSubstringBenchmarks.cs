
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace RangeVersusSubstringBenchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class RangeVersusSubstringBenchmarks
{
    private readonly string _testString;
    private readonly int _endIndex;

    public RangeVersusSubstringBenchmarks()
    {
        _testString = "1uXd3l2yLqNT2lUa96kJ1uXd3l2yLqNT2lUa96kJ";
        _endIndex = 29;
    }

    [Benchmark(Baseline = true)]
    public void GetSubstring()
    {
        _ = _testString.Substring(0, _endIndex);
    }
    
    [Benchmark]
    public void GetSubstringByRange()
    {
        _ = _testString[.._endIndex];
    }
}
