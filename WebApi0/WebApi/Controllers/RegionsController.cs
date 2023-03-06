using Microsoft.AspNetCore.Mvc;
using WebApi.Model.Domain;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/regions")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionRepository;
        public RegionsController(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;

        }
        [HttpGet]
        public IActionResult OnGet()
        {
            IEnumerable<Region> regions = _regionRepository.GetRegions();

            return Ok(regions);
        }
    }
}
