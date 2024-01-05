namespace Broken_WinRT.Core.Utilities.Enumerations;
public class EFileType : Enumeration
{
    public static readonly EFileType SParameters = new(0, "S-Parameters");
    public static readonly EFileType PowerSweep = new(1, "Power Sweep");
    public static readonly EFileType DCTest = new(2, "DC Test");
    public static readonly EFileType Screening = new(3, "Screening");

    private EFileType(int id, string name) : base(id, name)
    {
    }

    internal static bool IsDCType(string test) => test == DCTest.Name;
    internal static bool IsRFType(string test) => test == SParameters.Name || test == PowerSweep.Name;
    //internal bool IsCompatibleWith(Spec spec) => spec.Info.Test == Name || spec.Info.Test == DCTest.Name;
}