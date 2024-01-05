namespace Broken_WinRT.Core.Utilities.Enumerations;

public sealed class EAppStatus : Enumeration
{
    public static readonly EAppStatus Dormant = new(0, "Dormant");
    public static readonly EAppStatus Running = new(1, "Running");
    public static readonly EAppStatus Crashed = new(2, "Crashed");

    public EAppStatus(int id, string name) : base(id, name)
    {
    }
}
