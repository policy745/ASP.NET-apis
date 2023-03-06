using Microsoft.AspNetCore.Mvc;
using WebApi.Model.Domain;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/regions")]
    public class RegionsController : Controller
    {

        List<Region> regions = new()
        {
            new Region()
            {
                Id = Guid.NewGuid(),
                Code = "sample",
                Name = "Name",
                Area = 123456,
                Lat = -23.4,
                Long = 233,
                Population = 120
            },
            new Region ()
            {
                Id = Guid.NewGuid(),
                Code = "udemy",
                Name = "Name",
                Area = 309,
                Lat = 29,
                Long= 30,
                Population= 31
            }

        };
        [HttpGet]
        public IActionResult OnGet()
        {
            return Ok(regions);
        }
    }
}
