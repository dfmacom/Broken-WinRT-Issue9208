using System.Reflection;

namespace Broken_WinRT.Core.Utilities.Reflection;
internal static class Metadata
{
    internal static string AssemblyDirectory
    {
        get
        {
            var codeBase = Assembly.GetExecutingAssembly().Location;
            var uri = new UriBuilder(codeBase);
            var unescapedPath = Uri.UnescapeDataString(uri.Path);
            var path = Path.GetDirectoryName(unescapedPath) ?? throw new NullReferenceException("The assembly directory returned null.");
            return path;
        }
    }
}
