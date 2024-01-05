namespace Broken_WinRT.Code.Utilities.Handlers.Activation;

// Extend this class to implement new ActivationHandlers. See DefaultActivationHandler for an example.
// https://github.com/microsoft/TemplateStudio/blob/main/docs/WinUI/activation.md
public abstract class ActivationHandler<T> : IActivationHandler where T : class
{
    /// <summary>
    /// Checks whether or not the <see cref="ActivationHandler{T}"/> can handle the activation.
    /// <para>Override this method to add the logic for whether to handle the activation.</para>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    protected virtual bool CanHandleInternal(T args) => true;

    /// <summary>
    /// <see cref="HandleInternalAsync(T)"/> is where the actual activation takes place
    /// after the virtual method <see cref="CanHandleInternal(T)"/> checks if the incoming activation arguments are 
    /// of the type that the <see cref="IActivationHandler"/> can manage.
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    protected abstract Task HandleInternalAsync(T args);

    public bool CanHandle(object args) => args is T && CanHandleInternal((args as T)!);

    public async Task HandleAsync(object args) => await HandleInternalAsync((args as T)!);
}
