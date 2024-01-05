using Broken_WinRT.Code.MVVM.ViewModels;
using Broken_WinRT.Core.MVVM.Models;

namespace Broken_WinRT.Code.MVVM.Models;

public sealed class LocalSettingsOptionsModel : Model<SettingsViewModel>
{
    public LocalSettingsOptionsModel() 
        : base("Local Settings", 
            "Settings", 
            "\uE713", 
            typeof(SettingsViewModel))
    {
    }

    public string? ApplicationDataFolder { get; set; }

    public string? LocalSettingsFile { get; set; }
}
