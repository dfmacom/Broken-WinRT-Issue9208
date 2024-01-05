using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataTableViewer;
using Broken_WinRT.Core.MVVM.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Broken_WinRT.Code.MVVM.Views.DataHub.DataTableViewer;

public sealed partial class DataTableViewerHomePageView : PageView
{
    public DataTableViewerHomePageView() : base(App.GetService<DataTableViewerViewModel>())
    {
    }
}
