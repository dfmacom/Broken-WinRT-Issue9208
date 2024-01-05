using System.Collections.Specialized;

namespace Broken_WinRT.Code.Utilities.Services.Notifications;

public interface IAppNotificationService
{
    void Initialize();

    bool Show(string payload);

    NameValueCollection ParseArguments(string arguments);

    void Unregister();
}
