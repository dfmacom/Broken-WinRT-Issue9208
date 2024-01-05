using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataAnalyzer;
using Broken_WinRT.Core.MVVM.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Broken_WinRT.Code.MVVM.Views.DataHub.DataAnalyzer;

public sealed partial class DataAnalyzerHomePageView : PageView
{
    public DataAnalyzerHomePageView() : base(App.GetService<DataAnalyzerViewModel>())
    {
    }
}
