namespace StrategyPatternSample.Services
{
    public class JpgFileProcessorService : IFileProcessing
    {
        public JpgFileProcessorService() { }
        public bool SupportsFileType(string fileExtension)
        {
            return fileExtension.Equals(".jpg", StringComparison.OrdinalIgnoreCase);
        }
        public string ProcessFile(IFormFile fromfile)
        {
            return "JPG file parsed successfully";
        }
    }
}
