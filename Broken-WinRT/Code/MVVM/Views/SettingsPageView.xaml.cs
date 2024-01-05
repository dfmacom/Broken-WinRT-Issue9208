using Broken_WinRT.Code.MVVM.ViewModels;
using Broken_WinRT.Core.MVVM.Views;
using Microsoft.UI.Xaml.Controls;

namespace Broken_WinRT.Code.MVVM.Views;

// TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
public sealed partial class SettingsPageView : Page, IView
{
    public SettingsViewModel ViewModel { get; }

    public SettingsPageView()
    {
        ViewModel = App.GetService<SettingsViewModel>();
        InitializeComponent();
    }
}
