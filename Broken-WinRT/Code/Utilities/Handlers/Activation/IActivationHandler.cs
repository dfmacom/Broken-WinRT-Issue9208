namespace Broken_WinRT.Code.Utilities.Handlers.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
