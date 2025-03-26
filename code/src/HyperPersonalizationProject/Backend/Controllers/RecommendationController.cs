using Microsoft.AspNetCore.Mvc;
using HyperPersonalizationProject.Models;
using HyperPersonalizationProject.Services;

namespace HyperPersonalizationProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationController : ControllerBase
    {
        private readonly RecommendationService _recommendationService;

        public RecommendationController(RecommendationService recommendationService)
        {
            _recommendationService = recommendationService;
        }

        [HttpPost("get")]
        public IActionResult GetRecommendation([FromBody] FeedbackRequest request)
        {
            // Call the service to get a recommendation based on feedback.
            var recommendation = _recommendationService.GetRecommendation(request);
            return Ok(recommendation);
        }
    }
}