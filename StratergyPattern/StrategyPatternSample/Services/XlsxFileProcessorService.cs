namespace StrategyPatternSample.Services
{
    public class XlsxFileProcessorService : IFileProcessing
    {
        public XlsxFileProcessorService() { }
        public bool SupportsFileType(string fileExtension)
        {
            return fileExtension.Equals(".xlsx", StringComparison.OrdinalIgnoreCase);
        }
        public string ProcessFile(IFormFile fromfile)
        {
            return "xlsx file parsed successfully";
        }

    }
}
