using CommunityToolkit.WinUI.UI.Animations;
using Broken_WinRT.Code.MVVM.ViewModels;
using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Code.Utilities.Services.Navigation;
using Broken_WinRT.Core.MVVM.Views;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace Broken_WinRT.Code.MVVM.Views.Templates;

public sealed partial class ContentGridDetailPageView : Page, IView
{
    public ContentGridDetailViewModel ViewModel { get; }

    public ContentGridDetailPageView()
    {
        ViewModel = App.GetService<ContentGridDetailViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        this.RegisterElementForConnectedAnimation("animationKeyContentGrid", itemHero);
    }

    protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
        base.OnNavigatingFrom(e);
        if (e.NavigationMode == NavigationMode.Back)
        {
            var navigationService = App.GetService<INavigationService>();

            if (ViewModel.Item != null)
            {
                navigationService.SetListDataItemForNextConnectedAnimation(ViewModel.Item);
            }
        }
    }
}
