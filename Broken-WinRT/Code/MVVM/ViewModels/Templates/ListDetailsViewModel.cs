using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Broken_WinRT.Core.MVVM.Models;
using Broken_WinRT.Core.MVVM.Models.Templates;
using Broken_WinRT.Core.MVVM.ViewModels;
using Broken_WinRT.Core.Services.Data.Templates;

namespace Broken_WinRT.Code.MVVM.ViewModels.Templates;

public partial class ListDetailsViewModel : ViewModel, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? selected;

    public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

    public ListDetailsViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async override Task OnNavigatedTo(object parameter)
    {
        SampleItems.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetListDetailsDataAsync();

        foreach (var item in data)
        {
            SampleItems.Add(item);
        }
    }

    public async override Task OnNavigatedFrom()
    {
    }

    public void EnsureItemSelected()
    {
        Selected ??= SampleItems.First();
    }

    protected override void OnItemClick(IModel? clickedItem) => throw new NotImplementedException();
}
