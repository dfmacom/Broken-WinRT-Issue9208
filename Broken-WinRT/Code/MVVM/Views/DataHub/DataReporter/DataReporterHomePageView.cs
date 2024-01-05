using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataReporter;
using Broken_WinRT.Core.MVVM.Views;

namespace Broken_WinRT.Code.MVVM.Views.DataHub.DataReporter;

public sealed partial class DataReporterHomePageView : PageView
{
    public DataReporterHomePageView() : base(App.GetService<DataReporterViewModel>())
    {
    }
}
