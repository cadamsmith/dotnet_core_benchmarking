
namespace BenchmarkExample;

public class DateTimeParser
{
    /// <summary>
    /// Retrieves year from iso datetime string, using DateTime.Parse and DateTime.Year property
    /// </summary>
    /// <param name="isoDateTime">datetime in ISO format</param>
    /// <returns>year number</returns>
    public int GetYearFromDateTime(string isoDateTime)
    {
        var dateTime = DateTime.Parse(isoDateTime);
        return dateTime.Year;
    }

    /// <summary>
    /// Retrieves year from iso datetime string, using string split and int.Parse
    /// </summary>
    /// <param name="isoDateTime">datetime in ISO format</param>
    /// <returns>year number</returns>
    public int GetYearFromDateTimeUsingSplit(string isoDateTime)
    {
        var splitOnHyphen = isoDateTime.Split("-");
        return int.Parse(splitOnHyphen[0]);
    }

    /// <summary>
    /// Retrieves year from iso datetime string, using range operator
    /// </summary>
    /// <param name="isoDateTime"></param>
    /// <returns></returns>
    public int GetYearFromDateTimeUsingRange(string isoDateTime)
    {
        var indexOfHyphen = isoDateTime.IndexOf("-", StringComparison.Ordinal);
        return int.Parse(isoDateTime[0..indexOfHyphen]);
    }

    /// <summary>
    /// Retrieves year from iso datetime span, using range operator
    /// </summary>
    /// <param name="isoDateTimeSpan"></param>
    /// <returns></returns>
    public int GetYearFromDateTimeSpanUsingRange(ReadOnlySpan<char> isoDateTimeSpan)
    {
        var indexOfHyphen = isoDateTimeSpan.IndexOf("-", StringComparison.Ordinal);
        return int.Parse(isoDateTimeSpan[..indexOfHyphen]);
    }
    
    public int GetYearFromDateTimeSpanUsingManualConversion(ReadOnlySpan<char> isoDateTimeSpan)
    {
        var indexOfHyphen = isoDateTimeSpan.IndexOf("-", StringComparison.Ordinal);
        var yearAsASpan = isoDateTimeSpan[..indexOfHyphen];

        var year = 0;
        foreach (var digitChar in yearAsASpan)
        {
            year = year * 10 + (digitChar - '0');
        }
        
        return year;
    }
}