using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataSetDesigner;
using Broken_WinRT.Core.MVVM.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Broken_WinRT.Code.MVVM.Views.DataHub.DataSetDesigner;

public sealed partial class DatasetDesignerHomePageView : PageView
{
    public DatasetDesignerHomePageView() : base(App.GetService<DataSetDesignerViewModel>())
    {
    }
}
