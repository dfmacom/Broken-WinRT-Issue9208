using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataFileWriter;
using Broken_WinRT.Core.MVVM.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Broken_WinRT.Code.MVVM.Views.DataHub.DataFileWriter;

public sealed partial class DataFileWriterHomePageView : PageView
{
    public DataFileWriterHomePageView() : base(App.GetService<DataWriterViewModel>())
    {
    }
}
