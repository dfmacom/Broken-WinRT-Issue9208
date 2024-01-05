using Broken_WinRT.Code.MVVM.ViewModels.DataHub;
using Broken_WinRT.Core.MVVM.ViewModels;
using Broken_WinRT.Core.MVVM.Views;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Broken_WinRT.Code.MVVM.Views.DataHub;

public sealed partial class DataHubHomePageView : PageView
{
    public DataHubHomePageView() : base(App.GetService<DataHubHomePageViewModel>())
    {
        InitializeComponent();
    }
}