using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Code.Utilities.Services.Navigation;
using Microsoft.UI.Xaml;

namespace Broken_WinRT.Code.Utilities.Handlers.Activation;

public class DefaultActivationHandler(INavigationService navigationService) : ActivationHandler<LaunchActivatedEventArgs>
{
    protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
    {
        // None of the ActivationHandlers has handled the activation.
        return navigationService.Frame?.Content == null;
    }

    protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
    {
        navigationService.NavigateTo(typeof(HomeViewModel).FullName!, args.Arguments);
        await Task.CompletedTask;
    }
}
