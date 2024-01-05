using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Broken_WinRT.Core.MVVM.Models;

namespace Broken_WinRT.Core.MVVM.ViewModels;

public abstract partial class ViewModel : ObservableRecipient, INavigationAware
{
    public ObservableCollection<IModel> Source { get; } = [];
    public abstract Task OnNavigatedFrom();
    public abstract Task OnNavigatedTo(object parameter);
    [RelayCommand]
    protected abstract void OnItemClick(IModel? clickedItem);
}
