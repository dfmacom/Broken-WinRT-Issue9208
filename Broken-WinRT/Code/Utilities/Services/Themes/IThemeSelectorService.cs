using Microsoft.UI.Xaml;

namespace Broken_WinRT.Code.Utilities.Services.Themes;

public interface IThemeSelectorService
{
    ElementTheme Theme
    {
        get;
    }

    Task InitializeAsync();

    Task SetThemeAsync(ElementTheme theme);

    Task SetRequestedThemeAsync();
}
