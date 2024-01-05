namespace Broken_WinRT.Core.Utilities.Extensions.Strings;
public static class SIUnitExtensions
{
    private static readonly Dictionary<double, char> SIPrefixes = new Dictionary<double, char>()
        {
            { 1e24, 'Y' },
            { 1e21, 'Z' },
            { 1e18, 'E' },
            { 1e15, 'P' },
            { 1e12, 'T' },
            { 1e9, 'G' },
            { 1e6, 'M' },
            { 1e3, 'k' },
            { 1, ' ' },
            { 1e-3, 'm' },
            { 1e-6, 'u' },
            { 1e-9, 'n' },
            { 1e-12, 'p' },
            { 1e-15, 'f' },
            { 1e-18, 'a' },
            { 1e-21, 'z' },
            { 1e-24, 'y' }
        };


    /// <summary>
    /// Reformats numeric value to contain the shortest possible form including an SI prefix
    /// E.g: 1000 -> 1k
    /// </summary>
    /// <param name="val">Numeric value</param>
    /// <returns>String representing most concise form of that value including SI prefix</returns>
    public static string AddSIPrefix(this double val)
    {
        foreach (var keyValue in SIPrefixes)
        {
            if (val >= keyValue.Key)
            {
                return (Convert.ToString(val / keyValue.Key) + keyValue.Value).TrimEnd(' ');
            }
        }
        return val.ToString();
    }
    /// <summary>
    /// Scales numeric string value if it contains an SI unit prefix after the number (e.g. k, M, G)
    /// </summary>
    /// <param name="val">String contianing a numeric value with units</param>
    /// <returns>Numeric value scaled by unit prefix</returns>
    public static double NumberWithUnits(this string val)
    {
        double value;
        string unit, number;
        if (double.TryParse(val, out value))
        {
            return value;
        }
        else
        {
            unit = new string(val.SkipWhile(c => !char.IsLetter(c)).ToArray());
            if (unit != string.Empty)
            {
                number = val.Substring(0, val.Length - unit.Length);
                if (double.TryParse(number, out value))
                {
                    switch (unit[0])
                    {
                        case 'Y':
                            return value * 1e24;
                        case 'Z':
                            return value * 1e21;
                        case 'E':
                            return value * 1e18;
                        case 'P':
                            return value * 1e15;
                        case 'T':
                            return value * 1e12;
                        case 'G':
                            return value * 1e9;
                        case 'M':
                            return value * 1e6;
                        case 'k':
                            return value * 1e3;
                        case 'm':
                            return value * 1e-3;
                        case 'μ':
                        case 'u':
                            return value * 1e-6;
                        case 'n':
                            return value * 1e-9;
                        case 'p':
                            return value * 1e-12;
                        case 'f':
                            return value * 1e-15;
                        case 'a':
                            return value * 1e-18;
                        case 'z':
                            return value * 1e-21;
                        case 'y':
                            return value * 1e-24;
                        default:
                            return value;
                    }
                }
            }
            return double.NaN;
        }
    }
}
