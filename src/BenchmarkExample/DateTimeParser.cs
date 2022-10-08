
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
}