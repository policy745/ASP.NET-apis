using WebApi.Model.Domain;

namespace WebApi.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetRegionsAsync();
        Task<Region> GetRegion(Guid id);
    }
}
