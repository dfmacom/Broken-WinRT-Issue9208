using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Core.MVVM.Views;
using Microsoft.UI.Xaml.Controls;

namespace Broken_WinRT.Code.MVVM.Views.Templates;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class DataGridPageView : Page, IView
{
    public DataGridViewModel ViewModel
    {
        get;
    }

    public DataGridPageView()
    {
        ViewModel = App.GetService<DataGridViewModel>();
        InitializeComponent();
    }
}
