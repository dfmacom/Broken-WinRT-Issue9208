using Broken_WinRT.Core.MVVM.Models;
using Broken_WinRT.Core.MVVM.ViewModels;

namespace Broken_WinRT.Code.MVVM.ViewModels.Templates;

public partial class HomeViewModel : ViewModel
{
    public HomeViewModel()
    {
    }

    public async override Task OnNavigatedFrom()
    {

    }

    public async override Task OnNavigatedTo(object parameter)
    {

    }

    protected override void OnItemClick(IModel? clickedItem) => throw new NotImplementedException();
}
