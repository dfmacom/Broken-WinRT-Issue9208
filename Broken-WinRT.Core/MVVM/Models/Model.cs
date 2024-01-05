namespace Broken_WinRT.Core.MVVM.Models;


public interface IModel
{
    public string Description { get; } 
    
    public string IconName { get;  }

    public string Glyph { get; }

    public Type ViewModelType { get; }
}

public interface IModel<T> : IModel
{

}

public abstract class Model<T> : IModel<T>
{
    public string Description { get; protected set; }

    public string IconName { get; protected set; }

    public string Glyph { get; protected set; }

    public Type ViewModelType { get; protected set; }

    protected Model(string description, string symbolName, string glyph, Type viewModelType)
    {
        Description = description;
        IconName = symbolName;
        Glyph = glyph;
        ViewModelType = viewModelType;
    }
}
