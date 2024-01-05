using Broken_WinRT.Code.MVVM.ViewModels.DataHub;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataAnalyzer;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataFileWriter;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataLoader;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataReporter;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataSetDesigner;
using Broken_WinRT.Code.MVVM.ViewModels.DataHub.DataTableViewer;
using Broken_WinRT.Core.MVVM.Models;

namespace Broken_WinRT.Code.MVVM.Models.DataHub;

public abstract class DataHubActionModel : Model<DataHubHomePageViewModel>
{
    protected DataHubActionModel(string description, string symbolName, string glyph, Type viewModelType) : base(description, symbolName, glyph, viewModelType)
    {
    }
}

public sealed class LoadDataActionModel : DataHubActionModel
{
    public LoadDataActionModel() 
        : base("Load Data",
            "FileExplorerApp",
            "\uEC50", 
            typeof(DataLoaderViewModel)) { }
}

public sealed class AnalyzeDataActionModel : DataHubActionModel
{
    public AnalyzeDataActionModel() 
        : base("Analyze Data",
            "Filter",
            "\uE71C",
            typeof(DataAnalyzerViewModel)) { }
}

public sealed class WriteDataFilesActionModel : DataHubActionModel
{
    public WriteDataFilesActionModel() 
        : base("Write Data Files",
            "SaveAs",
            "\uE792", 
            typeof(DataWriterViewModel)) { }
}

public sealed class CreateDataReportsActionModel : DataHubActionModel
{
    public CreateDataReportsActionModel()
    : base("Create Data Reports",
            "ReportDocument",
            "\uE9F9", 
            typeof(DataReporterViewModel)) { }
}

public sealed class ViewDataTablesActionModel : DataHubActionModel
{
    public ViewDataTablesActionModel()
        : base("View Data Tables",
            "View",
            "\uE890", 
            typeof(DataTableViewerViewModel)) { }
}

public sealed class CreateCustomDataSetsActionModel : DataHubActionModel
{
    public CreateCustomDataSetsActionModel()
        : base("Create Custom Data Sets",
            "TiltDown",
            "\uE80A", 
            typeof(DataSetDesignerViewModel)) { }
}
