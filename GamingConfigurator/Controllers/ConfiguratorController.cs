using Microsoft.AspNetCore.Mvc;
using GamingConfigurator.Services;
using GamingConfigurator.Models;

namespace GamingConfigurator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfiguratorController : ControllerBase
    {
        private readonly RecommendationService _recommendationService;

        public ConfiguratorController(RecommendationService recommendationService)
        {
            _recommendationService = recommendationService;
        }

        [HttpGet("all")]
        public ActionResult<List<DesktopBuild>> GetAllBuilds()
        {
            return _recommendationService.GetAllBuilds();
        }

        [HttpGet("recommend")]
        public ActionResult<List<DesktopBuild>> GetRecommendations([FromQuery] string useCase, [FromQuery] int? maxPrice)
        {
            List<DesktopBuild> builds = _recommendationService.GetRecommendations(useCase, maxPrice);
            return builds.Any() ? Ok(builds) : NotFound("No matching builds found.");
        }
    }
}
