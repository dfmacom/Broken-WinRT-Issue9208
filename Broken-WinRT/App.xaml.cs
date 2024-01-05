using Broken_WinRT.Core.Services;
using Broken_WinRT.Code.MVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using Broken_WinRT.Code;
using Broken_WinRT.Code.MVVM;
using Broken_WinRT.Code.Utilities.Handlers.Activation;
using Broken_WinRT.Code.Utilities.Services.Notifications;
using Broken_WinRT.Code.Utilities.Services.Navigation;
using Broken_WinRT.Code.Utilities.Services.Activation;
using Broken_WinRT.Code.Utilities.Services.Settings;
using Broken_WinRT.Code.Utilities.Services.Pages;
using Broken_WinRT.Code.Utilities.Services.Themes;
using Broken_WinRT.Code.Utilities.Services.Navigation.Views;
using Broken_WinRT.Code.Utilities.Handlers.Activation.Notifications;
using Broken_WinRT.Code.Utilities.Extensions;
using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Code.MVVM.Views.Templates;
using Broken_WinRT.Code.MVVM.Views;
using Broken_WinRT.Code.MVVM.Models;
using Broken_WinRT.Code.MVVM.Views.DataHub;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub;
using Broken_WinRT.Core.Services.Files;
using Broken_WinRT.Core.Services.Data.Templates;
using Broken_WinRT.Code.MVVM.Models.DataHub;
using Broken_WinRT.Core.MVVM.Models;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataLoader;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataTableViewer;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataFileWriter;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataAnalyzer;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataSetDesigner;

namespace Broken_WinRT;

// To learn more about WinUI 3, see https://docs.microsoft.com/windows/apps/winui/winui3/.
public partial class App : Application
{
    // The .NET Generic Host provides dependency injection, configuration, logging, and other services.
    // https://docs.microsoft.com/dotnet/core/extensions/generic-host
    // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
    // https://docs.microsoft.com/dotnet/core/extensions/configuration
    // https://docs.microsoft.com/dotnet/core/extensions/logging
    public IHost Host { get; }

    public static T GetService<T>() where T : class
    {
        if ((Current as App)!.Host.Services.GetService(typeof(T)) is not T service)
        {
            throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.");
        }
        return service;
    }

    public static WindowEx MainWindow { get; } = new MainWindow();

    public static UIElement? AppTitlebar { get; set; }

    public App()
    {
        InitializeComponent();
        Host = Microsoft.Extensions.Hosting.Host.
        CreateDefaultBuilder().
        UseContentRoot(AppContext.BaseDirectory).
        ConfigureServices(InitializeServices).
        Build();
        UnhandledException += App_UnhandledException;
    }

    private void App_UnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
    {
        // TODO: Log and handle exceptions as appropriate.
        // https://docs.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.application.unhandledexception.
    }

    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);
        var payload = string.Format("AppNotificationSamplePayload".GetLocalized(), AppContext.BaseDirectory);
        GetService<IAppNotificationService>().Show(payload);
        await GetService<IActivationService>().ActivateAsync(args);
    }

    private void InitializeServices(HostBuilderContext context, IServiceCollection services)
    {
        #region Registration
        #region Activation handlers
        // Default Activation Handler
        services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();
        // Other Activation Handlers
        services.AddTransient<IActivationHandler, AppNotificationActivationHandler>();
        #endregion

        #region Services
        services.AddSingleton<IAppNotificationService, AppNotificationService>();
        services.AddSingleton<ILocalSettingsService, LocalSettingsService>();
        services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
        services.AddTransient<INavigationViewService, NavigationViewService>();
        services.AddSingleton<IActivationService, ActivationService>();
        services.AddSingleton<IPageService, PageService>();
        services.AddSingleton<INavigationService, NavigationService>();

        #region Core
        services.AddSingleton<ISampleDataService, SampleDataService>();
        services.AddSingleton<IFileService, FileService>();
        #endregion
        #endregion

        #region MVVM
        #region Shell
        services.AddTransient<ShellPageView>();
        services.AddTransient<ShellViewModel>();
        #endregion
        #region Templates
        #region Home
        services.AddTransient<HomeViewModel>();
        services.AddTransient<HomePageView>();
        #endregion
        #region List Details
        services.AddTransient<ListDetailsViewModel>();
        services.AddTransient<ListDetailsPageView>();
        #endregion
        #region Content Grid
        services.AddTransient<ContentGridDetailViewModel>();
        services.AddTransient<ContentGridDetailPageView>();
        services.AddTransient<ContentGridViewModel>();
        services.AddTransient<ContentGridPageView>();
        #endregion
        #region Data Grid
        services.AddTransient<DataGridViewModel>();
        services.AddTransient<DataGridPageView>();
        #endregion
        #endregion

        #region Data Hub
        services.AddTransient<DataHubHomePageView>();
        services.AddTransient<DataHubHomePageViewModel>();
        #region Actions
        services.AddTransient<IModel<DataHubHomePageViewModel>, LoadDataActionModel>();
        services.AddTransient<DataLoaderViewModel>();
        services.AddTransient<IModel<DataHubHomePageViewModel>, AnalyzeDataActionModel>();
        services.AddTransient<DataAnalyzerViewModel>();
        services.AddTransient<IModel<DataHubHomePageViewModel>, WriteDataFilesActionModel>();
        services.AddTransient<DataWriterViewModel>();
        services.AddTransient<IModel<DataHubHomePageViewModel>, ViewDataTablesActionModel>();
        services.AddTransient<DataTableViewerViewModel>();
        services.AddTransient<IModel<DataHubHomePageViewModel>, CreateCustomDataSetsActionModel>();
        services.AddTransient<DataSetDesignerViewModel>();
        services.AddTransient<IModel<DataHubHomePageViewModel>, CreateDataReportsActionModel>();
        #endregion
        #endregion
        #region Settings
        services.AddTransient<SettingsViewModel>();
        services.AddTransient<SettingsPageView>();
        #endregion
        #endregion
        #endregion

        #region Configuration
        services.Configure<LocalSettingsOptionsModel>(context.Configuration.GetSection(nameof(LocalSettingsOptionsModel)));
        #endregion
    }
}
