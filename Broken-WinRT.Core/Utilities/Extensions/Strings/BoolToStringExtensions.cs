namespace Broken_WinRT.Core.Utilities.Extensions.Strings;
public static class BoolToStringExtensions
{
    public static string YesNo(this bool val)
    {
        return val ? "YES" : "NO";
    }
    public static string OnOff(this bool val)
    {
        return val ? "ON" : "OFF";
    }
    public static string OneZero(this bool val)
    {
        return val ? "1" : "0";
    }
    public static string EnableDisable(this bool val)
    {
        return val ? "Enable" : "Disable";
    }
}
