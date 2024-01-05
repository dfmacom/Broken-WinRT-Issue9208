namespace Broken_WinRT.Core.Utilities.Enumerations;
public class EProjectType : Enumeration
{
    public static readonly EProjectType Foundry = new(0, "Foundry");
    public static readonly EProjectType NPI = new(0, "NPI");

    public EProjectType(int id, string name) : base(id, name)
    {
    }
}
