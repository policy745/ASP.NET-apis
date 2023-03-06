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
        public IActionResult OnGet()
        {
            IEnumerable<Model.Domain.Region> regions = _regionRepository.GetRegions();

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

            var DTORegions = _mapper.Map<List <Model.DTOs.Region>>(regions);



            return Ok(DTORegions);
        }
    }
}
