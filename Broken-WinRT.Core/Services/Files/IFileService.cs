namespace Broken_WinRT.Core.Services.Files;

public interface IFileService
{
    Task<T> ReadJson<T>(string folderPath, string fileName);
    Task SaveToJson<T>(string folderPath, string fileName, T content);
    void Delete(string folderPath, string fileName);
    string RequestFiles(string message);
    Task<string?> OpenReadFile(FileInfo file);
    Task WriteFile(string fileName, string? content);
}
