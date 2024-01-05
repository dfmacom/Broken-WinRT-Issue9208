using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Broken_WinRT.Core.Services.Files;

namespace Broken_WinRT.Core.Services;

public partial class FileService : IFileService
{
    public async Task<T> ReadJson<T>(string folderPath, string fileName)
    {
        var path = Path.Combine(folderPath, fileName);
        if (File.Exists(path))
        {
            var fileStream = new FileStream(folderPath, FileMode.OpenOrCreate);
            return await JsonSerializer.DeserializeAsync<T>(fileStream) ?? throw new JsonException($"Unable to deserialize the JSON string at {path} into type {typeof(T).Name}");
        }
        else
        {
            throw new FileNotFoundException($"File \"{path}\" not found.");
        }
    }

    public async Task SaveToJson<T>(string folderPath, string fileName, T content)
    {
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        var fileStream = new FileStream(folderPath, FileMode.OpenOrCreate);
        await JsonSerializer.SerializeAsync(fileStream, content);
    }

    public void Delete(string folderPath, string fileName)
    {
        if (fileName != null && File.Exists(Path.Combine(folderPath, fileName)))
        {
            File.Delete(Path.Combine(folderPath, fileName));
        }
    }

    public string RequestFiles(string message)
    {
        string? path = null;
        Console.WriteLine(message);
        while (!(Directory.Exists(path) || File.Exists(path)))
        {
            var response = Console.ReadLine();
            if (response is not null)
            {
                path = response.Trim('"');
            }
        }
        return path;
    }

    public async Task<string?> OpenReadFile(FileInfo file)
    {
        using var fileStream = file.OpenRead();
        var byteArray = new byte[file.Length];
        var encoder = new UTF8Encoding(true);
        string? fileContent = null;
        Console.WriteLine($"Beginning to read {file.Name}...");
        while (await fileStream.ReadAsync(byteArray) > 0)
        {
            fileContent = encoder.GetString(byteArray);
        }
        Console.WriteLine($"Finished reading {file.Name}.");
        return fileContent;
    }

    public async Task WriteFile(string fileName, string? content)
    {
        using var writer = new StreamWriter(fileName, true);
        await writer.WriteAsync(content);
    }

    internal static string GetTestType(string fileExtension)
    {
        if (SParFileExtensionRegex().IsMatch(fileExtension))
        {
            return "Small Signal S-Parameters";
        }
        else if (PowerFileExtensionRegex().IsMatch(fileExtension))
        {
            return "Power Sweep";
        }
        throw new ApplicationException($"{fileExtension} file is unsupported Test Data type.");
    }

    #region Regex
    [GeneratedRegex("[.][Ss][0-9][Pp]")]
    public static partial Regex SParFileExtensionRegex();

    [GeneratedRegex("[.](PWR|pwr)")]
    public static partial Regex PowerFileExtensionRegex();
    #endregion
}
