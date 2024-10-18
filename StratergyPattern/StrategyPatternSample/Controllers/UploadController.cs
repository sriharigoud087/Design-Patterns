using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StrategyPatternSample.Services;

namespace StrategyPatternSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private  readonly FileProcessorFactory _fileProcessorFactory;
        public UploadController(FileProcessorFactory fileProcessorFactory)
        {
            _fileProcessorFactory = fileProcessorFactory;
        }


        [HttpPost]
        [Route("UploadFile")]
        public IActionResult UploadFile(IFormFile formFile)
        {
            try
            {
                var fileExtension = Path.GetExtension(formFile.FileName);
                var processor = _fileProcessorFactory.GetFileProcessing(fileExtension);
                return Ok(processor.ProcessFile(formFile));
            }
            catch (NotSupportedException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
