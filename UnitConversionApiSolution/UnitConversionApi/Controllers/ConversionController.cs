using Microsoft.AspNetCore.Mvc;

namespace UnitConversionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _conversionService;
        public ConversionController(IConversionService conversionService)
        {
            _conversionService = conversionService;
        }
        [HttpPost]
        public IActionResult Convert(ConversionRequest request)
        {
            var result = _conversionService.Convert(
                request.Category,
                request.Value,
                request.FromUnit,
                request.ToUnit);
            return Ok(new ConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedValue = result
            });
        }
    }
}