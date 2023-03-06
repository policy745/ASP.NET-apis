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

            //Using DTO model instead of exposing our Domain model
            List<Model.Domain.DTOs.Region> DTORegions = new List<Model.Domain.DTOs.Region>();
            regions.ToList().ForEach(region =>
            {
                var regions = new Model.Domain.DTOs.Region()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    Lat= region.Lat,
                    Long= region.Long,
                    Population= region.Population,
                    Area = region.Area
                };

                DTORegions.Add(regions);
            });


            return Ok(DTORegions);
        }
    }
}
