using Broken_WinRT.Code.MVVM.Views;
using Broken_WinRT.Code.Utilities.Handlers.Activation;
using Broken_WinRT.Code.Utilities.Services.Themes;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Broken_WinRT.Code.Utilities.Services.Activation;

public class ActivationService(ActivationHandler<LaunchActivatedEventArgs> defaultHandler, IEnumerable<IActivationHandler> activationHandlers, IThemeSelectorService themeSelectorService) : IActivationService
{
    private UIElement? _shell { get; set; } = null;

    /// <summary>
    /// <inheritdoc/>
    /// <para>Here, the object is the <see cref="App"/>.</para>
    /// </summary>
    /// <param name="activationArgs"></param>
    /// <returns></returns>
    public async Task ActivateAsync(object activationArgs)
    {
        await InitializeAsync();
        SetMainWindowContent();
        await HandleActivationAsync(activationArgs);
        App.MainWindow.Activate();
        await StartupAsync();
    }

    /// <summary>
    ///Executes pre-activation tasks.
    /// <para> This method is called before the <see cref="WindowEx"/> is activated. Only code that needs to be executed before app 
    /// activation should be placed here, as the splash screen is shown while this code is executed.</para>
    /// </summary>
    /// <returns></returns>
    private async Task InitializeAsync()
    {
        await themeSelectorService.InitializeAsync().ConfigureAwait(false);
        await Task.CompletedTask;
    }

    /// <summary>
    /// Sets <see cref="App.MainWindow"/> content.
    /// </summary>
    private void SetMainWindowContent()
    {
        if (App.MainWindow.Content == null)
        {
            _shell = App.GetService<ShellPageView>();
            App.MainWindow.Content = _shell ?? new Frame();
        }
    }

    /// <summary>
    /// Gets the first <see cref="ActivationHandler{T}"/> that can handle the arguments of the current activation. 
    /// It executes the <see cref="ActivationHandler{LaunchActivatedEventArgs}"/> _defaultHandler
    /// if no other <see cref="ActivationHandler{T}"/> is selected or the selected <see cref="ActivationHandler{T}"/> does not result in Navigation.
    /// </summary>
    /// <param name="activationArgs"></param>
    /// <returns></returns>
    private async Task HandleActivationAsync(object activationArgs)
    {
        var activationHandler = activationHandlers.FirstOrDefault(h => h.CanHandle(activationArgs));

        if (activationHandler is not null)
        {
            await activationHandler.HandleAsync(activationArgs);
        }

        if (defaultHandler.CanHandle(activationArgs))
        {
            await defaultHandler.HandleAsync(activationArgs);
        }
    }

    /// <summary>
    /// Executes post-activation tasks.
    /// <para>Contains initializations of other classes that do not need to happen before <see cref="App"/> activation 
    /// and starts processes that will be run after the <see cref="WindowEx"/> is activated.</para>
    /// </summary>
    /// <returns></returns>
    private async Task StartupAsync()
    {
        await themeSelectorService.SetRequestedThemeAsync();
        await Task.CompletedTask;
    }
}
