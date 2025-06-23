namespace CrewChange.Application.Interfaces;

public interface IBlobStorageService
{
    Task<string> UploadFileAsync(string fileName, Stream fileStream);
    Task DeleteFileAsync(string fileName);
}
