namespace StrategyPatternSample.Services
{
    public class CsvFileProcessorService : IFileProcessing
    {
        public CsvFileProcessorService() { }
        public bool SupportsFileType(string fileExtension)
        {
            return fileExtension.Equals(".csv", StringComparison.OrdinalIgnoreCase);
        }
        public string ProcessFile(IFormFile fromfile)
        {
            return "CSV file parsed successfully";
        }

    }
}
