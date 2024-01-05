using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Broken_WinRT.Code.MVVM.Models.DataHub;
using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Code.Utilities.Services.Navigation;
using Broken_WinRT.Core.MVVM.Models;
using Broken_WinRT.Core.MVVM.Models.Templates;
using Broken_WinRT.Core.MVVM.ViewModels;
using Broken_WinRT.Core.Services.Data.Templates;

namespace Broken_WinRT.Code.MVVM.ViewModels.DataHub;

public partial class DataHubHomePageViewModel : ViewModel
{
    private readonly INavigationService _navigationService;
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<IModel> Source { get; } = [];

    public DataHubHomePageViewModel(INavigationService navigationService, ISampleDataService sampleDataService, IEnumerable<IModel<DataHubHomePageViewModel>> actionModels)
    {
        _navigationService = navigationService;
        _sampleDataService = sampleDataService;
        foreach (var actionModel in actionModels)
        {
            Source.Add(actionModel);
        }
    }

    public override async Task OnNavigatedTo(object parameter)
    {

    }

    public override async Task OnNavigatedFrom()
    {

    }


    protected override void OnItemClick(IModel? clickedItem)
    {
        if (clickedItem != null)
        {
            _navigationService.SetListDataItemForNextConnectedAnimation(clickedItem);
            _navigationService.NavigateTo(clickedItem.ViewModelType.FullName!);
        }
    }
}