using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model.Domain;
using WebApi.Model.DTOs;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/regions")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;
        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<IActionResult> OnGet()
        {
            IEnumerable<Model.Domain.Region> regions = await _regionRepository.GetRegionsAsync();

            //Using DTO model instead of exposing our Domain model
            //List<Model.DTOs.Region> DTORegions = new List<Model.DTOs.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regions = new Model.DTOs.Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Lat= region.Lat,
            //        Long= region.Long,
            //        Population= region.Population,
            //        Area = region.Area
            //    };

            //    DTORegions.Add(regions);
            //});

            List<Model.DTOs.Region> DTORegions = _mapper.Map<List<Model.DTOs.Region>>(regions);



            return Ok(DTORegions);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRegion(Guid id)
        {
            if (id == null)
                return NotFound();

            Model.Domain.Region regionId = await _regionRepository.GetRegion(id);
            Model.DTOs.Region DTORegion = _mapper.Map<Model.DTOs.Region>(regionId);

            return Ok(DTORegion);

        }
    }
}
