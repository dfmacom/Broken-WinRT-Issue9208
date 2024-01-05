using Broken_WinRT.Core.MVVM.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Broken_WinRT.Core.MVVM.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>

public abstract partial class PageView : Page, IView
{
    public ViewModel ViewModel { get; }

    protected PageView(ViewModel viewModel)
    {
        ViewModel = viewModel;
    }
}
