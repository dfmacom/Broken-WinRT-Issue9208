namespace Broken_WinRT.Core.Utilities.Enumerations;

public class ESecurityClassification : Enumeration
{
    public static readonly ESecurityClassification Unclassified = new(0, "Unclassified");
    public static readonly ESecurityClassification Secret = new(1, "Secret");

    private ESecurityClassification(int id, string name) : base(id, name)
    {
    }

    internal static object Resolve(string value)
    {
        return value.ToUpper() switch
        {
            "UNCLASSIFIED" or "NONE" or "N/A" => Unclassified.Name,
            _ => Secret.Name,
        };
    }
}