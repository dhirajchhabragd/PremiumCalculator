using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Services;

namespace PremiumCalculator.Controllers
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class OccupationController : Controller
    {
        private IOccupationService _occupationService;

        public OccupationController(IOccupationService occupationService)
        {
            _occupationService = occupationService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetOccupations()
        {
            return Ok(_occupationService.GetOccupations());
        }
    }
}
