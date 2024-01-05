using CommunityToolkit.Mvvm.ComponentModel;
using Broken_WinRT.Core.MVVM.Models.Templates;
using Broken_WinRT.Core.MVVM.ViewModels;
using Broken_WinRT.Core.Services.Data.Templates;

namespace Broken_WinRT.Code.MVVM.ViewModels.Templates;

public partial class ContentGridDetailViewModel : ObservableObject, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public ContentGridDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async Task OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public async Task OnNavigatedFrom()
    {
    }
}
