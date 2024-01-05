namespace Broken_WinRT.Core.Utilities.Enumerations;

public class EWaferTestDataHeaderCategory : Enumeration
{
    public static readonly EWaferTestDataHeaderCategory TestDetails = new(0, "Test Details");
    public static readonly EWaferTestDataHeaderCategory DCBiasInfo = new(1, "DC Bias Info");
    public static readonly EWaferTestDataHeaderCategory ProductInfo = new(2, "Product Info");
    public static readonly EWaferTestDataHeaderCategory ElectricalParameter = new(3, "Electrical Parameter");

    public EWaferTestDataHeaderCategory(int id, string name) : base(id, name)
    {
    }
}