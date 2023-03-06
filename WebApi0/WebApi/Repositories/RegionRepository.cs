using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Region>> GetRegionsAsync()
        {
            return await _db.Regions.ToListAsync();
        }
        public async Task<Region> GetRegion(Guid id)
        {
            Region region = await _db.Regions.FirstOrDefaultAsync(r => r.Id == id);

            return region;

        }
    }
}
