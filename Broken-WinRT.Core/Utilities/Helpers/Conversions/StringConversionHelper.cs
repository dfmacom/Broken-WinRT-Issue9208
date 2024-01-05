namespace Broken_WinRT.Core.Utilities.Helpers.Conversions;
public static class StringConversionHelper
{
    public static double StringToDouble(string value)
    {
        return Convert.ToDouble(value.Trim());
    }
}
