namespace Broken_WinRT.Core.MVVM.ViewModels;

/// <summary>
/// All ViewModels can implement the INavigationAware interface to execute code on navigation events.
/// </summary>
public interface INavigationAware
{
    Task OnNavigatedTo(object parameter);

    Task OnNavigatedFrom();
}
