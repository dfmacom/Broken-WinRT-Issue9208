using CommunityToolkit.Mvvm.ComponentModel;
using Broken_WinRT.Code.MVVM.Models.DataHub;
using Broken_WinRT.Code.MVVM.ViewModels;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataAnalyzer;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataFileWriter;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataLoader;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataSetDesigner;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataTableViewer;
using Broken_WinRT.Code.MVVM.ViewModels.Templates;
using Broken_WinRT.Code.MVVM.Views;
using Broken_WinRT.Code.MVVM.Views.DataHub;
using Broken_WinRT.Code.MVVM.Views.DataHub.DataAnalyzer;
using Broken_WinRT.Code.MVVM.Views.DataHub.DataFileWriter;
using Broken_WinRT.Code.MVVM.Views.DataHub.DataLoader;
using Broken_WinRT.Code.MVVM.Views.DataHub.DataSetDesigner;
using Broken_WinRT.Code.MVVM.Views.DataHub.DataTableViewer;
using Broken_WinRT.Code.MVVM.Views.Templates;
using Microsoft.UI.Xaml.Controls;

namespace Broken_WinRT.Code.Utilities.Services.Pages;

public class PageService : IPageService
{
    private readonly Dictionary<string, Type> _pages = [];

    public PageService()
    {
        #region Templates
        Configure<HomeViewModel, HomePageView>();
        Configure<ListDetailsViewModel, ListDetailsPageView>();
        Configure<ContentGridViewModel, ContentGridPageView>();
        Configure<ContentGridDetailViewModel, ContentGridDetailPageView>();
        Configure<DataGridViewModel, DataGridPageView>();
        #endregion

        #region Data Hub
        Configure<DataHubHomePageViewModel, DataHubHomePageView>();
        Configure<DataLoaderViewModel, DataLoaderHomePageView>();
        Configure<DataAnalyzerViewModel, DataAnalyzerHomePageView>();
        Configure<DataWriterViewModel, DataFileWriterHomePageView>();
        Configure<DataTableViewerViewModel, DataTableViewerHomePageView>();
        Configure<DataSetDesignerViewModel, DatasetDesignerHomePageView>();
        #endregion

        Configure<SettingsViewModel, SettingsPageView>();
    }

    public Type GetPageType(string key)
    {
        Type? pageType;
        lock (_pages)
        {
            if (!_pages.TryGetValue(key, out pageType))
            {
                throw new ArgumentException($"Page not found: {key}. Did you forget to call PageService.Configure?");
            }
        }

        return pageType;
    }

    private void Configure<VM, V>()
        where VM : ObservableObject
        where V : Page
    {
        lock (_pages)
        {
            var key = typeof(VM).FullName!;
            if (_pages.ContainsKey(key))
            {
                throw new ArgumentException($"The key {key} is already configured in PageService");
            }

            var type = typeof(V);
            if (_pages.ContainsValue(type))
            {
                throw new ArgumentException($"This type is already configured with key {_pages.First(p => p.Value == type).Key}");
            }

            _pages.Add(key, type);
        }
    }
}
