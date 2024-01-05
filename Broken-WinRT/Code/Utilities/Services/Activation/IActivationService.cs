namespace Broken_WinRT.Code.Utilities.Services.Activation;

public interface IActivationService
{
    /// <summary>
    /// Activates the object at hand. 
    /// </summary>
    /// <param name="activationArgs"></param>
    /// <returns></returns>
    Task ActivateAsync(object activationArgs);
}
