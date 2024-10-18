namespace StrategyPatternSample.Services
{
    public class FileProcessorFactory
    {
        private readonly IEnumerable<IFileProcessing> _fileProcessings;
        public FileProcessorFactory(IEnumerable<IFileProcessing> fileProcessings)
        {
            _fileProcessings = fileProcessings;
        }
        public IFileProcessing GetFileProcessing(string fileExtention)
        {
            return _fileProcessings.FirstOrDefault(x=>x.SupportsFileType(fileExtention));
        }

    }
}
