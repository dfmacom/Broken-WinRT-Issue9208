using System.Reflection;

namespace Broken_WinRT.Core.Utilities.Enumerations;

public abstract class Enumeration : IComparable
{
    public string Name
    {
        get; private set;
    }

    public int Id
    {
        get; private set;
    }

    protected Enumeration(int id, string name)
    {
        (Id, Name) = (id, name);
    }

    public override string ToString() => Name;

    public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
                 .Select(f => f.GetValue(null))
                 .Cast<T>();

    public override bool Equals(object? obj)
    {
        if (obj is not Enumeration otherValue)
        {
            return false;
        }

        var typeMatches = GetType().Equals(obj.GetType());
        var valueMatches = Id.Equals(otherValue.Id);

        return typeMatches && valueMatches;
    }

    public override int GetHashCode() => Id;

    public int CompareTo(object? other) => Id.CompareTo(((Enumeration)other).Id);

    // Other utility methods ...
}

public class NavigationViewHeaderMode : Enumeration
{
    public static readonly NavigationViewHeaderMode Always = new(0, nameof(Always));
    public static readonly NavigationViewHeaderMode Never = new(1, nameof(Never));
    public static readonly NavigationViewHeaderMode Minimal = new(2, nameof(Minimal));

    private NavigationViewHeaderMode(int id, string name) : base(id, name) { }
}

