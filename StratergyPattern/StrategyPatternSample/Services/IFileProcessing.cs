namespace StrategyPatternSample.Services
{
    public interface IFileProcessing
    {
        string ProcessFile(IFormFile fromfile);
        bool SupportsFileType(string fileExtension);
    }
}
