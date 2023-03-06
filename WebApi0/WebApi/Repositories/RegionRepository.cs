using WebApi.Data;
using WebApi.Model.Domain;

namespace WebApi.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WebApiDbContext _db;
        public RegionRepository(WebApiDbContext db)
        {
            _db = db;

        }
        public IEnumerable<Region> GetRegions()
        {
            return _db.Regions.ToList();
        }
    }
}
