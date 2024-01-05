using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataLoader;
using Broken_WinRT.Core.MVVM.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Broken_WinRT.Code.MVVM.Views.DataHub.DataLoader;

public sealed partial class DataLoaderHomePageView : PageView
{
    public DataLoaderHomePageView() : base(App.GetService<DataLoaderViewModel>())
    {
    }
}
