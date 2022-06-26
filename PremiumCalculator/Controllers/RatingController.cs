using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Controllers
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class RatingController : Controller
    {
        private IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetRatings()
        {
            return Ok(_ratingService.GetRatings());
        }
    }
}
