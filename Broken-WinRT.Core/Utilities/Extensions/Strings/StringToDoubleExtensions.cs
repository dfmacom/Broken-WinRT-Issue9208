namespace Broken_WinRT.Core.Utilities.Extensions.Strings;
public static class StringToDoubleExtensions
{
    public static double[]? ToDoubleArray(this string xmlStringArray)
    {
        var stringPoints = xmlStringArray.Split(',', StringSplitOptions.TrimEntries);
        var doublePoints = new List<double>();
        foreach (var stringPoint in stringPoints)
        {
            var success = double.TryParse(stringPoint.Trim('[').Trim(']').Trim(), out var doublePoint);
            if (success)
            {
                doublePoints.Add(doublePoint);
            }
            else
            {

            }
        }
        return doublePoints.ToArray();
    }

    public static double ExtractDouble(this string value)
    {
        var val = string.Empty;
        foreach (var c in value)
        {
            if (char.IsDigit(c) || c is '.')
            {
                val += c;
            }
        }
        return double.Parse(val);
    }
}
