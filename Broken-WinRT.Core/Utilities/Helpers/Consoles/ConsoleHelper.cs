namespace Broken_WinRT.Core.Utilities.Helpers.Consoles;
internal static class ConsoleHelper
{
    internal static void HandleNull()
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        var currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.WriteLine("Please select a valid value!");
    }
}
