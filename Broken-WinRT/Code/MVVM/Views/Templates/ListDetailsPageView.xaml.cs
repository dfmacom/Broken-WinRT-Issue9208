using CommunityToolkit.WinUI.UI.Controls;
using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Core.MVVM.Views;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace Broken_WinRT.Code.MVVM.Views.Templates;

public sealed partial class ListDetailsPageView : Page, IView
{
    public ListDetailsViewModel ViewModel { get; }

    public ListDetailsPageView()
    {
        ViewModel = App.GetService<ListDetailsViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
    }
}
