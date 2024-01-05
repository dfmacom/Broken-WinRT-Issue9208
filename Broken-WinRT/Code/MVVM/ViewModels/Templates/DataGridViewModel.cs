using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Broken_WinRT.Core.MVVM.Models;
using Broken_WinRT.Core.MVVM.Models.Templates;
using Broken_WinRT.Core.MVVM.ViewModels;
using Broken_WinRT.Core.Services.Data.Templates;

namespace Broken_WinRT.Code.MVVM.ViewModels.Templates;

public partial class DataGridViewModel : ViewModel, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public DataGridViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async override Task OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public async override Task OnNavigatedFrom()
    {
    }

    protected override void OnItemClick(IModel? clickedItem) => throw new NotImplementedException();
}
