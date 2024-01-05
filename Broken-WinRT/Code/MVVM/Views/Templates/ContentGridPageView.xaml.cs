using Broken_WinRT.Code.MVVM.ViewModels;
using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Core.MVVM.Views;
using Microsoft.UI.Xaml.Controls;

namespace Broken_WinRT.Code.MVVM.Views.Templates;

public sealed partial class ContentGridPageView : Page, IView
{
    public ContentGridViewModel ViewModel { get; }

    public ContentGridPageView()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
