namespace StrategyPatternSample.Services
{
    public class PdfFileProcessorService : IFileProcessing
    {
        public PdfFileProcessorService() { }
        public bool SupportsFileType(string fileExtension)
        {
            return fileExtension.Equals(".pdf", StringComparison.OrdinalIgnoreCase);
        }
        public string ProcessFile(IFormFile fromfile)
        {
            return "PDF file parsed successfully";
        }
    }
}
