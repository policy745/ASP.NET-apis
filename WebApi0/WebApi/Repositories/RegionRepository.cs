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
        public async Task<IEnumerable<Region>> GetRegions()
        {
            return await _db.Regions.ToListAsync();
        }
    }
}
