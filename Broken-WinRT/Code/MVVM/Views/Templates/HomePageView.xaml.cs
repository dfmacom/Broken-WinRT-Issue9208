using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Core.MVVM.Views;
using Microsoft.UI.Xaml.Controls;

namespace Broken_WinRT.Code.MVVM.Views.Templates;

public sealed partial class HomePageView : Page, IView
{
    public HomeViewModel ViewModel
    {
        get;
    }

    public HomePageView()
    {
        ViewModel = App.GetService<HomeViewModel>();
        InitializeComponent();
    }
}
